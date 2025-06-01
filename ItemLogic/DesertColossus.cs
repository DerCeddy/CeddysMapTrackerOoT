using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_DesertColossus(ItemPanel i)
        {         
            //Shiek at Colossus
            if (desertaccess == 1)
            {
                ColossusShiek.color = Available;
            }
            else
            {
                ColossusShiek.color = NotAvailable;
            }
            //Colossus Fairy
            if (desertaccess == 1 && i.Bomb.State == 1 && Has(i.ZeldasLullaby))
            {
                ColossusGreatFairy.color = Available;
            }
            else if (desertaccess == 1 && Has(i.Bombchu) && Has(i.ZeldasLullaby))
            {
                ColossusGreatFairy.color = OoLwithBombchus;
            }
            else
            {
                ColossusGreatFairy.color = NotAvailable;
            }
            //Arc
            if (desertaccess == 1 && Has(i.Beans))
            {
                ColossusPoH.color = Available;
            }
            else if (desertaccess == 1 && (Has(i.Bomb) || Has(i.Scales)))
            {
                ColossusPoH.color = coulddo;
            }
            else
            {
                ColossusPoH.color = NotAvailable;
            }
            //Skulltula
            if (desertaccess == 1 && Has(i.Hookshot))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && (has_longshot || can_get_beans))
            {
                tokensAvailable++;
            }
            if (desertaccess == 1 && has_bottle)
            {
                tokensAvailable++;
            }
        }
    }
}
