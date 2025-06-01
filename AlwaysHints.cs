using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class AlwaysHints : Panel
    {      
        public AlwaysHints(Point _location)
        {
            Size = new Size(180, 155);
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Always Hints", Location = new Point(0, 0), ForeColor = Color.White };
            Controls.Add(label);
            List<Bitmap> bitmaps = [Resources.OoT3D_Ocarina_of_Time_Icon, Resources.biggoron_32x32, Resources.frogs_32x32, Resources.OoT3D_Skull_Mask_Icon, Resources.nocturne_32x40, Resources._30_gold_skulltula_32x32, Resources._40_gold_skulltula_32x32, Resources._50_gold_skulltula_32x32];
            for(int i = 0; i < bitmaps.Count; i++)
            {
                if (4 > i)
                {
                    PictureBox pictureBox = new() { Image = bitmaps[i], Size = new Size(32, 32), Location = new Point(10, i * 32 + 24), SizeMode = PictureBoxSizeMode.StretchImage };
                    Controls.Add(pictureBox);
                    Gossipstone gossipstone = new(new Point(50, i * 32 + 28));
                    Controls.Add(gossipstone);
                }
                else
                {
                    PictureBox pictureBox = new() { Image = bitmaps[i], Size = new Size(32, 32), Location = new Point(90, (i-4) * 32 + 24), SizeMode = PictureBoxSizeMode.StretchImage };
                    Controls.Add(pictureBox);

                    Gossipstone gossipstone = new(new Point(130, (i-4) * 32 + 28));
                    Controls.Add(gossipstone);
                }
                
            }
        }
    }
}
