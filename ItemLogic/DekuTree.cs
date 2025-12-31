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
        public bool Deku_Tree_Access;
        public void ItemLogic_DekuTree(ItemPanel i)
        {
            bool is_adult;
            bool is_child;
            if(Jabu_Button.RegionPanel == Deku_RegionPanel)
            {
                is_adult = false;
            }
            else
            {
                is_adult = true;
            }
            if (Deku_Button.RegionPanel == Deku_RegionPanel || DC_Button.RegionPanel == Deku_RegionPanel || Jabu_Button.RegionPanel == Deku_RegionPanel || BotW_Button.RegionPanel == Deku_RegionPanel || (Fire_Button.RegionPanel == Deku_RegionPanel && Has(i.Bolero)) || Shadow_Button.RegionPanel == Deku_RegionPanel || (Spirit_Button.RegionPanel == Deku_RegionPanel && Has(i.Reqiuem)))
            {
                is_child = true;
            }
            else
            {
                is_child = false;
            }
            //Deku Tree Entry
            if (Deku_Tree_Access)
            {
                DekuTreeMapChest.ForeColor = Available;
                DekuTreeCompassChest.ForeColor = Available;
                DekuTreeCompassRoomSideChest.ForeColor = Available;
                DekuTreeBasementChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                DekuTreeMapChest.ForeColor = NotAvailable;
                DekuTreeCompassChest.ForeColor = NotAvailable;
                DekuTreeCompassRoomSideChest.ForeColor = NotAvailable;
                DekuTreeBasementChest.ForeColor = NotAvailable;
            }
            //Deku Slingshot room
            if(Deku_Tree_Access && ((Has(i.HylianShield) && is_adult && DungeonER) || (Has(i.DekuShield) && is_child)))
            {
                DekuTreeSlingshotChest.ForeColor = Available;
                DekuTreeSlingshotRoomSideChest.ForeColor = Available;

            }
            else
            {
                DekuTreeSlingshotChest.ForeColor = NotAvailable;
                DekuTreeSlingshotRoomSideChest.ForeColor = NotAvailable;

            }
            //Deku Tree Gohma
            if (Deku_Tree_Access && ((Has(i.Slingshot) && Has(i.DekuShield) && is_child) || (Has(i.HylianShield) && is_adult && DungeonER && (Has(i.Bow) || (Has(i.Magic) && Has(i.Dins))))))
            {
                DekuTreeQueenGohmaHeart.ForeColor = Available;
            }
            else
            {
                DekuTreeQueenGohmaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if ((Has(i.Slingshot) || Has(i.Boomerang)) || (Has(i.Magic) && Has(i.Dins)))
            {
                tokensAvailable++;
            }
            if (Has(i.Bomb) && Has(i.Boomerang) && Has(i.KokiriSword))
            {
                tokensAvailable++;
            }
        }
    }  
}
