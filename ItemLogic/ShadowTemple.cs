using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_ShadowTemple(ItemPanel i, KeyPanel keys)
        {
            //Shadow Entrance      
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && (Has(i.Hookshot) || Has(i.HoverBoots)))
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
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots))
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
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && i.Bomb.State == 1 && keys.Shadow_SmallKeys.currentKeys >= 1)
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = Available;
                ShadowInvisibleBladesVisibleChest.ForeColor = Available;
                ShadowFallingSpikesLowerChest.ForeColor = Available;
                tokensAvailable += 2;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && keys.Shadow_SmallKeys.currentKeys >= 1)
            {
                ShadowInvisibleBladesInvisibleChest.ForeColor = OoLwithBombchus;
                ShadowInvisibleBladesVisibleChest.ForeColor = OoLwithBombchus;
                ShadowFallingSpikesLowerChest.ForeColor = OoLwithBombchus;               
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && i.Bomb.State == 1)
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
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Strength) && keys.Shadow_SmallKeys.currentKeys >= 1)
            {
                ShadowFallingSpikesUpperChest.ForeColor = Available;
                ShadowFallingSpikesSwitchChest.ForeColor = Available;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Strength) && keys.Shadow_SmallKeys.currentKeys >= 1)
            {
                ShadowFallingSpikesUpperChest.ForeColor = OoLwithBombchus;
                ShadowFallingSpikesSwitchChest.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Strength))
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
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && keys.Shadow_SmallKeys.currentKeys >= 2)
            {
                ShadowInvisibleSpikesChest.ForeColor = Available;
                ShadowFreestandingKey.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && keys.Shadow_SmallKeys.currentKeys >= 2)
            {
                ShadowInvisibleSpikesChest.ForeColor = OoLwithBombchus;
                ShadowFreestandingKey.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb))
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
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot) && keys.Shadow_SmallKeys.currentKeys >= 3)
            {
                ShadowWindHintChest.ForeColor = Available;
                ShadowAfterWindEnemyChest.ForeColor = Available;
                ShadowAfterWindHiddenChest.ForeColor = Available;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Hookshot) && keys.Shadow_SmallKeys.currentKeys >= 3)
            {
                ShadowWindHintChest.ForeColor = OoLwithBombchus;
                ShadowAfterWindEnemyChest.ForeColor = OoLwithBombchus;
                ShadowAfterWindHiddenChest.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot))
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
            //Shadow Beyond Boat
            if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot) && keys.Shadow_SmallKeys.currentKeys >= 4)
            {
                ShadowInvisibleFloormasterChest.ForeColor = Available;
                ShadowSpikeWallsLeftChest.ForeColor = Available;
                ShadowBossKeyChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && Has(i.Hookshot) && keys.Shadow_SmallKeys.currentKeys >= 4)
            {
                ShadowInvisibleFloormasterChest.ForeColor = OoLwithBombchus;
                ShadowSpikeWallsLeftChest.ForeColor = OoLwithBombchus;
                ShadowBossKeyChest.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && Has(i.Hookshot))
            {
                ShadowInvisibleFloormasterChest.ForeColor = coulddo;
                ShadowSpikeWallsLeftChest.ForeColor = coulddo;
                ShadowBossKeyChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                ShadowInvisibleFloormasterChest.ForeColor = NotAvailable;
                ShadowSpikeWallsLeftChest.ForeColor = NotAvailable;
                ShadowBossKeyChest.ForeColor = NotAvailable;
            }
            //Shadow Bongo 
            if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && (has_longshot || Has(i.Bow)) && keys.Shadow_SmallKeys.currentKeys == 5 && Has(i.ShadowBossKey))
            {
                ShadowBongoBongoHeart.ForeColor = Available;
            }
            else if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bombchu) && (has_longshot || Has(i.Bow)) && keys.Shadow_SmallKeys.currentKeys == 5 && Has(i.ShadowBossKey))
            {
                ShadowBongoBongoHeart.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.ZeldasLullaby) && Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && (has_longshot || Has(i.Bow)))
            {
                ShadowBongoBongoHeart.ForeColor = coulddo;
            }
            else
            {
                ShadowBongoBongoHeart.ForeColor = NotAvailable;
            }
            //Skulltula          
            if (Has(i.Dins) && Has(i.Nocturne) && Has(i.Magic) && Has(i.HoverBoots) && Has(i.Bomb) && has_longshot)
            {
                tokensAvailable++;
            }
        }
    }
}
