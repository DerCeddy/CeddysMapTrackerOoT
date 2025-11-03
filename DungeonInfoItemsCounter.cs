using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class DungeonInfoItemsCounter : Label
    {
        public int ItemAmount
        {
            get
            {
                return _itemAmount;
            }
            set
            {
                _itemAmount = value;
                ItemAmountOnValueChanged(null);
            }
        }
        private int _itemAmount;
        public DungeonInfoItemsCounter() 
        {
            Size = new Size(48, 48);
            BackColor = Color.Yellow;
            Image = Resources.closed_chest_48;
            ForeColor = Color.White;
            FlatStyle = FlatStyle.Flat;
            BorderStyle = BorderStyle.None;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font("Arial",22, GraphicsUnit.Pixel);
            ValueChanged += (sender,e) => UpdateImage();
            UpdateText();
            UpdateImage();
        }
        public void UpdateText()
        {
            Text = ItemAmount.ToString();
        }
        public void UpdateImage()
        {
            if(ItemAmount > 0)
            {
                Image = Resources.closed_chest_48;
            }
            else
            {
                Image = Resources.open_chest_48;
            }
        }
        public event EventHandler ValueChanged;
        protected virtual void ItemAmountOnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
