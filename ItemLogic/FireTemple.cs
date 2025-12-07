using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Fire_Temple_Access;
        public void ItemLogic_FireTemple(ItemPanel i, DungeonInfoPanel DungeonPanelInfo)
        {                    
            //Near Boss
            if (Fire_Temple_Access)
            {
                FireNearBossChest.ForeColor = Available;              
            }
            else
            {
                FireNearBossChest.ForeColor = NotAvailable;
            }
            //Beginning Hammer locked checks
            if (Has(i.Hammer) && Fire_Temple_Access)
            {
                FireBossKeyChest.ForeColor = Available;
                FireFlareDancerChest.ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                FireBossKeyChest.ForeColor = NotAvailable;
                FireFlareDancerChest.ForeColor = NotAvailable;
            }
            //Big Lava Lower
            if (DungeonPanelInfo.FireTemple.CurrentKeys >= 1 && Fire_Temple_Access)
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = Available;
            }
            else if (Fire_Temple_Access)
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = coulddo;
            }
            else
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = NotAvailable;
            }
            //Blocked door
            if (i.Bomb.State == 1 && DungeonPanelInfo.FireTemple.CurrentKeys >= 1 && Fire_Temple_Access)
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = Available;
            }
            else if (i.Bomb.State == 1 && Fire_Temple_Access)
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = coulddo;
            }
            else
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = NotAvailable;
            }
            //Bouldermaze lower
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && DungeonPanelInfo.FireTemple.CurrentKeys >= 3 && Fire_Temple_Access)
            {
                FireBoulderMazeLowerChest.ForeColor = Available;
                FireBoulderMazeSideRoomChest.ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access)
            {
                FireBoulderMazeLowerChest.ForeColor = coulddo;
                FireBoulderMazeSideRoomChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeLowerChest.ForeColor = NotAvailable;
                FireBoulderMazeSideRoomChest.ForeColor = NotAvailable;
            }
            //Mapchest
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && ((DungeonPanelInfo.FireTemple.CurrentKeys >= 4 && Has(i.Bow)) || DungeonPanelInfo.FireTemple.CurrentKeys >= 5) && Fire_Temple_Access)
            {
                FireMapChest.ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(i.Strength) && Has(i.Bow) && Fire_Temple_Access)
            {
                FireMapChest.ForeColor = coulddo;
            }
            else
            {
                FireMapChest.ForeColor = NotAvailable;
            }
            //Upper Maze
            if (Fire_Temple_Access && has_or_can_red_tunic == 1 && Has(i.Strength) && DungeonPanelInfo.FireTemple.CurrentKeys >= 5)
            {
                FireBoulderMazeUpperChest.ForeColor = Available;
            }
            else if (Fire_Temple_Access && has_or_can_red_tunic == 1 && Has(i.Strength))
            {
                FireBoulderMazeUpperChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeUpperChest.ForeColor = NotAvailable;
            }
            //Scarecrow Chest
            if (Fire_Temple_Access && has_or_can_red_tunic == 1 && Has(i.Strength) && DungeonPanelInfo.FireTemple.CurrentKeys >= 5 && Has(i.Hookshot))
            {
                FireScarecrowChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else if (Fire_Temple_Access && has_or_can_red_tunic == 1 && Has(i.Strength) && Has(i.Hookshot))
            {
                FireScarecrowChest.ForeColor = coulddo;
                tokensAvailable += 2;
            }
            else
            {
                FireScarecrowChest.ForeColor = NotAvailable;
            }
            //Shortcut chest
            if (i.Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access && DungeonPanelInfo.FireTemple.CurrentKeys >= 5)
            {
                FireBoulderMazeShortcutChest.ForeColor = Available;
            }
            else if (i.Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access)
            {
                FireBoulderMazeShortcutChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeShortcutChest.ForeColor = NotAvailable;
            }
            //Compass Chest
            if (Fire_Temple_Access && DungeonPanelInfo.FireTemple.CurrentKeys >= 6 && Has(i.Strength) && has_or_can_red_tunic == 1)
            {
                FireCompassChest.ForeColor = Available;
            }
            else if (Fire_Temple_Access && Has(i.Strength) && has_or_can_red_tunic == 1)
            {
                FireCompassChest.ForeColor = coulddo;
            }
            else
            {
                FireCompassChest.ForeColor = NotAvailable;
            }
            //Highest Goron chest
            if ((DungeonPanelInfo.FireTemple.CurrentKeys >= 7 || (Has(i.HoverBoots) && DungeonPanelInfo.FireTemple.CurrentKeys >= 6)) && Has(i.Hammer) && (Has(i.SongOfTime) || Has(i.HoverBoots) || i.Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access)
            {
                FireHighestGoronChest.ForeColor = Available;
            }
            else if (Has(i.Hammer) && Has(i.HoverBoots) && Has(i.Hammer) && (Has(i.SongOfTime) || Has(i.HoverBoots) || i.Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access)
            {
                FireHighestGoronChest.ForeColor = coulddo;
            }
            else
            {
                FireHighestGoronChest.ForeColor = NotAvailable;
            }
            //Hammer Chest
            if ((DungeonPanelInfo.FireTemple.CurrentKeys >= 7 || (Has(i.Hammer) && Has(i.HoverBoots) && DungeonPanelInfo.FireTemple.CurrentKeys >= 6)) && i.Bomb.State == 1 && Has(i.Strength) && (Has(i.GoronTunic) || Has(i.Wallet)) && Fire_Temple_Access)
            {
                FireMegatonHammerChest.ForeColor = Available;
            }
            else if (Has(i.Hammer) && Has(i.HoverBoots) && i.Bomb.State == 1 && Has(i.Strength) && (Has(i.GoronTunic) || Has(i.Wallet)) && Fire_Temple_Access)
            {
                FireMegatonHammerChest.ForeColor = coulddo;
            }
            else
            {
                FireMegatonHammerChest.ForeColor = NotAvailable;
            }
            //Volvo defeat
            if (Has(i.Hammer) && has_or_can_red_tunic == 1 && Fire_Temple_Access && Has(DungeonPanelInfo.FireBossKey) && (Has(i.HoverBoots) || DungeonPanelInfo.FireTemple.CurrentKeys >= 7 && (Has(i.Bomb) || Has(i.SongOfTime))))
            {
                FireVolvagiaHeart.ForeColor = Available;
            }
            else if (Has(i.Hammer) && has_or_can_red_tunic == 1 && Fire_Temple_Access && Has(i.HoverBoots))
            {
                FireVolvagiaHeart.ForeColor = coulddo;
            }
            else
            {
                FireVolvagiaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (Fire_Temple_Access && Has(i.SongOfTime))
            {
                tokensAvailable++;
            }
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && Fire_Temple_Access && Has(i.Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
