using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class GoalTextBox : TextBox
    {
        public GoalTextBox(Point _location)
        {
            Size = new Size(129, 23);
            BackColor = Color.DeepSkyBlue;
            Location = _location;
            //Location = new Point(26, (i * 30) + 20);
            MouseDown += (sender, e) => DeleteString();
        }
        public void DeleteString()
        {
            Text = string.Empty;
        }
    }
}
