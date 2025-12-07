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
            if(Deku_Tree_Access && (Has(i.HylianShield) || Has(i.DekuShield)))
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
            if (Deku_Tree_Access && ((Has(i.Slingshot) && Has(i.DekuShield)) || (Has(i.HylianShield) && has_firesource)))
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
