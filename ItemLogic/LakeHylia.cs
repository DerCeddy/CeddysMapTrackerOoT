using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_LakeHylia(ItemPanel i)
        {
            //Underwater Item
            if (Has(i.Scales))
            {
                LHUnderwaterItem.color = Available;
            }
            else
            {
                LHUnderwaterItem.color = CanSee;
            }
            //Labdive
            if (i.Scales.State == 2)
            {
                LHLabDive.color = Available;
            }
            else
            {
                LHLabDive.color = NotAvailable;
            }
            //Adult fishing and PoH
            if (Has(i.Hookshot) || Has(i.Beans))
            {
                LHAdultFishing.color = Available;
                LHFreestandingPoH.color = Available;
            }
            else if (Has(i.Hookshot) || can_get_beans)
            {
                LHAdultFishing.color = coulddo;
                LHFreestandingPoH.color = coulddo;
            }
            else
            {
                LHAdultFishing.color = NotAvailable;
                LHFreestandingPoH.color = NotAvailable;
            }
            //Shoot the sun
            if (has_longshot && Has(i.Bow))
            {
                LHShootTheSun.color = Available;
            }
            else
            {
                LHShootTheSun.color = NotAvailable;
            }
            //Skulltulla
            if (Has(i.Boomerang))
            {
                tokensAvailable++;
            }
            if (has_longshot)
            {
                tokensAvailable++;
            }
            if (Has(i.IronBoots) && Has(i.Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
