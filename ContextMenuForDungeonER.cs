using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class ContextMenuForDungeonER : Panel
    {       
        private int _Goal;
        public int Goal
        {
            get
            {
                return _Goal;
            }
            set
            {
                _Goal = value;
                OnValueChanged(null);
            }
        }
        public ContextMenuForDungeonER()
        {           
            _Goal = 0;
            Size = new Size(140, 140);
            BackColor = Color.Black;
            PictureBox CloseButton = new();
            CloseButton.Image = Resources.Soldout;
            CloseButton.Location = new Point(54, 54);
            CloseButton.Size = new Size(32, 32);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            ContextMenuGoalButton PhantomGanon = new(Resources.pg_32x32, new Point(58, 0), 3);
            ContextMenuGoalButton Volvagia = new(Resources.volvagia_32x32, new Point(90, 16), 4);
            ContextMenuGoalButton Morpha = new(Resources.morpha_32x32, new Point(110, 44), 5);
            ContextMenuGoalButton Bongo = new(Resources.bongo_32x32, new Point(110, 72),6);
            ContextMenuGoalButton Twinrova = new(Resources.twinrova_32x32, new Point(90, 100), 7);
            ContextMenuGoalButton Gohma = new(Resources.gohma_32x32, new Point(58, 116), 0);
            ContextMenuGoalButton Dodongo = new(Resources.dodongo_32x32, new Point(26, 100), 1);
            ContextMenuGoalButton Barinade = new(Resources.barinade_32x32, new Point(4, 72), 2);
            ContextMenuGoalButton BotW = new((Bitmap)Image.FromFile("Textures/3DS/OoT3D_Lens_of_Truth_Icon.png"), new Point(4, 44), 8);
            ContextMenuGoalButton GTG = new((Bitmap)Image.FromFile("Textures/3DS/OoT3D_Gerudo_Token_Icon.png"), new Point(26, 16), 9);
            ContextMenuGoalButton Ice = new(Resources.IceCavern, new Point(26, 16), 10);
            Controls.Add(CloseButton);
            Controls.Add(PhantomGanon);
            Controls.Add(Volvagia);
            Controls.Add(Morpha);
            Controls.Add(Bongo);
            Controls.Add(Twinrova);
            Controls.Add(Gohma);
            Controls.Add(Dodongo);
            Controls.Add(Barinade);
            Controls.Add(BotW);
            Controls.Add(GTG);
            Controls.Add(Ice);
            List<ContextMenuGoalButton> Buttons = [PhantomGanon, Volvagia, Morpha, Bongo, Twinrova, GTG, Ice, Gohma, Dodongo, Barinade, BotW];
            PointF center = new((this.Width / 2) - 12, (this.Height / 2) - 12);
            float radius = 54f;
            for (int i = 0; i < Buttons.Count; i++)
            {
                // Calculate angle in radians: (2 * PI / total points) * current point index
                double angle = (2 * Math.PI / Buttons.Count) * i;
                // Calculate X and Y coordinates using trigonometry
                float x = center.X + (float)(radius * Math.Cos(angle));
                float y = center.Y + (float)(radius * Math.Sin(angle));
                Buttons[i].Location = new Point((int)x,(int)y);
            }
            CloseButton.MouseDown += (sender, e) => CloseContextMenu();
            foreach (Control c in Controls)
            {
                if (c is ContextMenuGoalButton button)
                {
                    button.MouseDown += (sender, e) => ChangeGoalInt(button);
                }
            }
            
        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            using Pen selPen = new(Color.Black, 2);
            g.DrawEllipse(selPen, 0, 0, 13, 13);
        }
        public void AddContextMenu(MouseEventArgs e, DungeonERGossipstone DungeonERGossipstone, Maptracker Maptracker)
        {           
            int posX = e.X + DungeonERGossipstone.Location.X;
            int posY = e.Y + DungeonERGossipstone.Location.Y;
            //+DungeonERGossipstone.Location.X - (Width / 2)
            //+DungeonERGossipstone.Location.Y - (Height / 2)
            if (posX - 70 <= 0)
            {
                posX = 70;
            }
            if (posY - 70 <= 0)
            {
                posY = 70;
            }
            if (posX + 70 >= 857)
            {
                posX = 787;
            }
            if (posY + 70 >= 728)
            {
                posY = 658;
            }            
            BringToFront();
            Location = new Point(posX - (Width / 2), posY - (Height / 2));          
        }
        public void CloseContextMenu()
        {
            Dispose();
        }
        public void ChangeGoalInt(ContextMenuGoalButton button)
        {
            switch (button.ID)
            {               
                case 0:
                    Goal = 0;                
                    break;
                case 1:
                    Goal = 1;
                    break;
                case 2:
                    Goal = 2;
                    break;
                case 3:
                    Goal = 3;
                    break;
                case 4:
                    Goal = 4;
                    break;
                case 5:
                    Goal = 5;
                    break;
                case 6:
                    Goal = 6;
                    break;
                case 7:
                    Goal = 7;
                    break;
                case 8:
                    Goal = 8;
                    break;
                case 9:
                    Goal = 9;
                    break;
                case 10:
                    Goal = 10;
                    break;
            }
            CloseContextMenu();
        }
        public void UpdateRegionPanel()
        {
            
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
