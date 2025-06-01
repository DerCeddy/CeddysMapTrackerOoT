using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_Skulltulas(ItemPanel i)
        {
            if (Has(i.Boomerang))
            {
                tokensAvailable += 3;
            }
            if (has_bottle)
            {
                tokensAvailable += 6;
            }
            //Skullhouse
            if (tokensAvailable >= 10)
            {
                Kak10GoldSkulltulaReward.ForeColor = Available;
            }
            else
            {
                Kak10GoldSkulltulaReward.ForeColor = NotAvailable;
            }
            if (tokensAvailable >= 20)
            {
                Kak20GoldSkulltulaReward.ForeColor = Available;
            }
            else
            {
                Kak20GoldSkulltulaReward.ForeColor = NotAvailable;
            }
            if (tokensAvailable >= 30)
            {
                Kak30GoldSkulltulaReward.ForeColor = Available;
            }
            else
            {
                Kak30GoldSkulltulaReward.ForeColor = NotAvailable;
            }
            if (tokensAvailable >= 40)
            {
                Kak40GoldSkulltulaReward.ForeColor = Available;
            }
            else
            {
                Kak40GoldSkulltulaReward.ForeColor = NotAvailable;
            }
            if (tokensAvailable >= 50)
            {
                Kak50GoldSkulltulaReward.ForeColor = Available;
            }
            else
            {
                Kak50GoldSkulltulaReward.ForeColor = NotAvailable;
            }         
        }
    }
}
