using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Forest_Temple_Access;
        public void ItemLogic_ForestTemple(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {
            //ForestFirst2Checks
            if (Forest_Temple_Access)
            {
                ForestFirstRoomChest.ForeColor = Available;
                ForestFirstStalfosRoomChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else
            {
                ForestFirstRoomChest.ForeColor = NotAvailable;
                ForestFirstStalfosRoomChest.ForeColor = NotAvailable;
            }
            //ForestBackyard
            if (Forest_Temple_Access && (Has(i.SongOfTime) || Has(i.Bow)))
            {
                ForestMapChest.ForeColor = Available;
                ForestWellChest.ForeColor = Available;
            }
            else
            {
                ForestMapChest.ForeColor = NotAvailable;
                ForestWellChest.ForeColor = NotAvailable;
            }
            //Forest raised island courtyard
            if (Forest_Temple_Access && ((Has(i.SongOfTime) || Has(i.Bow)) && Has(i.Hookshot)) || DungeonInfoPanel.ForestTemple.CurrentKeys == 5)
            {
                ForestRaisedIslandCourtyardChest.ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                ForestRaisedIslandCourtyardChest.ForeColor = NotAvailable;
            }
            //Forest Eye Switch Chest
            if (Forest_Temple_Access && DungeonInfoPanel.ForestTemple.CurrentKeys >= 1 && Has(i.Bow) && Has(i.Strength))
            {
                ForestEyeSwitchChest.ForeColor = Available;
            }
            else if (Forest_Temple_Access && Has(i.Bow))
            {
                ForestEyeSwitchChest.ForeColor = coulddo;
            }
            else
            {
                ForestEyeSwitchChest.ForeColor = NotAvailable;
            }
            //Forest Floormaster
            if (Forest_Temple_Access && ((Has(i.Strength) && DungeonInfoPanel.ForestTemple.CurrentKeys >= 2 && Has(i.Bow)) || (Has(i.HoverBoots) && DungeonInfoPanel.ForestTemple.CurrentKeys >= 1)))
            {
                ForestFloormasterChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Forest_Temple_Access && ((Has(i.Strength) && Has(i.Bow)) || (Has(i.HoverBoots))))
            {
                ForestFloormasterChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ForestFloormasterChest.ForeColor = NotAvailable;
            }
            //Forest Boss Key
            if (Forest_Temple_Access && Has(i.Strength) && DungeonInfoPanel.ForestTemple.CurrentKeys >= 2 && Has(i.Bow))
            {
                ForestBossKeyChest.ForeColor = Available;
            }
            else if (Forest_Temple_Access && Has(i.Strength) && Has(i.Bow))
            {
                ForestBossKeyChest.ForeColor = coulddo;
            }
            else
            {
                ForestBossKeyChest.ForeColor = NotAvailable;
            }
            //ForestWithStrength
            if (Forest_Temple_Access && DungeonInfoPanel.ForestTemple.CurrentKeys >= 3 && Has(i.Strength))
            {
                ForestBowChest.ForeColor = Available;
            }
            else if (Forest_Temple_Access && Has(i.Strength) && (Has(i.SongOfTime) || Has(i.Bow) || Has(i.HoverBoots)))
            {
                ForestBowChest.ForeColor = coulddo;
            }
            else
            {
                ForestBowChest.ForeColor = NotAvailable;
            }
            //Red and Blue Poe
            if (Forest_Temple_Access && DungeonInfoPanel.ForestTemple.CurrentKeys >= 3 && Has(i.Strength) && Has(i.Bow))
            {
                ForestRedPoeChest.ForeColor = Available;
                ForestBluePoeChest.ForeColor = Available;
            }
            else if (Forest_Temple_Access && Has(i.Strength) && Has(i.Bow))
            {
                ForestRedPoeChest.ForeColor = coulddo;
                ForestBluePoeChest.ForeColor = coulddo;
            }
            else
            {
                ForestRedPoeChest.ForeColor = NotAvailable;
                ForestBluePoeChest.ForeColor = NotAvailable;
            }
            //ForestRest
            if (Forest_Temple_Access && Has(i.Bow) && Has(i.Strength) && DungeonInfoPanel.ForestTemple.CurrentKeys == 5)
            {
                ForestFallingCeillingRoomChest.ForeColor = Available;
                ForestBasementChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Forest_Temple_Access && Has(i.Bow) && Has(i.Strength))
            {
                ForestFallingCeillingRoomChest.ForeColor = coulddo;
                ForestBasementChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ForestFallingCeillingRoomChest.ForeColor = NotAvailable;
                ForestBasementChest.ForeColor = NotAvailable;
            }
            //Boss
            if (Forest_Temple_Access && Has(i.Bow) && Has(i.Strength) && DungeonInfoPanel.ForestTemple.CurrentKeys == 5 && Has(DungeonInfoPanel.ForestBossKey))
            {
                ForestPhantomGanonHeart.ForeColor = Available;

            }
            else if (Forest_Temple_Access && Has(i.Bow) && Has(i.Strength))
            {
                ForestPhantomGanonHeart.ForeColor = coulddo;

            }
            else
            {
                ForestPhantomGanonHeart.ForeColor = NotAvailable;
            }
        }
    }
}
