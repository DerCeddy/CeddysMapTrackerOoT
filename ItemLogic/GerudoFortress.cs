using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_GerudoFortress(ItemPanel i)
        {
            /*
            if (Has(EponasSong) || has_longshot)
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                Pb("Gerudo Fortress", "Carpenter", maptracker_Panel).ForeColor = red;
            }  
            */
            if (has_or_can_get_gerudocard && Has(i.EponasSong) && Has(i.Bow))
            {
                HBA.color = Available;              
            }
            else
            {
                HBA.color = NotAvailable;
            }
            if ((Has(i.Hookshot) || Has(i.HoverBoots)) && has_or_can_get_gerudocard)
            {
                GFChest.color = Available;
            }
            else
            {
                GFChest.color = NotAvailable;
            }
            //Skulltula
            if ((Has(i.EponasSong) || has_longshot) && Has(i.Hookshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
