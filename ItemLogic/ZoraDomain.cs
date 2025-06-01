using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_ZoraDomain(ItemPanel i)
        {
            //Zora Domain Child Checks
            if (Has(i.Scales) || (i.Bomb.State == 1 && Has(i.ZeldasLullaby)))
            {
                ZDChest.color = Available;
                ZRDivingGame.color = Available;
            }
            else if (Has(i.Bombchu) && Has(i.ZeldasLullaby))
            {
                ZDChest.color = OoLwithBombchus;
                ZRDivingGame.color = OoLwithBombchus;
            }
            else
            {
                ZDChest.color = NotAvailable;
                ZRDivingGame.color = NotAvailable;
            }
            //King Zora Thawed
            if (Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle)))
            {
                ZDKingZora.color = Available;
            }
            else if (Has(i.ZeldasLullaby) && Has(i.RutoLetter) && Has(i.Bombchu))
            {
                ZDKingZora.color = OoLwithBombchus;
            }
            else
            {
                ZDKingZora.color = NotAvailable;
            }
            //Skulltula
            if (Has(i.Hookshot) && Has(i.ZeldasLullaby))
            {
                tokensAvailable++;
            }
        }
    }
}
