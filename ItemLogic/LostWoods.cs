using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_LostWoods(ItemPanel i)
        {
            //Skull Kid
            if (Has(i.SariasSong))
            {
                LWSkullKid.color = Available;
            }
            else
            {
                LWSkullKid.color = NotAvailable;
            }
            //Target in the Woods
            if (Has(i.Slingshot))
            {
                LWTarget.color = Available;
            }
            else
            {
                LWTarget.color = NotAvailable;
            }
            //Near Goron City Shortcut
            if (Has(i.Bomb) || Has(i.Hammer))
            {
                LWNearShortcutGrottoChest.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                LWNearShortcutGrottoChest.color = OoLwithBombchus;
            }
            else
            {
                LWNearShortcutGrottoChest.color = NotAvailable;
            }
            //Scrubs Near SFM Exit
            if (((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hammer)) || i.Bomb.State == 1)
            {
                LWScrubGrottoFront.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                LWScrubGrottoFront.color = OoLwithBombchus;
            }
            else
            {
                LWScrubGrottoFront.color = NotAvailable;
            }
            //Skulltula
            if (Has(i.Beans) || can_get_beans)
            {
                tokensAvailable++;
            }
        }
    }
}
