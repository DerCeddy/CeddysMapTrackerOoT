using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_GerudoValley(ItemPanel i)
        {
            if (Has(i.Hammer) && (Has(i.EponasSong) || has_longshot))
            {
                GVChest.color = Available;
            }
            else
            {
                GVChest.color = NotAvailable;
            }
            //Skulltula
            if (Has(i.Hookshot) && (Has(i.EponasSong) || has_longshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
