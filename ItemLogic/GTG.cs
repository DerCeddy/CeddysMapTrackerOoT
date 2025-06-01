using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_GTG(ItemPanel i, KeyPanel keys)
        {
            gtg_available_checks = 0;
            //LobbyChests
            if (has_or_can_get_gerudocard && Has(i.Bow))
            {
                GTGLobbyLeftChest.ForeColor = Available;
                GTGLobbyRightChest.ForeColor = Available;
                gtg_available_checks += 2;
            }
            else
            {
                GTGLobbyLeftChest.ForeColor = NotAvailable;
                GTGLobbyRightChest.ForeColor = NotAvailable;
            }
            //Stalfos
            if (has_or_can_get_gerudocard)
            {
                GTGStalfosChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGStalfosChest.ForeColor = NotAvailable;
            }
            //Beamos
            if (has_or_can_get_gerudocard && i.Bomb.State == 1)
            {
                GTGBeamosChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && Has(i.Bombchu))
            {
                GTGBeamosChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                GTGBeamosChest.ForeColor = NotAvailable;
            }
            //Toilet
            if (has_or_can_get_gerudocard && Has(i.IronBoots) && Has(i.SongOfTime) && (Has(i.Bomb) || Has(i.Hookshot)))
            {
                GTGUnderwaterSilverRupeeChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && Has(i.IronBoots) && Has(i.SongOfTime) && Has(i.Bombchu))
            {
                GTGUnderwaterSilverRupeeChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                GTGUnderwaterSilverRupeeChest.ForeColor = NotAvailable;
            }       
            //Freestanding Key
            if (has_or_can_get_gerudocard && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || keys.GTG_SmallKeys.currentKeys == 9))
            {
                GTGFreestandingKey.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && (Has(i.Bombchu) && Has(i.SongOfTime) || keys.GTG_SmallKeys.currentKeys == 9))
            {
                GTGFreestandingKey.ForeColor = OoLwithBombchus;
            }
            else if (has_or_can_get_gerudocard && (i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime))
            {
                GTGFreestandingKey.ForeColor = coulddo;
            }
            else
            {
                GTGFreestandingKey.ForeColor = NotAvailable;
            }
            //Before Heavy Block
            if (has_or_can_get_gerudocard && Has(i.Hookshot))
            {
                GTGBeforeHeavyBlockChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGBeforeHeavyBlockChest.ForeColor = NotAvailable;
            }
            //Heavy Block Chests
            if (has_or_can_get_gerudocard && Has(i.Hookshot) && i.Strength.State >= 2)
            {
                GTGHeavyBlockFirstChest.ForeColor = Available;
                GTGHeavyBlockFourthChest.ForeColor = Available;
                GTGHeavyBlockSecondChest.ForeColor = Available;
                GTGHeavyBlockThirdChest.ForeColor = Available;
                gtg_available_checks += 4;
            }
            else
            {
                GTGHeavyBlockFirstChest.ForeColor = NotAvailable;
                GTGHeavyBlockFourthChest.ForeColor = NotAvailable;
                GTGHeavyBlockSecondChest.ForeColor = NotAvailable;
                GTGHeavyBlockThirdChest.ForeColor = NotAvailable;
            }
            //Eye Statue Chests
            if (has_or_can_get_gerudocard && Has(i.Hookshot) && Has(i.Bow))
            {
                GTGEyeStatueChest.ForeColor = Available;
                GTGNearScarecrowChest.ForeColor = Available;
                gtg_available_checks += 2;
            }
            else
            {
                GTGEyeStatueChest.ForeColor = NotAvailable;
                GTGNearScarecrowChest.ForeColor = NotAvailable;
            }
            //Hammer room
            if (has_or_can_get_gerudocard && Has(i.Hookshot))
            {
                GTGHammerRoomClearChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGHammerRoomClearChest.ForeColor = NotAvailable;
            }
            if (has_or_can_get_gerudocard && Has(i.Hookshot) && Has(i.Hammer))
            {
                GTGHammerRoomSwitchChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGHammerRoomSwitchChest.ForeColor = NotAvailable;
            }
            //Hidden Ceiling
            if (has_or_can_get_gerudocard && keys.GTG_SmallKeys.currentKeys >= 3)
            {
                GTGHiddenCeilingChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 3)
            {
                GTGHiddenCeilingChest.ForeColor = coulddo;               
            }
            else
            {
                GTGHiddenCeilingChest.ForeColor = NotAvailable;
            }
            //Maze 1
            if (has_or_can_get_gerudocard && keys.GTG_SmallKeys.currentKeys >= 4)
            {
                GTGMazePathFirstChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 4)
            {
                GTGMazePathFirstChest.ForeColor = coulddo;               
            }
            else
            {
                GTGMazePathFirstChest.ForeColor = NotAvailable;
            }
            //Maze 2
            if (has_or_can_get_gerudocard && keys.GTG_SmallKeys.currentKeys >= 6)
            {
                GTGMazePathSecondChest.ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 6)
            {
                GTGMazePathSecondChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathSecondChest.ForeColor = NotAvailable;
            }
            //Maze 3
            if (has_or_can_get_gerudocard && keys.GTG_SmallKeys.currentKeys >= 7)
            {
                GTGMazePathThirdChest.ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 7)
            {
                GTGMazePathThirdChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathThirdChest.ForeColor = NotAvailable;
            }
            //Maze 4
            if (has_or_can_get_gerudocard && keys.GTG_SmallKeys.currentKeys >= 9)
            {
                GTGMazePathFinalChest.ForeColor = Available;
            }
            else if (has_or_can_get_gerudocard && gtg_available_checks >= 9)
            {
                GTGMazePathFinalChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathFinalChest.ForeColor = NotAvailable;
            }
            //Maze Right Chests
            if (has_or_can_get_gerudocard && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || keys.GTG_SmallKeys.currentKeys == 9))
            {
                GTGMazeRightCentralChest.ForeColor = Available;
                GTGMazeRightSideChest.ForeColor = Available;
                gtg_available_checks += 2;
            }
            else if (has_or_can_get_gerudocard && (Has(i.Bombchu) && Has(i.SongOfTime) || keys.GTG_SmallKeys.currentKeys == 9))
            {
                GTGMazeRightCentralChest.ForeColor = OoLwithBombchus;
                GTGMazeRightSideChest.ForeColor = OoLwithBombchus;
            }
            else if (has_or_can_get_gerudocard && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || gtg_available_checks >= 9))
            {
                GTGMazeRightCentralChest.ForeColor = coulddo;
                GTGMazeRightSideChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazeRightCentralChest.ForeColor = NotAvailable;
                GTGMazeRightSideChest.ForeColor = NotAvailable;
            }
        }
    }
}
