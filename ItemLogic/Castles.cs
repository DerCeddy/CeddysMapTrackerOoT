using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_Castles(ItemPanel i)
        {           
            //HC
            if (has_explosives && Has(i.ZeldasLullaby))
            {
                HCGreatFairy.color = Available;
            }
            else if(Has(i.ZeldasLullaby) && Has(i.Bombchu))
            {
                HCGreatFairy.color = OoLwithBombchus;
            }
            else
            {
                HCGreatFairy.color = NotAvailable;
            }
            //OGC
            if (i.Strength.State == 3)
            {
                OGCGreatFairy.color = Available;
            }
            else
            {
                OGCGreatFairy.color = NotAvailable;
            }
            //SKulltula
            if (Has(i.SongOfStorms) && Has(i.Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
