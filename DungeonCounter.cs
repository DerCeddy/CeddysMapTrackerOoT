using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class DungeonCounter : Panel
    {
        public DungeonCounter(Maptracker maptracker) 
        {
            Location = new Point(maptracker.Location.X,maptracker.Size.Height + 1);
            BackColor = Color.Gray;
        }
    }
}
