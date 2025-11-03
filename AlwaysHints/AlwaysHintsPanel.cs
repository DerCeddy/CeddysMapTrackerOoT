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
        public AlwaysHint SongOfTime = new("Gossipstone") { AlwaysHintIndex = 1 };
        public AlwaysHint Nocturne = new("Gossipstone") { AlwaysHintIndex = 2 };
        public AlwaysHint BigGoron = new("Gossipstone") { AlwaysHintIndex = 3 };
        public AlwaysHint Frogs2 = new("Gossipstone") { AlwaysHintIndex = 4};
        public AlwaysHint SkullMask = new("Gossipstone") { AlwaysHintIndex = 5};
        public AlwaysHint Skulls20 = new("Gossipstone") { AlwaysHintIndex = 11 };
        public AlwaysHint Skulls30 = new("Gossipstone") { AlwaysHintIndex = 12 };
        public AlwaysHint Skulls40 = new("Gossipstone") { AlwaysHintIndex = 13 };
        public AlwaysHint Skulls50 = new("Gossipstone") { AlwaysHintIndex = 14 };
        public AlwaysHint Trials = new("Dual");
        public AlwaysHint IceDual = new("Dual") { AlwaysHintIndex = 6, AlwaysHintIndex2 = 7};
        public AlwaysHint CastleFairies = new("Dual") { AlwaysHintIndex = 8, AlwaysHintIndex2 = 9 };
        public AlwaysHint FrogsDual = new("Dual") { AlwaysHintIndex = 10, AlwaysHintIndex2 = 4 };
        public List<AlwaysHint> AlwaysHintsList = [];
        private List<AlwaysHint> ActiveHints = [];
        public AlwaysHintsPanel(Point _location)
        {
            AlwaysHintsList = [SongOfTime, Nocturne, BigGoron, Frogs2, SkullMask, Skulls20, Skulls30, Skulls40, Skulls50, Trials, IceDual, CastleFairies, FrogsDual];
            SongOfTime.PictureBox.Image = Resources.OoT3D_Ocarina_of_Time_Icon;
            Nocturne.PictureBox.Image = Resources.nocturne_32x40;
            BigGoron.PictureBox.Image = Resources.biggoron_32x32;
            Frogs2.PictureBox.Image = Resources.Frogs2;
            SkullMask.PictureBox.Image = Resources.OoT3D_Skull_Mask_Icon;
            Skulls20.PictureBox.Image = Resources.Skulltulas20;
            Skulls30.PictureBox.Image = Resources.Skulltulas30;
            Skulls40.PictureBox.Image = Resources.Skulltulas40;
            Skulls50.PictureBox.Image = Resources.Skulltulas50;
            Trials.PictureBox.Image = Resources.trials;
            FrogsDual.PictureBox.Image = Resources.Frogs_Dual;
            IceDual.PictureBox.Image = Resources.IceCavern;
            CastleFairies.PictureBox.Image = Resources.Castle_Fairy_Dual;        
            Size = new Size(180, 0);
            AutoSize = true;
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Always Hints", Location = new Point(0, 0), ForeColor = Color.White };
            Controls.Add(label);
            bitmaps = [];
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);           
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
                else if (8 > i)
                {
                    Controls.Add(ActiveHints[i]);
                    ActiveHints[i].Location = new Point(ActiveHints[i - 4].Location.X + 66, (i - 4) * 32 + 28);
                }
                else if (12 > i)
                {
                    Controls.Add(ActiveHints[i]);
                    ActiveHints[i].Location = new Point(ActiveHints[i - 4].Location.X + 66, (i - 8) * 32 + 28);
                }
                else
                {
                    Controls.Add(ActiveHints[i]);
                    ActiveHints[i].Location = new Point(ActiveHints[i - 4].Location.X + 66, (i - 12) * 32 + 28);
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
