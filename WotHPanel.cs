using OoTItemTrackerNew.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class WOTHPanel : Panel
    {
        //public List<int> Goals = [];
        public List<GoalPathHint> Goals = [];
        public WOTHPanel(Point _location)
        {
            Size = new Size(260, 180);
            Location = _location;
            BackColor = Color.Black;
            Label label = new()
            {
                Size = new Size(130, 20),
                Location = new Point(0, 0),
                Text = "Path Hints",
                ForeColor = Color.White
            };
            Controls.Add(label);
            for (int i = 0; i < 5; i++)
            {
                GoalPathHint goal = new(new Point(0, (i * 30) + 20), new Point(26, (i * 30) + 20));               
                Goals.Add(goal);              
                for (int j = 0; j < 4; j++)
                {
                    Gossipstone gossipstone = new(new Point(156 + j * 24, (i * 30) + 20));
                    Controls.Add(gossipstone);
                }
                Controls.Add(goal.goalpicture);
                Controls.Add(goal.goaltext);                          
            }
        }          
    }
}
