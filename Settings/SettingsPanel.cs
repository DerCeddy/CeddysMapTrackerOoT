using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SettingsPanel : Panel
    {
        public SettingsPanel(Point _location)
        {
            Size = new Size(500, 700);
            Location = _location;
            BackColor = Color.Yellow;
        }
    }
}
