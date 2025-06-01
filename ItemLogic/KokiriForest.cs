using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_KokiriForest(ItemPanel i)
        {
            //Storms Grotto
            if (Has(i.SongOfStorms))
            {
                KFStormGrottoChest.color = Available;
            }
            else
            {
                KFStormGrottoChest.color = NotAvailable;
            }
            if (Has(i.Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
