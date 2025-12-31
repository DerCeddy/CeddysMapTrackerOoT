using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Ice_Access;
        public void ItemLogic_IceCavern(ItemPanel i)
        {
            if (Ice_Access && (has_bottle || can_use_bluefirearrows))
            {
                IceCavernMapChest.ForeColor = Available;
                IceCavernCompassChest.ForeColor = Available;
                IceCavernFreestandingPoH.ForeColor = Available;
                IceCavernIronBootsChest.ForeColor = Available;
                IceCavernShiek.ForeColor = Available;
            }
            else if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && Has(i.Bombchu) && Ice_Button.RegionPanel == Ice_RegionPanel)
            {
                IceCavernMapChest.ForeColor = OoLwithBombchus;
                IceCavernCompassChest.ForeColor = OoLwithBombchus;
                IceCavernFreestandingPoH.ForeColor = OoLwithBombchus;
                IceCavernIronBootsChest.ForeColor = OoLwithBombchus;
                IceCavernShiek.ForeColor = OoLwithBombchus;
            }
            else
            {
                IceCavernMapChest.ForeColor = NotAvailable;
                IceCavernCompassChest.ForeColor = NotAvailable;
                IceCavernFreestandingPoH.ForeColor = NotAvailable;
                IceCavernIronBootsChest.ForeColor = NotAvailable;
                IceCavernShiek.ForeColor = NotAvailable;
            }
            if (Ice_Access && has_bottle && Has(i.Hookshot))
            {
                tokensAvailable += 3;
            }
        }
    }
}
