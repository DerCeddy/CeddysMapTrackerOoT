using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_HyruleField(ItemPanel i)
        {
            //Checks under Rocks and Salesman
            if (Has(i.Bomb) || Has(i.Hammer))
            {
                HFNearMarketGrottoChest.color = Available;
                HFSalesman.color = Available;
                HFSoutheastGrottoChest.color = Available;
            }
            else if(Has(i.Bombchu))
            {
                HFNearMarketGrottoChest.color = OoLwithBombchus;
                HFSalesman.color = OoLwithBombchus;
                HFSoutheastGrottoChest.color = OoLwithBombchus;
            }
            else
            {
                HFNearMarketGrottoChest.color = NotAvailable;
                HFSalesman.color = NotAvailable;
                HFSoutheastGrottoChest.color = NotAvailable;
            }
            //Diving Grotto
            if ((Has(i.Bomb) || Has(i.Hammer)) && (i.Scales.State == 2 || Has(i.IronBoots)))
            {
                HFTektikeGrottoPoH.color = Available;
            }
            else if (Has(i.Bombchu) && (i.Scales.State == 2 || Has(i.IronBoots)))
            {
                HFTektikeGrottoPoH.color = OoLwithBombchus;
            }
            else
            {
                HFTektikeGrottoPoH.color = NotAvailable;
            }
            //Song of Time
            if (Has(i.KokiriStone) && Has(i.GoronStone) && Has(i.ZoraStone))
            {
                HFOoT.color = Available;
            }
            else
            {
                HFOoT.color = NotAvailable;
            }
            //Skulltula
            if ((Has(i.Boomerang) && Has(i.Bomb)) || (can_blast_or_smash && Has(i.Hookshot)))
            {
                tokensAvailable++;
            }
            if (has_firesource && Has(i.Bomb) && (Has(i.Hookshot) || Has(i.Boomerang)))
            {
                tokensAvailable++;
            }
        }
    }
}
