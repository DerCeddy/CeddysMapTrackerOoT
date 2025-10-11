using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public class SettingsAlwaysHint : UserControl
    {
        public PictureBox Picture = new();
        public CheckBox CheckBox = new();
        public SettingsAlwaysHint()
        {
            Picture.Size = new Size(32,32);
            Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture.Location = new Point(0,0);
            Picture.MouseDown += (sender, e) => ClickEvent(e);
            Controls.Add(Picture);
            CheckBox.Size = new Size(32,32);
            CheckBox.AutoSize = false;
            CheckBox.Location = new Point(32,0);
            CheckBox.AutoCheck = false;
            CheckBox.MouseDown += (sender, e) => ClickEvent(e);
            Controls.Add(CheckBox);
            Size = new Size(48,32);
        }
        public void ClickEvent(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!CheckBox.Checked)
                    {
                        CheckBox.Checked = true;
                    }
                    else
                    {
                        CheckBox.Checked = false;                     
                    }
                    break;
            }
        }
    }
}
