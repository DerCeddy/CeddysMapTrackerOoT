using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SkulltulaTracker : PictureBox
    {
        private int SkulltulaCount = 0;
        public SkulltulaTracker(Point location)
        {
            Location = location;
            Size = new Size(42,59);
            Image = Resources.OoT3D_Token_Icon_forLabel;
            BackColor = Color.Transparent;
            Label SkulltulaLabel = new() { TextAlign = ContentAlignment.TopCenter, Location = new Point(0, -2), Text = SkulltulaCount.ToString(), ForeColor = Color.White, BackColor = Color.Transparent, Size = new Size(42, 24), Font = new Font("Segoe Fluent Icons", 22, FontStyle.Bold, GraphicsUnit.Pixel) };      
            Controls.Add(SkulltulaLabel);
            MouseDown += (sender,e) => ChangeSkulltulaValue(e, SkulltulaLabel);
            MouseWheel += (sender, e) => ChangeSkulltulaValue(e, SkulltulaLabel);
        }
        public void ChangeSkulltulaValue(MouseEventArgs e, Label SkulltulaLabel)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    SkulltulaCount++;
                    if(SkulltulaCount > 100)
                    {
                        SkulltulaCount = 100;
                    }
                    UpdateSkulltulaCounter(SkulltulaLabel);
                    break;
                case MouseButtons.Right:
                    SkulltulaCount--;
                    if(SkulltulaCount < 0)
                    {
                        SkulltulaCount = 0;
                    }
                    UpdateSkulltulaCounter(SkulltulaLabel);
                    break;
            }
            switch (e.Delta)
            {
                case < 0:
                    SkulltulaCount++;
                    if (SkulltulaCount > 100)
                    {
                        SkulltulaCount = 100;
                    }
                    UpdateSkulltulaCounter(SkulltulaLabel);
                    break;
                case > 0:
                    SkulltulaCount--;
                    if (SkulltulaCount < 0)
                    {
                        SkulltulaCount = 0;
                    }
                    UpdateSkulltulaCounter(SkulltulaLabel);
                    break;
            }
        }
        public void UpdateSkulltulaCounter(Label SkulltulaLabel)
        {
            SkulltulaLabel.Text = SkulltulaCount.ToString();
        }
    }
}
