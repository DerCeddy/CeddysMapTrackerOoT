using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public partial class Maptracker
    {
        public void ItemLogic_BotW(ItemPanel i, KeyPanel keys)
        {           
            //Access
            if (Has(i.SongOfStorms))
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
            if (Has(i.SongOfStorms) && i.Bomb.State == 1)
            {
                BotWFrontCenterBombableChest.ForeColor = Available;
                BotWBackLeftBombableChest.ForeColor = Available;
            }
            else if(Has(i.SongOfStorms) && Has(i.Bombchu))
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
            if (Has(i.SongOfStorms) && Has(i.ZeldasLullaby))
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
            if (Has(i.SongOfStorms) && ((i.Bomb.State == 1) || (Has(i.Strength) && ((keys.BotW_SmallKeys.currentKeys == 3) || (Has(i.Dins) && Has(i.Magic))))))
            {
                BotWMapChest.ForeColor = Available;
            }
            else if(Has(i.SongOfStorms) && Has(i.Bombchu))
            {
                BotWMapChest.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.SongOfStorms) && (i.Bomb.State == 1 || Has(i.Strength) || (Has(i.Dins) && Has(i.Magic))))
            {
                BotWMapChest.ForeColor = coulddo;
            }
            else
            {
                BotWMapChest.ForeColor = NotAvailable;
            }
            //Behind Locked Doors
            if (Has(i.SongOfStorms) && keys.BotW_SmallKeys.currentKeys == 3)
            {
                BotWLikeLikeChest.ForeColor = Available;
                BotWFireKeeseChest.ForeColor = Available;
            }
            else if (Has(i.SongOfStorms))
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
            if (Has(i.SongOfStorms) && keys.BotW_SmallKeys.currentKeys == 3 && Has(i.Boomerang))
            {
                tokensAvailable += 3;
            }
        }
    }
}
