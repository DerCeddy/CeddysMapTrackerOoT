using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class GoalPicture : PictureBox
    {
        public int State;
        public GoalPicture(Point _location)
        {
            Location = _location;
            Image = Resources.unknown_32x32;           
            Size = new Size(24, 24);
            SizeMode = PictureBoxSizeMode.StretchImage;
            MouseDown += (sender, e) => GoalClick(e);
            MouseWheel += (sender, e) => GoalScroll(e);
        }
        public void GoalClick(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ValueUp();

            }
            if (e.Button == MouseButtons.Right)
            {
                ValueDown();

            }
            CheckGoalState();
        }
        public void GoalScroll(MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                ValueUp();

            }
            if (e.Delta > 0)
            {
                ValueDown();

            }
            CheckGoalState();
        }
        public void CheckGoalState()
        {
            switch (State)
            {
                case -3:
                    Image = Resources.barinade_32x32;
                    break;
                case -2:
                    Image = Resources.dodongo_32x32;
                    break;
                case -1:
                    Image = Resources.gohma_32x32;
                    break;
                case 0:
                    Image = Resources.unknown_32x32;
                    break;
                case 1:
                    Image = Resources.pg_32x32;
                    break;
                case 2:
                    Image = Resources.volvagia_32x32;
                    break;
                case 3:
                    Image = Resources.morpha_32x32;
                    break;
                case 4:
                    Image = Resources.bongo_32x32;
                    break;
                case 5:
                    Image = Resources.twinrova_32x32;
                    break;
            }
        }
        public int ValueDown()
        {
            State--;
            if (State < -3)
            { State = -3; }
            return State;
        }
        public int ValueUp()
        {
            State++;
            if (State > 5)
            { State = 5; }
            return State;
        }
    }
}
