using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_SFM(ItemPanel i)
        {
            //Wolfo Grotto
            if (Has(i.Bomb) || ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hammer)))
            {
                SFMWolfosGrotto.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                SFMWolfosGrotto.color = OoLwithBombchus;
            }
            else
            {
                SFMWolfosGrotto.color = NotAvailable;
            }
            //Shiek in Forest
            if (Has(i.SariasSong) || Has(i.Minuet))
            {
                SFMShiek.color = Available;
            }
            else
            {
                SFMShiek.color = NotAvailable;
            }
            //Skulltula
            if (Has(i.Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
