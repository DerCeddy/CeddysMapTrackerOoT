using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool GTG_Access;
        public void ItemLogic_GTG(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {
            gtg_available_checks = 0;
            bool is_child;
            if (Deku_Button.RegionPanel == GTG_RegionPanel || DC_Button.RegionPanel == GTG_RegionPanel || Jabu_Button.RegionPanel == GTG_RegionPanel || BotW_Button.RegionPanel == GTG_RegionPanel || (Fire_Button.RegionPanel == GTG_RegionPanel && Has(i.Bolero)) || Shadow_Button.RegionPanel == GTG_RegionPanel || (Spirit_Button.RegionPanel == GTG_RegionPanel && Has(i.Reqiuem)))
            {
                is_child = true;
            }
            else
            {
                is_child = false;
            }
            //LobbyChests
            if (GTG_Access && (Has(i.Bow) || (is_child && Has(i.Slingshot))))
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
            if (GTG_Access)
            {
                GTGStalfosChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGStalfosChest.ForeColor = NotAvailable;
            }
            //Beamos
            if (GTG_Access && i.Bomb.State == 1)
            {
                GTGBeamosChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (GTG_Access && Has(i.Bombchu))
            {
                GTGBeamosChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                GTGBeamosChest.ForeColor = NotAvailable;
            }
            //Toilet
            if (GTG_Access && Has(i.IronBoots) && Has(i.SongOfTime) && Has(i.Hookshot))
            {
                GTGUnderwaterSilverRupeeChest.ForeColor = Available;
                gtg_available_checks++;
            }          
            else
            {
                GTGUnderwaterSilverRupeeChest.ForeColor = NotAvailable;
            }       
            //Freestanding Key
            if (GTG_Access && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || DungeonInfoPanel.GTG.CurrentKeys == 9))
            {
                GTGFreestandingKey.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (GTG_Access && (Has(i.Bombchu) && Has(i.SongOfTime) || DungeonInfoPanel.GTG.CurrentKeys == 9))
            {
                GTGFreestandingKey.ForeColor = OoLwithBombchus;
            }
            else if (GTG_Access && (i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime))
            {
                GTGFreestandingKey.ForeColor = coulddo;
            }
            else
            {
                GTGFreestandingKey.ForeColor = NotAvailable;
            }
            //Before Heavy Block
            if (GTG_Access && Has(i.Hookshot))
            {
                GTGBeforeHeavyBlockChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGBeforeHeavyBlockChest.ForeColor = NotAvailable;
            }
            //Heavy Block Chests
            if (GTG_Access && Has(i.Hookshot) && i.Strength.State >= 2)
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
            if (GTG_Access && Has(i.Hookshot) && Has(i.Bow))
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
            if (GTG_Access && Has(i.Hookshot))
            {
                GTGHammerRoomClearChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGHammerRoomClearChest.ForeColor = NotAvailable;
            }
            if (GTG_Access && Has(i.Hookshot) && Has(i.Hammer))
            {
                GTGHammerRoomSwitchChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else
            {
                GTGHammerRoomSwitchChest.ForeColor = NotAvailable;
            }
            //Hidden Ceiling
            if (GTG_Access && DungeonInfoPanel.GTG.CurrentKeys >= 3)
            {
                GTGHiddenCeilingChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (GTG_Access && gtg_available_checks >= 3)
            {
                GTGHiddenCeilingChest.ForeColor = coulddo;               
            }
            else
            {
                GTGHiddenCeilingChest.ForeColor = NotAvailable;
            }
            //Maze 1
            if (GTG_Access && DungeonInfoPanel.GTG.CurrentKeys >= 4)
            {
                GTGMazePathFirstChest.ForeColor = Available;
                gtg_available_checks++;
            }
            else if (GTG_Access && gtg_available_checks >= 4)
            {
                GTGMazePathFirstChest.ForeColor = coulddo;               
            }
            else
            {
                GTGMazePathFirstChest.ForeColor = NotAvailable;
            }
            //Maze 2
            if (GTG_Access && DungeonInfoPanel.GTG.CurrentKeys >= 6)
            {
                GTGMazePathSecondChest.ForeColor = Available;
            }
            else if (GTG_Access && gtg_available_checks >= 6)
            {
                GTGMazePathSecondChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathSecondChest.ForeColor = NotAvailable;
            }
            //Maze 3
            if (GTG_Access && DungeonInfoPanel.GTG.CurrentKeys >= 7)
            {
                GTGMazePathThirdChest.ForeColor = Available;
            }
            else if (GTG_Access && gtg_available_checks >= 7)
            {
                GTGMazePathThirdChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathThirdChest.ForeColor = NotAvailable;
            }
            //Maze 4
            if (GTG_Access && DungeonInfoPanel.GTG.CurrentKeys >= 9)
            {
                GTGMazePathFinalChest.ForeColor = Available;
            }
            else if (GTG_Access && gtg_available_checks >= 9)
            {
                GTGMazePathFinalChest.ForeColor = coulddo;
            }
            else
            {
                GTGMazePathFinalChest.ForeColor = NotAvailable;
            }
            //Maze Right Chests
            if (GTG_Access && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || DungeonInfoPanel.GTG.CurrentKeys == 9))
            {
                GTGMazeRightCentralChest.ForeColor = Available;
                GTGMazeRightSideChest.ForeColor = Available;
                gtg_available_checks += 2;
            }
            else if (GTG_Access && (Has(i.Bombchu) && Has(i.SongOfTime) || DungeonInfoPanel.GTG.CurrentKeys == 9))
            {
                GTGMazeRightCentralChest.ForeColor = OoLwithBombchus;
                GTGMazeRightSideChest.ForeColor = OoLwithBombchus;
            }
            else if (GTG_Access && ((i.Bomb.State == 1 || Has(i.Hookshot)) && Has(i.SongOfTime) || gtg_available_checks >= 9))
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
