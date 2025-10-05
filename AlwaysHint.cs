using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class AlwaysHint : UserControl
    {
        public bool Active;
        public PictureBox PictureBox = new();
        public Gossipstone Gossipstone = new ();
        public ComboBox TrialHint1 = new();
        public ComboBox TrialHint2 = new();
        public AlwaysHint(string Type)
        {      
            BackColor = Color.Black;
            PictureBox.Size = new Size(32, 32);
            PictureBox.Location = new Point(0, 0);
            PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;      
            Controls.Add(PictureBox);
            Gossipstone.Location = new Point(32, 0);
            TrialHint1.Location = new Point(50, 0);
            TrialHint2.Location = new Point(120,0);
            if (Type == "Gossipstone")
            {
                Controls.Add(Gossipstone);
                Size = new Size(56, 32);
            }
            else if(Type == "Trial")
            {
                Controls.Add(TrialHint1);
                Controls.Add(TrialHint2);
                Size = new Size(96, 32);
            }
        }       
    }
}
