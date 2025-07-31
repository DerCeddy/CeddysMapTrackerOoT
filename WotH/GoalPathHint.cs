using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class GoalPathHint
    {
        public GoalPicture goalpicture;
        public GoalTextBox goaltext;
        public GoalPathHint(Point _locationpicture, Point _locationtext)
        {
            goalpicture = new(_locationpicture);
            goaltext = new(_locationtext);
        }
    }
}
