using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing.Configuration;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class GoMode : UserControl
    {
        public Image Image_Active= Resources.GoMode;
        public Image Image_Inactive= Resources.GoMode_bw;
        public PictureBox GoModeText = new() { Image = Resources.GoMode_bw};
        public PictureBox SunRays = new() { Image = Resources.sunrays };
        public bool Active;
        public System.Windows.Forms.Timer RotationTimer = new();
        public GoMode()
        {           
            RotationTimer.Interval = 100;    //you can change it to handle smoothness
            RotationTimer.Tick += RotationTimer_Tick;          
            Size = new Size(260,260);
            BackColor = Color.Transparent;
            GoModeText.Size = new Size(42, 28);
            GoModeText.SizeMode = PictureBoxSizeMode.StretchImage;
            GoModeText.Parent = SunRays;
            GoModeText.BackColor = Color.Transparent;           
            SunRays.Size = new Size(80,80);
            SunRays.SizeMode = PictureBoxSizeMode.StretchImage;
            GoModeText.Location = new Point(SunRays.Width / 2 - 21,SunRays.Height / 2 - 14);                      
            Controls.Add(GoModeText);
            GoModeText.MouseDown += (sender, e) => ChangeStatus();
        }
        public void ChangeStatus()
        {
            Active = !Active;
            if(Active)
            {
                GoModeText.Image = Image_Active;
                RotationTimer.Start();
                Controls.Add(SunRays);
                Controls.Remove(GoModeText);
                SunRays.Controls.Add(GoModeText);
            }
            else
            {
                GoModeText.Image = Image_Inactive;
                RotationTimer.Stop();
                Controls.Remove(SunRays);
                Controls.Add(GoModeText);
            }
        }
        void RotationTimer_Tick(object sender, EventArgs e)
        {
            Image flipImage = SunRays.Image;
            flipImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            SunRays.Image = flipImage;
        }
    }
}
