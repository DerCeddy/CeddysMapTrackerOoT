using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Shadow_Temple_Access;
        public void ItemLogic_ShadowTemple(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {
            //Shadow Entrance      
            if (Shadow_Temple_Access && (Has(i.Hookshot) || Has(i.HoverBoots)))
            {
                ShadowMapChest.ForeColor = Available;
                ShadowHoverBootsChest.ForeColor = Available;
            }
            else
            {
                ShadowMapChest.ForeColor = NotAvailable;
                ShadowHoverBootsChest.ForeColor = NotAvailable;
            }
            //Shadow beyond statue
            if (Shadow_Temple_Access && Has(i.HoverBoots))
            {
                ShadowCompassChest.ForeColor = Available;
                ShadowEarlySilverRupeeChest.ForeColor = Available;
            }
            else
            {
                ShadowCompassChest.ForeColor = NotAvailable;
                ShadowEarlySilverRupeeChest.ForeColor = NotAvailable;
            }
            //Shadow beyond Beamos
            if (Shadow_Temple_Access && Has(i.HoverBoots) && i.Bomb.State == 1 && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 1)
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = Available;
                ShadowInvisibleBladesVisibleChest.ForeColor = Available;
                ShadowFallingSpikesLowerChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bombchu) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 1)
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = OoLwithBombchus;
                ShadowInvisibleBladesVisibleChest.ForeColor = OoLwithBombchus;
                ShadowFallingSpikesLowerChest.ForeColor = OoLwithBombchus;               
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && i.Bomb.State == 1)
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = coulddo;
                ShadowInvisibleBladesVisibleChest.ForeColor = coulddo;
                ShadowFallingSpikesLowerChest.ForeColor = coulddo;
                tokensAvailable += 2;
            }
            else
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = NotAvailable;
                ShadowInvisibleBladesVisibleChest.ForeColor = NotAvailable;
                ShadowFallingSpikesLowerChest.ForeColor = NotAvailable;
            }
            //Shadow Upper Falling Spike
            if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Strength) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 1)
            {
                ShadowFallingSpikesUpperChest.ForeColor = Available;
                ShadowFallingSpikesSwitchChest.ForeColor = Available;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Strength) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 1)
            {
                ShadowFallingSpikesUpperChest.ForeColor = OoLwithBombchus;
                ShadowFallingSpikesSwitchChest.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Strength))
            {
                ShadowFallingSpikesUpperChest.ForeColor = coulddo;
                ShadowFallingSpikesSwitchChest.ForeColor = coulddo;
            }
            else
            {
                ShadowFallingSpikesUpperChest.ForeColor = NotAvailable;
                ShadowFallingSpikesSwitchChest.ForeColor = NotAvailable;
            }
            //Shadow Invisible Spikes
            if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 2)
            {
                ShadowInvisibleSpikesChest.ForeColor = Available;
                ShadowFreestandingKey.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bombchu) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 2)
            {
                ShadowInvisibleSpikesChest.ForeColor = OoLwithBombchus;
                ShadowFreestandingKey.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb))
            {
                ShadowInvisibleSpikesChest.ForeColor = coulddo;
                ShadowFreestandingKey.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ShadowInvisibleSpikesChest.ForeColor = NotAvailable;
                ShadowFreestandingKey.ForeColor = NotAvailable;
            }
            //Shadow Beyond Spikes
            if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 3)
            {
                ShadowWindHintChest.ForeColor = Available;
                ShadowAfterWindEnemyChest.ForeColor = Available;
                ShadowAfterWindHiddenChest.ForeColor = Available;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 3)
            {
                ShadowWindHintChest.ForeColor = OoLwithBombchus;
                ShadowAfterWindEnemyChest.ForeColor = OoLwithBombchus;
                ShadowAfterWindHiddenChest.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot))
            {

                ShadowWindHintChest.ForeColor = coulddo;
                ShadowAfterWindEnemyChest.ForeColor = coulddo;
                ShadowAfterWindHiddenChest.ForeColor = coulddo;
            }
            else
            {
                ShadowWindHintChest.ForeColor = NotAvailable;
                ShadowAfterWindEnemyChest.ForeColor = NotAvailable;
                ShadowAfterWindHiddenChest.ForeColor = NotAvailable;

            }
            //Shadow spike wall room
            if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.Magic) && Has(i.Dins) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 4)
            {
                ShadowBossKeyChest.ForeColor = Available;
                ShadowSpikeWallsLeftChest.ForeColor = Available;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.Magic) && Has(i.Dins) && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 4)
            {
                ShadowBossKeyChest.ForeColor = OoLwithBombchus;
                ShadowSpikeWallsLeftChest.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.Magic) && Has(i.Dins) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot))
            {
                ShadowBossKeyChest.ForeColor = coulddo;
                ShadowSpikeWallsLeftChest.ForeColor = coulddo;
            }
            else
            {
                ShadowBossKeyChest.ForeColor = NotAvailable;
                ShadowSpikeWallsLeftChest.ForeColor = NotAvailable;
            }
            //Shadow floormaster
            if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 4)
            {
                ShadowInvisibleFloormasterChest.ForeColor = Available;

                tokensAvailable++;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Hookshot) && DungeonInfoPanel.ShadowTemple.CurrentKeys >= 4)
            {
                ShadowInvisibleFloormasterChest.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot))
            {
                ShadowInvisibleFloormasterChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ShadowInvisibleFloormasterChest.ForeColor = NotAvailable;
            }
            //Shadow Bongo 
            if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bomb) && (has_longshot || Has(i.Bow)) && DungeonInfoPanel.ShadowTemple.CurrentKeys == 5 && Has(DungeonInfoPanel.ShadowBossKey))
            {
                ShadowBongoBongoHeart.ForeColor = Available;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bombchu) && (has_longshot || Has(i.Bow)) && DungeonInfoPanel.ShadowTemple.CurrentKeys == 5 && Has(DungeonInfoPanel.ShadowBossKey))
            {
                ShadowBongoBongoHeart.ForeColor = OoLwithBombchus;
            }
            else if (Shadow_Temple_Access && Has(i.ZeldasLullaby) && Has(i.HoverBoots) && Has(i.Bomb) && (has_longshot || Has(i.Bow)))
            {
                ShadowBongoBongoHeart.ForeColor = coulddo;
            }
            else
            {
                ShadowBongoBongoHeart.ForeColor = NotAvailable;
            }
            //Skulltula          
            if (Shadow_Temple_Access && Has(i.HoverBoots) && Has(i.Bomb) && has_longshot)
            {
                tokensAvailable++;
            }
        }
    }
}
