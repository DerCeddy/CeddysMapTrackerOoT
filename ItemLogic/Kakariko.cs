using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_Kakariko(ItemPanel i)
        {
            //Kak Shooting Gallery
            if (Has(i.Bow))
            {
                KakShootingGalleryReward.ForeColor = Available;
            }
            else
            {
                KakShootingGalleryReward.ForeColor = NotAvailable;
            }
            //Kak Redead Grotto
            if (can_blast_or_smash)
            {
                KakRedeadGrottoChest.ForeColor = Available;
            }
            else if(Has(i.Bombchu))
            {
                KakRedeadGrottoChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                KakRedeadGrottoChest.ForeColor = NotAvailable;
            }
            //Shiek at Kakariko
            if (Has(i.ForestMedallion) && Has(i.FireMedallion) && Has(i.WaterMedallion))
            {
                KakShiek.ForeColor = Available;
            }
            else
            {
                KakShiek.ForeColor = NotAvailable;
            }

            //Skulltula
            if (Has(i.Slingshot) || Has(i.Bomb))
            {
                tokensAvailable++;
            }
            if (Has(i.Hookshot))
            {
                tokensAvailable++;
            }
        }
    }
}
