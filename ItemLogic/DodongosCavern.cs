using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{  
    partial class Maptracker
    {
        public bool DC_Access;
        public void ItemLogic_DodongosCavern(ItemPanel i)
        {
            //Map and Compass Chests
            if (DC_Access && (i.Bomb.State == 1 || Has(i.Strength) || Has(i.Hammer)))
            {
                DodongosCavernCompassChest.ForeColor = Available;
                DodongosCavernMapChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && Has(i.Bombchu))
            {
                DodongosCavernCompassChest.ForeColor = OoLwithBombchus;
                DodongosCavernMapChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernCompassChest.ForeColor = NotAvailable;
                DodongosCavernMapChest.ForeColor = NotAvailable;
            }
            //Beyond Staircase
            if (DC_Access && (i.Bomb.State == 1 || Has(i.Strength) || (Has(i.Dins) && Has(i.Magic) && Has(i.Hammer))))
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = Available;
                DodongosCavernBombBagChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && Has(i.Bombchu))
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = OoLwithBombchus;
                DodongosCavernBombBagChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = NotAvailable;
                DodongosCavernBombBagChest.ForeColor = NotAvailable;
            }
            //End of Bridge
            if (DC_Access && (i.Bomb.State == 1 || (Has(i.Strength) || (Has(i.Dins) && Has(i.Magic))) && Has(i.Hammer)))
            {
                DodongosCavernEndofBridgeChest.ForeColor = Available;
            }
            else if (Has(i.Bombchu))
            {
                DodongosCavernEndofBridgeChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernEndofBridgeChest.ForeColor = NotAvailable;
            }
            //You need Bomb Bag for Boss Room
            if (DC_Access && Has(i.Bomb))
            {
                DodongosCavernBossRoomChest.ForeColor = Available;
                DodongosCavernKingDodongoHeart.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && Has(i.Bombchu))
            {
                DodongosCavernBossRoomChest.ForeColor = OoLwithBombchus;
                DodongosCavernKingDodongoHeart.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernBossRoomChest.ForeColor = NotAvailable;
                DodongosCavernKingDodongoHeart.ForeColor = NotAvailable;
            }                
            //Skulltula
            if (DC_Access && (i.Bomb.State == 1 || Has(i.Strength)) && (Has(i.Hookshot) || Has(i.Boomerang)))
            {
                tokensAvailable++;
            }
            if (DC_Access && (Has(i.Bomb) || Has(i.Strength)) && Has(i.Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
