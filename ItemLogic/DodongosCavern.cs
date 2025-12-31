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
            bool is_child = false;
            if (Jabu_Button.RegionPanel == DC_RegionPanel)
            {
                is_child = true;
            }
            else
            {
                is_child = false;
            }
            //Map and Compass Chests
            if (DC_Access && ((i.Bomb.State == 1 || Has(i.Strength) || Has(i.Hammer) && !is_child) || (is_child && (Has(i.Bomb) || Has(i.Strength)))))
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
            if (DC_Access && (((i.Bomb.State == 1 || Has(i.Strength) || (Has(i.Dins) && Has(i.Magic) && Has(i.Hammer))) && !is_child) || (is_child && (Has(i.Strength) || Has(i.Bomb)))))
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && Has(i.Bombchu))
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernBombFlowerPlatformChest.ForeColor = NotAvailable;
            }
            //Bomb Bag Chest
            if (DC_Access && (((i.Bomb.State == 1 || Has(i.Strength) || (Has(i.Dins) && Has(i.Magic) && Has(i.Hammer))) && !is_child) || (is_child && Has(i.Slingshot) && (Has(i.Strength) || Has(i.Bomb)))))
            {
                DodongosCavernBombBagChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && ((Has(i.Bombchu) && !is_child) || (is_child && Has(i.Bombchu) && Has(i.Slingshot))))
            {
                DodongosCavernBombBagChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernBombBagChest.ForeColor = NotAvailable;
            }
            //End of Bridge
            if (DC_Access && (((i.Bomb.State == 1 || (Has(i.Strength) || (Has(i.Dins) && Has(i.Magic))) && Has(i.Hammer)) && !is_child) || (is_child && Has(i.Slingshot) && Has(i.Bomb))))
            {
                DodongosCavernEndofBridgeChest.ForeColor = Available;
            }
            else if (DC_Access && ((Has(i.Bombchu) && !is_child) || (is_child && Has(i.Bombchu) && Has(i.Slingshot))))
            {
                DodongosCavernEndofBridgeChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernEndofBridgeChest.ForeColor = NotAvailable;
            }
            //You need Bomb Bag for Boss Room
            if (DC_Access && ((Has(i.Bomb) && !is_child) || (is_child && Has(i.Slingshot) && Has(i.Bomb))))
            {
                DodongosCavernBossRoomChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && ((Has(i.Bombchu) && !is_child) || (is_child && Has(i.Bombchu) && Has(i.Slingshot))))
            {
                DodongosCavernBossRoomChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                DodongosCavernBossRoomChest.ForeColor = NotAvailable;
            }
            //King Dodongo
            if (DC_Access && ((Has(i.Bomb) && !is_child) || (is_child && Has(i.Slingshot) && Has(i.Bomb))))
            {
                DodongosCavernKingDodongoHeart.ForeColor = Available;
                tokensAvailable++;
            }
            else if (DC_Access && ((Has(i.Bombchu) && !is_child) || (is_child && Has(i.Bombchu) && Has(i.Slingshot) && Has(i.Strength))))
            {
                DodongosCavernKingDodongoHeart.ForeColor = OoLwithBombchus;
            }
            else
            {
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
