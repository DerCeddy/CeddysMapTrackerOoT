using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_DMC(ItemPanel i)
        {
            //DMC Freestanding PoH
            if (has_explosives || Has(i.Strength) || Has(i.Bow) || (Has(i.Bolero) && (Has(i.Hookshot) || Has(i.HoverBoots))))
            {
                DMCWallPoH.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                DMCWallPoH.color = OoLwithBombchus;
            }
            else
            {
                DMCWallPoH.color = NotAvailable;
            }
            //DMC Upper Grotto
            if (Has(i.Bomb) || (Has(i.Hammer) && (Has(i.Strength) || Has(i.Bow) || (Has(i.Bolero) && (Has(i.Hookshot) || Has(i.HoverBoots))))))
            {
                DMCUpperGrotto.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                DMCUpperGrotto.color = OoLwithBombchus;
            }
            else
            {
                DMCUpperGrotto.color = NotAvailable;
            }
            //DMC Volcano PoH
            if (Has(i.HoverBoots) && (has_explosives || Has(i.Strength) || Has(i.Bow) || Has(i.Bolero)) || (Has(i.Beans) && Has(i.Bolero)))
            {
                DMCVolcanoPoH.color = Available;
            }
            else if (Has(i.Bombchu) && Has(i.HoverBoots))
            {
                DMCVolcanoPoH.color = OoLwithBombchus;
            }
            else
            {
                DMCVolcanoPoH.color = NotAvailable;
            }
            //DMC Greaty Fairy
            if (Has(i.Hammer) && Has(i.ZeldasLullaby) && (i.Bomb.State == 1 || Has(i.Strength) || Has(i.Bow) || (Has(i.Bolero) && (Has(i.Hookshot) || Has(i.HoverBoots)))))
            {
                DMCGreatFairy.color = Available;
            }
            else
            {
                DMCGreatFairy.color = NotAvailable;
            }
            //Shiek at Crater
            if (craterplatformaccess == 1)
            {
                DMCShiek.color = Available;
            }
            else if(Has(i.Bombchu) && (Has(i.Hookshot) || Has(i.HoverBoots)))
            {
                DMCShiek.color = OoLwithBombchus;
            }
            else
            {
                DMCShiek.color = NotAvailable;
            }
            //Skulltula
            if (Has(i.Bomb))
            {
                tokensAvailable++;
            }
            if (Has(i.Bolero) && has_bottle)
            {
                tokensAvailable++;
            }
        }
    }
}
