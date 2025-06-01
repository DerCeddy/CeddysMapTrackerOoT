using OoTItemTrackerNew.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class ContextMenuGoalButton : PictureBox
    {
        public int ID;
        public ContextMenuGoalButton(Bitmap _Image, Point _Location, int iD)
        {
            Image = _Image;
            Size = new Size(28, 28);
            Location = _Location;
            ID = iD;
        }
        public void ChangeGoalInt(int Goal)
        {
            Goal = 2;
            Visible = false;         
        }
    }
}
