using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_DekuTree(ItemPanel i)
        {           
            //Deku Tree Entry
            if (Has(i.KokiriSword))
            {
                DekuTreeMapChest.ForeColor = Available;
                DekuTreeCompassChest.ForeColor = Available;
                DekuTreeCompassRoomSideChest.ForeColor = Available;
                DekuTreeSlingshotChest.ForeColor = Available;
                DekuTreeSlingshotRoomSideChest.ForeColor = Available;
                DekuTreeBasementChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                DekuTreeMapChest.ForeColor = NotAvailable;
                DekuTreeCompassChest.ForeColor = NotAvailable;
                DekuTreeCompassRoomSideChest.ForeColor = NotAvailable;
                DekuTreeSlingshotChest.ForeColor = NotAvailable;
                DekuTreeSlingshotRoomSideChest.ForeColor = NotAvailable;
                DekuTreeBasementChest.ForeColor = NotAvailable;
            }
            //Deku Tree Gohma
            if (Has(i.KokiriSword) && Has(i.Slingshot))
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
