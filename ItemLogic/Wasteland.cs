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
        public void ItemLogic_Wasteland(ItemPanel i)
        {
            if (has_or_can_get_gerudocard && Has(i.Magic) && (has_longshot || Has(i.HoverBoots)) && ((Has(i.Bow) && Has(i.FireArrow)) || Has(i.Dins)))
            {
                WastelandChest.color = Available;
            }
            else
            {
                WastelandChest.color = NotAvailable;
            }
            //Skulltula
            if (has_or_can_get_gerudocard && Has(i.Hookshot) && (has_longshot || Has(i.HoverBoots)))
            {
                tokensAvailable++;
            }
        }
    }
}
