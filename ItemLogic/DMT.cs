using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_DMT(ItemPanel i)
        {
            //DMT Chest
            if (can_blast_or_smash)
            {
                DMTChest.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                DMTChest.color = OoLwithBombchus;
            }
            else
            {
                DMTChest.color = CanSee;
            }
            //Storms Grotto
            if (Has(i.SongOfStorms))
            {
                DMTStormsGrotto.color = Available;
            }
            else
            {
                DMTStormsGrotto.color = NotAvailable;
            }
            //Great Fairy
            if (can_blast_or_smash && Has(i.ZeldasLullaby))
            {
                DMTGreatFairy.color = Available;
            }
            else if (Has(i.Bombchu) && Has(i.ZeldasLullaby))
            {
                DMTGreatFairy.color = OoLwithBombchus;
            }
            else
            {
                DMTGreatFairy.color = NotAvailable;
            }
            //Big Goron
            if (i.AdultTradeItems.State >= 3 && can_blast_or_smash)
            {
                DMTBiggoron.color = Available;
            }
            else if (i.AdultTradeItems.State >= 3 && Has(i.Bombchu))
            {
                DMTBiggoron.color = OoLwithBombchus;
            }
            else
            {
                DMTBiggoron.color = NotAvailable;
            }
            //Skulls
            if (has_explosives && has_bottle)
            {
                tokensAvailable += 1;
            }
            if (Has(i.Bomb))
            {
                tokensAvailable += 1;
            }
            if (Has(i.Hammer))
            {
                tokensAvailable += 2;
            }
        }
    }
}
