using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class DungeonInfoPanel : UserControl
    {
        public DungeonInfoElement ForestTemple = new(Resources.pg_32x32, 5);
        public DungeonInfoPanel()
        {
            Size = new Size(200,200);           
            BackColor = Color.White;
            ForestTemple.Location = new Point(0, 0);
            Controls.Add(ForestTemple);
        }
    }
}
