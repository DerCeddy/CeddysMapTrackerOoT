using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_Jabu(ItemPanel i)
        {
            //Boomerang Chest
            if (Has(i.RutoLetter) && (Has(i.Scales) || (i.Bomb.State == 1 && Has(i.ZeldasLullaby))))
            {
                JabuJabusBellyBoomerangChest.ForeColor = Available;
                tokensAvailable += 1;
            }
            else if (Has(i.RutoLetter) && Has(i.Bombchu) && Has(i.ZeldasLullaby))
            {
                JabuJabusBellyBoomerangChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                JabuJabusBellyBoomerangChest.ForeColor = NotAvailable;
            }
            //Rest
            if (Has(i.RutoLetter) && ((Has(i.ZeldasLullaby) && i.Bomb.State == 1) || Has(i.Scales)) && Has(i.Boomerang))
            {
                JabuJabusBellyBarinadeHeart.ForeColor = Available;
                JabuJabusBellyCompassChest.ForeColor = Available;
                JabuJabusBellyMapChest.ForeColor = Available;
                tokensAvailable += 3;
            }
            else if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && Has(i.Bombchu) && Has(i.Boomerang))
            {
                JabuJabusBellyBarinadeHeart.ForeColor = OoLwithBombchus;
                JabuJabusBellyCompassChest.ForeColor = OoLwithBombchus;
                JabuJabusBellyMapChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                JabuJabusBellyBarinadeHeart.ForeColor = NotAvailable;
                JabuJabusBellyCompassChest.ForeColor = NotAvailable;
                JabuJabusBellyMapChest.ForeColor = NotAvailable;
            }
        }
    }
}
