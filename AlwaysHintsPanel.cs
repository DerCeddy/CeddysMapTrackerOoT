using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class AlwaysHintsPanel : Panel
    {
        public List<Bitmap> bitmaps;
        private List<PictureBox> pictureBoxes = [];
        private List<Gossipstone> gossipstones = [];
        public AlwaysHint SongOfTime = new("Gossipstone");
        public AlwaysHint Nocturne = new("Gossipstone");
        public AlwaysHint BigGoron = new("Gossipstone");
        public AlwaysHint Frogs2 = new("Gossipstone");
        public AlwaysHint SkullMask = new("Gossipstone");
        public AlwaysHint Skulls20 = new("Gossipstone");
        public AlwaysHint Skulls30 = new("Gossipstone");
        public AlwaysHint Skulls40 = new("Gossipstone");
        public AlwaysHint Skulls50 = new("Gossipstone");
        public AlwaysHint Trials = new("Trial");
        public List<AlwaysHint> AlwaysHintsList = [];
        private List<AlwaysHint> ActiveHints = [];
        public AlwaysHintsPanel(Point _location)
        {
            AlwaysHintsList = [SongOfTime, Nocturne, BigGoron, Frogs2, SkullMask, Skulls20, Skulls30, Skulls40, Skulls50, Trials];
            SongOfTime.PictureBox.Image = Resources.OoT3D_Ocarina_of_Time_Icon;
            Nocturne.PictureBox.Image = Resources.nocturne_32x40;
            BigGoron.PictureBox.Image = Resources.biggoron_32x32;
            Frogs2.PictureBox.Image = Resources.frogs_32x32;
            SkullMask.PictureBox.Image = Resources.OoT3D_Skull_Mask_Icon;
            Skulls20.PictureBox.Image = Resources.Soldout;
            Skulls30.PictureBox.Image = Resources._30_gold_skulltula_32x32;
            Skulls40.PictureBox.Image = Resources._40_gold_skulltula_32x32;
            Skulls50.PictureBox.Image = Resources._50_gold_skulltula_32x32;
            Trials.PictureBox.Image = Resources.trials;
            Size = new Size(180, 155);
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Always Hints", Location = new Point(0, 0), ForeColor = Color.White };
            Controls.Add(label);
            bitmaps = [];
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            SongOfTime.Active = true;
            Nocturne.Active = true;
            Skulls40.Active = true;
        }
        public void DrawPanel()
        {          
            foreach (AlwaysHint Hint in AlwaysHintsList)
            {
                if(Hint.Active)
                {
                    ActiveHints.Add(Hint);
                }
            }
            for (int i = 0; i < ActiveHints.Count; i++)
            {
                if (4 > i)
                {
                    Controls.Add(ActiveHints[i]);
                    ActiveHints[i].Location = new Point(0, i * 32 + 28);
                }
                else
                {
                    Controls.Add(ActiveHints[i]);
                    ActiveHints[i].Location = new Point(130, (i - 4) * 32 + 28);                 
                }

            }
        }
        public void DeleteItems()
        {
            foreach (AlwaysHint Hint in ActiveHints)
            {
                Controls.Remove(Hint);
            }
            ActiveHints.Clear();
        }
    }
}
