using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_ToT(ItemPanel i)
        {           
            //Light Arrow Cutscene
            if (Has(i.SpiritMedallion) && Has(i.ShadowMedallion))
            {
                ToTLACS.color = Available;
            }
            else
            {
                ToTLACS.color = NotAvailable;
            }
            //Shiek at Temple
            if (Has(i.ForestMedallion))
            {
                ToTShiek.color = Available;
            }
            else
            {
                ToTShiek.color = NotAvailable;
            }
        }
    }
}
