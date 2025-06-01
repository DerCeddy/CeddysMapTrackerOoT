using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_FireTemple(ItemPanel i, KeyPanel keys)
        {                    
            //Near Boss
            if (craterplatformaccess == 1)
            {
                FireNearBossChest.ForeColor = Available;              
            }
            else
            {
                FireNearBossChest.ForeColor = NotAvailable;
            }
            //Beginning Hammer locked checks
            if (Has(i.Hammer) && craterplatformaccess == 1)
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
            if (keys.Fire_SmallKeys.currentKeys >= 1 && craterplatformaccess == 1)
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = Available;
            }
            else if (craterplatformaccess == 1)
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = coulddo;
            }
            else
            {
                FireBigLavaRoomLowerDoorChest.ForeColor = NotAvailable;
            }
            //Blocked door
            if (i.Bomb.State == 1 && keys.Fire_SmallKeys.currentKeys >= 1 && craterplatformaccess == 1)
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = Available;
            }
            else if (i.Bomb.State == 1 && craterplatformaccess == 1)
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = coulddo;
            }
            else
            {
                FireBigLavaRoomBlockedDoorChest.ForeColor = NotAvailable;
            }
            //Bouldermaze lower
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && keys.Fire_SmallKeys.currentKeys >= 3 && craterplatformaccess == 1)
            {
                FireBoulderMazeLowerChest.ForeColor = Available;
                FireBoulderMazeSideRoomChest.ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1)
            {
                FireBoulderMazeLowerChest.ForeColor = Available;
                FireBoulderMazeSideRoomChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeLowerChest.ForeColor = NotAvailable;
                FireBoulderMazeSideRoomChest.ForeColor = NotAvailable;
            }
            //Mapchest
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && ((keys.Fire_SmallKeys.currentKeys >= 4 && Has(i.Bow)) || keys.Fire_SmallKeys.currentKeys >= 5) && craterplatformaccess == 1)
            {
                FireMapChest.ForeColor = Available;
            }
            else if (has_or_can_red_tunic == 1 && Has(i.Strength) && Has(i.Bow) && craterplatformaccess == 1)
            {
                FireMapChest.ForeColor = coulddo;
            }
            else
            {
                FireMapChest.ForeColor = NotAvailable;
            }
            //Upper Maze
            if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && keys.Fire_SmallKeys.currentKeys >= 5)
            {
                FireBoulderMazeUpperChest.ForeColor = Available;
            }
            else if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(i.Strength))
            {
                FireBoulderMazeUpperChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeUpperChest.ForeColor = NotAvailable;
            }
            //Scarecrow Chest
            if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && keys.Fire_SmallKeys.currentKeys >= 5 && Has(i.Hookshot))
            {
                FireScarecrowChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else if (craterplatformaccess == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && Has(i.Hookshot))
            {
                FireScarecrowChest.ForeColor = coulddo;
                tokensAvailable += 2;
            }
            else
            {
                FireScarecrowChest.ForeColor = NotAvailable;
            }
            //Shortcut chest
            if (i.Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1 && keys.Fire_SmallKeys.currentKeys >= 5)
            {
                FireBoulderMazeShortcutChest.ForeColor = Available;
            }
            else if (i.Bomb.State == 1 && has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1)
            {
                FireBoulderMazeShortcutChest.ForeColor = coulddo;
            }
            else
            {
                FireBoulderMazeShortcutChest.ForeColor = NotAvailable;
            }
            //Compass Chest
            if (craterplatformaccess == 1 && keys.Fire_SmallKeys.currentKeys >= 6 && Has(i.Strength) && has_or_can_red_tunic == 1)
            {
                FireCompassChest.ForeColor = Available;
            }
            else if (craterplatformaccess == 1 && Has(i.Strength) && has_or_can_red_tunic == 1)
            {
                FireCompassChest.ForeColor = coulddo;
            }
            else
            {
                FireCompassChest.ForeColor = NotAvailable;
            }
            //Highest Goron chest
            if ((keys.Fire_SmallKeys.currentKeys >= 7 || (Has(i.Hammer) && Has(i.HoverBoots) && keys.Fire_SmallKeys.currentKeys >= 6)) && Has(i.Hammer) && (Has(i.SongOfTime) || Has(i.HoverBoots) || i.Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1)
            {
                FireHighestGoronChest.ForeColor = Available;
            }
            else if (Has(i.Hammer) && Has(i.HoverBoots) && Has(i.Hammer) && (Has(i.SongOfTime) || Has(i.HoverBoots) || i.Bomb.State == 1) && has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1)
            {
                FireHighestGoronChest.ForeColor = coulddo;
            }
            else
            {
                FireHighestGoronChest.ForeColor = NotAvailable;
            }
            //Hammer Chest
            if ((keys.Fire_SmallKeys.currentKeys >= 7 || (Has(i.Hammer) && Has(i.HoverBoots) && keys.Fire_SmallKeys.currentKeys >= 6)) && i.Bomb.State == 1)
            {
                FireMegatonHammerChest.ForeColor = Available;
            }
            else if (Has(i.Hammer) && Has(i.HoverBoots) && i.Bomb.State == 1)
            {
                FireMegatonHammerChest.ForeColor = coulddo;
            }
            else
            {
                FireMegatonHammerChest.ForeColor = NotAvailable;
            }
            //Volvo defeat
            if (Has(i.Hammer) && has_or_can_red_tunic == 1 && craterplatformaccess == 1 && (Has(i.HoverBoots) || keys.Fire_SmallKeys.currentKeys >= 7) && Has(i.FireBossKey))
            {
                FireVolvagiaHeart.ForeColor = Available;
            }
            else if (Has(i.Hammer) && has_or_can_red_tunic == 1 && craterplatformaccess == 1 && Has(i.HoverBoots))
            {
                FireVolvagiaHeart.ForeColor = coulddo;
            }
            else
            {
                FireVolvagiaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (craterplatformaccess == 1 && Has(i.SongOfTime))
            {
                tokensAvailable++;
            }
            if (has_or_can_red_tunic == 1 && Has(i.Strength) && craterplatformaccess == 1 && Has(i.Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
