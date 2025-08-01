using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_ToT(ItemPanel i)
        {           
            //Light Arrow Cutscene
            if (Has(i.SpiritMedallion) && Has(i.ShadowMedallion))
            {
                ToTLACS.ForeColor = Available;
            }
            else
            {
                ToTLACS.ForeColor = NotAvailable;
            }
            //Shiek at Temple
            if (Has(i.ForestMedallion))
            {
                ToTShiek.ForeColor = Available;
            }
            else
            {
                ToTShiek.ForeColor = NotAvailable;
            }
        }
    }
}
