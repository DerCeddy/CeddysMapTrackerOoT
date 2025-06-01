using OoTItemTrackerNew.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class Gossipstone : PictureBox
    {
        public bool IsDragging = false;
        public Point PreviousMousePos;
        public int PreviousState;
        public Image PreviousImg;
        public int _state;
        public Gossipstone(Point _location)
        {
            Image = Resources.gossip_stone_bw_32x32;
            Size = new Size(24, 24);
            Location = _location;
            AllowDrop = true;
            SizeMode = PictureBoxSizeMode.StretchImage;
            MouseUp += GossipStone_MouseUp;
            DragEnter += GossipStone_DragEnter;
            DragDrop += (sender, e) => GossipStone_DragDrop(e, this);
            MouseDown += (sender, e) => Drag_MouseDown(e, this);
            MouseMove += (sender, e) => MouseMoveForDrag(e, this);
            MouseDown += (sender, e) => GossipStone_Click(e, this);
        }
        private static void GossipStone_Click(MouseEventArgs e, Gossipstone PathStone)
        {
            if (e.Button == MouseButtons.Right)
            {
                PathStone._state--;
                if (PathStone._state <= -1)
                {
                    PathStone._state = 0;
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                PathStone._state++;
                if (PathStone._state >= 4)
                {
                    PathStone._state = 3;
                }
            }
            PathStone.UpdateImage();
        }
        public void GossipStone_MouseUp(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                IsDragging = false;
            }
        }
        public void GossipStone_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
                e.Effect = DragDropEffects.Move;
        }
        static void GossipStone_DragDrop(DragEventArgs e, PictureBox PathStone)
        {
            Bitmap bmp = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            PathStone.Image = bmp;
        }
        public void Drag_MouseDown(MouseEventArgs e, Gossipstone g)
        {
            if (e.Button == MouseButtons.Left)
            {
                IsDragging = true;
                PreviousMousePos = e.Location;
                PreviousState = g._state;
                PreviousImg = g.Image;
            }
        }
        private void DragAndDrop(Gossipstone pb)
        {
            IsDragging = false;
            var img = pb.PreviousImg;
            if (img == null) return;
            pb.Image = Resources.gossip_stone_bw_32x32;
            DoDragDrop(img, DragDropEffects.Move);
        }
        private void MouseMoveForDrag(MouseEventArgs e, Gossipstone p)
        {
            if (IsDragging)
            {
                if ((System.Math.Abs(e.X - PreviousMousePos.X) > 10) || (System.Math.Abs(e.Y - PreviousMousePos.Y) > 10))
                {
                    DragAndDrop(p);
                    p._state = 0;
                }
            }
        }
        private void UpdateImage()
        {
            switch (_state)
            {
                case 0:
                    Image = Resources.gossip_stone_bw_32x32;
                    break;
                case 1:
                    Image = Resources.Soldout;
                    break;
                case 2:
                    Image = Resources.MM3D_Small_Key_Icon;
                    break;
                case 3:
                    Image = Resources.MM3D_Boss_Key_Icon;
                    break;
            }
        }
    }
}
