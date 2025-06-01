using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_Graveyard(ItemPanel i)
        {
            //Sun Song Grave
            if (Has(i.SunSong))
            {
                GraveyardHeartPieceGraveChest.ForeColor = Available;
            }
            else
            {
                GraveyardHeartPieceGraveChest.ForeColor = NotAvailable;
            }
            //Royal Tomb Chest
            if (Has(i.ZeldasLullaby) && Has(i.Magic) && (Has(i.Dins) || (Has(i.Bow) && Has(i.FireArrow))))
            {
                GraveyardRoyalFamilysTombChest.ForeColor = Available;
            }
            else
            {
                GraveyardRoyalFamilysTombChest.ForeColor = NotAvailable;
            }
            //Freestanding PoH
            if (Has(i.Beans) || has_longshot)
            {
                GraveyardFreestandingPoH.ForeColor = Available;
            }
            else if (Has(i.Bomb) || Has(i.Scales))
            {
                GraveyardFreestandingPoH.ForeColor = coulddo;
            }
            else
            {
                GraveyardFreestandingPoH.ForeColor = CanSee;
            }
            //Composer Song
            if (Has(i.ZeldasLullaby))
            {
                GraveyardComposerSong.ForeColor = Available;
            }
            else
            {
                GraveyardComposerSong.ForeColor = NotAvailable;
            }
            //Skulltula
            if (Has(i.Boomerang))
            {
                tokensAvailable++;
            }
        }
    }
}
