using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class Region_Panel : Panel
    {
        public Region_Panel(List<Region_Panel_Check> _checks, string _name)
        {
            Size = new Size(300, 550);        
            Location = new Point(240, 40);
            BackColor = Color.Black;
            AutoScroll = true;
            Label label = new()
            {
                Text = _name,
                Size = new Size(160, 20),
                Location = new Point(70, 0),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                //Font = new Font("Arial", 24, FontStyle.Bold)
            };
            Controls.Add(label);
            for (int i = 0; i < _checks.Count; i++)
            {
                _checks[i].Location = new Point(40, 24 * i + 20);
                Controls.Add(_checks[i]);
            }
        }
    }
}
