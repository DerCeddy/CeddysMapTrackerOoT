using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_ZoraFountain(ItemPanel i)
        {
            //Zora Fountain Fairy
            if (Has(i.RutoLetter) && i.Bomb.State == 1 && Has(i.ZeldasLullaby))
            {
                ZFGreatFairy.color = Available;
            }
            else if (Has(i.RutoLetter) && Has(i.Bombchu) && Has(i.ZeldasLullaby))
            {
                ZFGreatFairy.color = OoLwithBombchus;
            }
            else
            {
                ZFGreatFairy.color = NotAvailable;
            }
            //Zora Fountain Freestanding PoH
            if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && (i.Bomb.State == 1 || Has(i.Scales)))
            {
                ZFFreestandingPoH.color = Available;
                tokensAvailable += 1;
            }
            else if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && Has(i.Bombchu))
            {
                ZFFreestandingPoH.color = OoLwithBombchus;             
            }
            else
            {
                ZFFreestandingPoH.color = NotAvailable;
            }
            //Bottom PoH
            if (Has(i.RutoLetter) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (i.Bomb.State == 1 || Has(i.Scales)))
            {
                ZFBottomPoH.color = Available;
            }
            else if (Has(i.RutoLetter) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bombchu))
            {
                ZFBottomPoH.color = OoLwithBombchus;
            }
            else
            {
                ZFBottomPoH.color = NotAvailable;
            }
            //Skulls
            if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && i.Strength.State >= 2)
            {
                tokensAvailable += 1;
            }
            if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && (i.Bomb.State == 1 || Has(i.Scales)) && Has(i.Boomerang))
            {
                tokensAvailable += 1;
            }
        }
    }
}
