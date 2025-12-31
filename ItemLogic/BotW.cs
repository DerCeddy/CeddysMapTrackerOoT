using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public partial class Maptracker
    {
        public bool BotW_Access;
        public void ItemLogic_BotW(ItemPanel i, DungeonInfoPanel DungeonInfopanel)
        {     
            //Access
            if (BotW_Access)
            {
                BotWFreestandingKey.ForeColor = Available;
                BotWFrontLeftFakeWallChest.ForeColor = Available;
                BotWCompassChest.ForeColor = Available;
                BotWCenterSkulltulaChest.ForeColor = Available;
                BotWRightBottomFakeWallChest.ForeColor = Available;
            }
            else
            {
                BotWFreestandingKey.ForeColor = NotAvailable;
                BotWFrontLeftFakeWallChest.ForeColor = NotAvailable;
                BotWCompassChest.ForeColor = NotAvailable;
                BotWCenterSkulltulaChest.ForeColor = NotAvailable;
                BotWRightBottomFakeWallChest.ForeColor = NotAvailable;
            }
            //Bombable Things
            if (BotW_Access && i.Bomb.State == 1)
            {
                BotWFrontCenterBombableChest.ForeColor = Available;
                BotWBackLeftBombableChest.ForeColor = Available;
            }
            else if(BotW_Access && Has(i.Bombchu))
            {
                BotWFrontCenterBombableChest.ForeColor = OoLwithBombchus;
                BotWBackLeftBombableChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                BotWFrontCenterBombableChest.ForeColor = NotAvailable;
                BotWBackLeftBombableChest.ForeColor = NotAvailable;
            }
            //Behind ZL
            if (BotW_Access && Has(i.ZeldasLullaby))
            {
                BotWUnderwaterLeftChest.ForeColor = Available;
                BotWUnderwaterFrontChest.ForeColor = Available;
                BotWInvisibleChest.ForeColor = Available;
                BotWLensofTruthChest.ForeColor = Available;
            }
            else
            {
                BotWUnderwaterLeftChest.ForeColor = NotAvailable;
                BotWUnderwaterFrontChest.ForeColor = NotAvailable;
                BotWInvisibleChest.ForeColor = NotAvailable;
                BotWLensofTruthChest.ForeColor = NotAvailable;
            }
            //Map Chest
            if (BotW_Access && ((i.Bomb.State == 1) || (Has(i.Strength) && ((DungeonInfopanel.BotW.CurrentKeys == 3) || (Has(i.Dins) && Has(i.Magic))))))
            {
                BotWMapChest.ForeColor = Available;
            }
            else if(BotW_Access && Has(i.Bombchu))
            {
                BotWMapChest.ForeColor = OoLwithBombchus;
            }
            else if (BotW_Access && (i.Bomb.State == 1 || Has(i.Strength) || (Has(i.Dins) && Has(i.Magic))))
            {
                BotWMapChest.ForeColor = coulddo;
            }
            else
            {
                BotWMapChest.ForeColor = NotAvailable;
            }
            //Behind Locked Doors
            if (BotW_Access && DungeonInfopanel.BotW.CurrentKeys == 3)
            {
                BotWLikeLikeChest.ForeColor = Available;
                BotWFireKeeseChest.ForeColor = Available;
            }
            else if (BotW_Access)
            {
                BotWLikeLikeChest.ForeColor = coulddo;
                BotWFireKeeseChest.ForeColor = coulddo;
            }
            else
            {
                BotWLikeLikeChest.ForeColor = NotAvailable;
                BotWFireKeeseChest.ForeColor = NotAvailable;
            }
            //Skulltula
            if (BotW_Access && DungeonInfopanel.BotW.CurrentKeys == 3 && Has(i.Boomerang))
            {
                tokensAvailable += 3;
            }
        }
    }
}
