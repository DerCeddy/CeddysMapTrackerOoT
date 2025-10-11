using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CeddyMapTracker.Properties;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public class ContextMenuForWOTHHints : Panel
    {
        public string RegionName;
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
        public ContextMenuForWOTHHints()
        {
            RegionName = string.Empty;
            _Goal = 0;         
            Size = new Size(140,140);
            BackColor = Color.Black;
            PictureBox CloseButton = new();
            CloseButton.Image = Resources.Soldout;
            CloseButton.Location = new Point(54, 54);
            CloseButton.Size = new Size(32,32);
            CloseButton.SizeMode = PictureBoxSizeMode.StretchImage;
            ContextMenuGoalButton PhantomGanon = new(Resources.pg_32x32, new Point(58, 0), 1);
            ContextMenuGoalButton Volvagia = new(Resources.volvagia_32x32, new Point(90, 16), 2);
            ContextMenuGoalButton Morpha = new(Resources.morpha_32x32, new Point(110, 44), 3);
            ContextMenuGoalButton Bongo = new(Resources.bongo_32x32, new Point(110, 72), 4);
            ContextMenuGoalButton Twinrova = new(Resources.twinrova_32x32, new Point(90, 100), 5);
            ContextMenuGoalButton Gohma = new(Resources.gohma_32x32, new Point(58, 116), -1);
            ContextMenuGoalButton Dodongo = new(Resources.dodongo_32x32, new Point(26, 100), -2);
            ContextMenuGoalButton Barinade = new(Resources.barinade_32x32, new Point(4, 72), -3);
            ContextMenuGoalButton Tower = new(Resources.Ganons_Tower, new Point(4, 44), 6);
            ContextMenuGoalButton Important = new(Resources.ImportantHint, new Point(26, 16), 7);
            Controls.Add(CloseButton);
            Controls.Add(PhantomGanon); 
            Controls.Add(Volvagia);
            Controls.Add(Morpha);
            Controls.Add(Bongo);
            Controls.Add(Twinrova);
            Controls.Add(Gohma);
            Controls.Add(Dodongo);
            Controls.Add(Barinade);
            Controls.Add(Tower);
            Controls.Add(Important);
            CloseButton.MouseDown += (sender, e) => CloseContextMenu();
            foreach (Control c in Controls)
            {
                if (c is  ContextMenuGoalButton button)
                {
                    button.MouseDown += (sender, e) => ChangeGoalInt(button);
                }
            }
            //PhantomGanon.MouseDown += (sender, e) => ChangeGoalInt(PhantomGanon);
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
        public void AddContextMenu(Control c, int LocationX, int LocationY)
        {
            Location = new Point(LocationX, LocationY);
            Visible = true;
        }
        public void CloseContextMenu()
        {
            Visible = false;
        }
        public void ChangeGoalInt(ContextMenuGoalButton button)
        {    
            switch(button.ID)
            {
                case -3:
                    Goal = -3;
                    break;
                case -2:
                    Goal = -2;
                    break;
                case -1:
                    Goal = -1;
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
            }        
            Visible = false;
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
