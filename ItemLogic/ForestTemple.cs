using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        
        public void ItemLogic_ForestTemple(ItemPanel i, KeyPanel keys)
        {
            //ForestFirst2Checks
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot))
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
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && (Has(i.SongOfTime) || Has(i.Bow)))
            {
                ForestMapChest.ForeColor = Available;
                ForestRaisedIslandCourtyardChest.ForeColor = Available;
                ForestWellChest.ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                ForestMapChest.ForeColor = NotAvailable;
                ForestRaisedIslandCourtyardChest.ForeColor = NotAvailable;
                ForestWellChest.ForeColor = NotAvailable;
            }
            //Forest Eye Switch Chest
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && keys.Forest_SmallKeys.currentKeys >= 1 && Has(i.Bow))
            {
                ForestEyeSwitchChest.ForeColor = Available;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Bow))
            {
                ForestEyeSwitchChest.ForeColor = coulddo;
            }
            else
            {
                ForestEyeSwitchChest.ForeColor = NotAvailable;
            }
            //Forest Floormaster
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && ((Has(i.Strength) && keys.Forest_SmallKeys.currentKeys >= 2 && Has(i.Bow)) || (Has(i.HoverBoots) && keys.Forest_SmallKeys.currentKeys >= 1)))
            {
                ForestFloormasterChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && ((Has(i.Strength) && Has(i.Bow)) || (Has(i.HoverBoots))))
            {
                ForestFloormasterChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ForestFloormasterChest.ForeColor = NotAvailable;
            }
            //Forest Boss Key
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Strength) && keys.Forest_SmallKeys.currentKeys >= 2 && Has(i.Bow))
            {
                ForestBossKeyChest.ForeColor = Available;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Strength) && Has(i.Bow))
            {
                ForestBossKeyChest.ForeColor = coulddo;
            }
            else
            {
                ForestBossKeyChest.ForeColor = NotAvailable;
            }
            //ForestWithStrength
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && keys.Forest_SmallKeys.currentKeys >= 3 && Has(i.Strength))
            {
                ForestBowChest.ForeColor = Available;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Strength) && (Has(i.SongOfTime) || Has(i.Bow) || Has(i.HoverBoots)))
            {
                ForestBowChest.ForeColor = coulddo;
            }
            else
            {
                ForestBowChest.ForeColor = NotAvailable;
            }
            //Red and Blue Poe
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && keys.Forest_SmallKeys.currentKeys >= 3 && Has(i.Strength) && Has(i.Bow))
            {
                ForestRedPoeChest.ForeColor = Available;
                ForestBluePoeChest.ForeColor = Available;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Strength) && Has(i.Bow))
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
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Bow) && Has(i.Strength) && keys.Forest_SmallKeys.currentKeys == 5)
            {
                ForestFallingCeillingRoomChest.ForeColor = Available;
                ForestBasementChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Bow) && Has(i.Strength))
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
            if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Bow) && Has(i.Strength) && keys.Forest_SmallKeys.currentKeys == 5 && Has(i.ForestBossKey))
            {
                ForestPhantomGanonHeart.ForeColor = Available;

            }
            else if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot) && Has(i.Bow) && Has(i.Strength))
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
