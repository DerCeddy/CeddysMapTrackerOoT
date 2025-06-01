using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class DungeonButton : Button
    {      
        private Color BossSquare = Color.Red;
        private Color CheckSquare = Color.Red;
        private Color BorderColor = Color.Black;
        private int BorderSize;
        public int Checks = 0;
        public Color _bosssquare
        {
            get { return BossSquare; }
            set
            {
                Invalidate();
                BossSquare = value;               
            }
        }
        public Color _checksquare
        {
            get { return CheckSquare; }
            set { CheckSquare = value; Invalidate(); }
        }
        public Color _bordercolor
        {
            get { return BorderColor; }
            set { BorderColor = value; }
        }
        public DungeonButton()
        {
            Size = new Size(30,30);
            Text = Checks.ToString();
            BackColor = Color.Transparent;
            Font = new("Arial", 11, GraphicsUnit.Pixel );
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new();
            //grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            RectangleF rect = new Rectangle(0, 0, this.Width, this.Height);
            grPath.AddRectangle(rect);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //g.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new(CheckSquare))
            {             
                g.FillRectangle(brush, 3, 3, 24, 24);              
            }
            using (SolidBrush brush = new(BossSquare))
            {
                g.FillRectangle(brush, 7, 7, 17, 17);
            }
            using (Pen selPen = new(BorderColor, 3))
            {               
                g.DrawRectangle(selPen, 2, 2, 26, 26);              
            }
            if (Checks < 10)
            {
                TextRenderer.DrawText(e.Graphics, Checks.ToString(), this.Font, new Point(10, 9), Color.Black);
                TextRenderer.DrawText(e.Graphics, Checks.ToString(), this.Font, new Point(9, 8), Color.White);
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, Checks.ToString(), new("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel), new Point(7, 9), Color.Black);
                TextRenderer.DrawText(e.Graphics, Checks.ToString(), this.Font, new Point(6, 8), Color.White);
            }          
            //g.DrawEllipse(selPen, 0, 0, 13, 13);
        }
        public void ButtonClick(MouseEventArgs e, Region_Panel region_panel)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    break;
                case MouseButtons.Middle:
                    int ChecksChecked = 0;
                    int MaxChecks = 0;
                    foreach (Control c in region_panel.Controls)
                    {
                        if (c is CheckBox cb)
                        {
                            MaxChecks++;
                            if (cb.Checked)
                            {
                                ChecksChecked++;
                            }
                        }
                    }
                    if (MaxChecks > ChecksChecked)
                    {
                        foreach (Control c in region_panel.Controls)
                        {
                            if (c is CheckBox cb)
                            {
                                cb.Checked = true;
                            }
                        }
                    }
                    else
                    {
                        foreach (Control c in region_panel.Controls)
                        {
                            if (c is CheckBox cb)
                            {
                                cb.Checked = false;
                            }
                        }
                    }
                    break;
            }
        }
    }
}
