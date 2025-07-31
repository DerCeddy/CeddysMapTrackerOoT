using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class MedallionLabel : Label
    {
        public int _state;
        public MedallionLabel()
        {
            MouseWheel += (sender, e) => Scroll(e);
            ForeColor = Color.White;
            AutoSize = false;
            BackColor = Color.Transparent;
            Size = new Size(54,18);           
            Font = new Font("Segoe Fluent Icons", 12, FontStyle.Bold, GraphicsUnit.Pixel);
            TextAlign = ContentAlignment.TopCenter;
            Text = "FREE";
        }
        private static void CheckLabelState(int x, MedallionLabel dungeon)
        {
            switch (x)
            {
                case -3:
                    dungeon.Text = "JABU";
                    break;
                case -2:
                    dungeon.Text = "DC";
                    break;
                case -1:
                    dungeon.Text = "DEKU";
                    break;
                case 0:
                    dungeon.Text = "FREE";
                    break;
                case 1:
                    dungeon.Text = "FOREST";
                    break;
                case 2:
                    dungeon.Text = "FIRE";
                    break;
                case 3:
                    dungeon.Text = "WATER";
                    break;
                case 4:
                    dungeon.Text = "SHADOW";
                    break;
                case 5:
                    dungeon.Text = "SPIRIT";
                    break;
            }
        }
        public void Scroll(MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                _state = LabelUP(_state);
            }
            else if (e.Delta > 0)
            {
                _state = LabelDOWN(_state);
            }
            CheckLabelState(_state, this);
        }
        public int LabelUP(int x)
        {
            x++;
            if (x > 5)
            { x = 5; }
            return x;
        }
        public static int LabelDOWN(int x)
        {
            x--;
            if (x < -3)
            { x = -3; }
            return x;
        }
    }
}
