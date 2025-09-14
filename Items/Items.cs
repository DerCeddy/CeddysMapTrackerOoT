using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Item : PictureBox
    {
        
        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnValueChanged(null);
            }
        }
        private int _state;
        public PictureBox? ItemPictureBox;
        public required int MaxCount;
        public required int MinCount;
        public required Bitmap ItemPicture;
        public Bitmap? ItemPicture1;
        public Bitmap? ItemPicture2;
        public Bitmap? ItemPicture3;
        public Bitmap? ItemPicture_bw;
        public string? Item_Name;
        public string? Item_Name1;
        public string? Item_Name2;
        public string? Item_Name3;
        bool IsDragging = false;
        public Color NameColor = Color.Red;
        public Color NameColor1 = Color.Red;
        public Color NameColor2 = Color.Red;
        public Color NameColor3 = Color.Red;
        Point PreviousMousePos;
        int PreviousItemState;
        public Item()
        {
            Size = new Size(42,42);
            MouseDown += (sender, e) => Drag_MouseDown(e, this);
            MouseDown += (sender, e) => MouseClickOnItem(e, this);
            MouseUp += ItemClickMouseUp;
            MouseMove += (sender, e) => MouseMoveForDrag(sender, e, this);
            BackColor = Color.Transparent;
            SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void MouseClickOnItem(MouseEventArgs e, Item i)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    i.State++;
                    if (i.State > MaxCount)
                    {
                        i.State = MaxCount;
                    }
                    break;
                case MouseButtons.Right:
                    i.State--;
                    if (i.State < 0)
                    {
                        i.State = 0;
                    }
                    break;
            }
            UpdateItemState();
        }
        public void UpdateItemState()
        {
            switch (State)
            {
                case 0:
                    Image = ItemPicture_bw;
                    NameColor = Color.Red;
                    NameColor1 = Color.Red;
                    NameColor2 = Color.Red;
                    NameColor3 = Color.Red;
                    break;
                case 1:
                    Image = ItemPicture;
                    NameColor = Color.LimeGreen;
                    NameColor1 = Color.Red;
                    NameColor2 = Color.Red;
                    NameColor3 = Color.Red;
                    break;
                case 2:
                    Image = ItemPicture1;
                    NameColor = Color.LimeGreen;
                    NameColor1 = Color.LimeGreen;
                    NameColor2 = Color.Red;
                    NameColor3 = Color.Red;
                    break;
                case 3:
                    Image = ItemPicture2;
                    NameColor = Color.LimeGreen;
                    NameColor1 = Color.LimeGreen;
                    NameColor2 = Color.LimeGreen;
                    NameColor3 = Color.Red;
                    break;
                case 4:
                    Image = ItemPicture3;
                    NameColor = Color.LimeGreen;
                    NameColor1 = Color.LimeGreen;
                    NameColor2 = Color.LimeGreen;
                    NameColor3 = Color.LimeGreen;
                    break;
            }
        }
        public void Drag_MouseDown(MouseEventArgs e, Item i)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDragging = true;
                PreviousMousePos = e.Location;
                PreviousItemState = i.State;
            }
        }
        public void MouseMoveForDrag(object sender, MouseEventArgs e, Item Item)
        {
            if (IsDragging)
            {
                if ((System.Math.Abs(e.X - PreviousMousePos.X) > 10) || (System.Math.Abs(e.Y - PreviousMousePos.Y) > 10))
                {
                    if (Item.MaxCount > PreviousItemState)
                    {
                        Item.State--;
                        UpdateItemState();                      
                    }
                    DragAndDrop(Item);
                }
            }
        }
        private void DragAndDrop(Item Item)
        {
            IsDragging = false;
            var img = Item.ItemPicture;
            if (img == null) return;
            DoDragDrop(img, DragDropEffects.Move);
        }
        public void ItemClickMouseUp(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                IsDragging = false;
            }
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {          
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    } 
}
