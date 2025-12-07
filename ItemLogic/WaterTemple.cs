using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Water_Temple_Access;
        public bool Raise_Water_Level;
        public void ItemLogic_WaterTemple(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {
            //Map Chest
            if (Water_Temple_Access && Has(i.IronBoots) && Raise_Water_Level)
            {
                WaterMapChest.ForeColor = Available;
            }
            else
            {
                WaterMapChest.ForeColor = NotAvailable;
            }
            //Compass Chest
            if (Water_Temple_Access && (Has(i.IronBoots) || Has(i.ZeldasLullaby)) && Has(i.Hookshot))
            {
                WaterCompassChest.ForeColor = Available;
            }
            else
            {
                WaterCompassChest.ForeColor = NotAvailable;
            }
            //Dragon Chest
            if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots)  && (Has(i.Strength) && Has(i.ZeldasLullaby) || (Has(i.Bow) && Has(i.IronBoots) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 && Has(i.SongOfTime))))
            {
                WaterDragonChest.ForeColor = Available;
            }
            else if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots)  && (Has(i.Strength) && Has(i.ZeldasLullaby) || (Has(i.Bow) && Has(i.IronBoots) && Has(i.SongOfTime))))
            {
                WaterDragonChest.ForeColor = coulddo;
            }
            else
            {
                WaterDragonChest.ForeColor = NotAvailable;
            }
            //Torches Chest
            if (Water_Temple_Access && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterTorchesChest.ForeColor = Available;
            }
            else
            {
                WaterTorchesChest.ForeColor = NotAvailable;
            }
            //Cracked Wall
            if (Water_Temple_Access && Raise_Water_Level && Has(i.IronBoots) && Has(i.ZeldasLullaby) && i.Bomb.State == 1 && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)) || (DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 && Has(i.Hookshot))))
            {
                WaterCrackedWallChest.ForeColor = Available;
            }
            else if (Water_Temple_Access && Raise_Water_Level && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bombchu) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)) || (DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 && Has(i.Hookshot))))
            {
                WaterCrackedWallChest.ForeColor = OoLwithBombchus;
            }
            else if (Water_Temple_Access && Raise_Water_Level && Has(i.IronBoots) && Has(i.ZeldasLullaby) && i.Bomb.State == 1 && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)) || Has(i.Hookshot)))
            {
                WaterCrackedWallChest.ForeColor = coulddo;
            }
            else
            {
                WaterCrackedWallChest.ForeColor = NotAvailable;
            }
            //Longshot Chest
            if (Water_Temple_Access && Raise_Water_Level && Has(i.Hookshot) && Has(i.IronBoots) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5)
            {
                WaterLongshotChest.ForeColor = Available;
            }
            else if (Water_Temple_Access && Raise_Water_Level && Has(i.Hookshot) && Has(i.IronBoots))
            {
                WaterLongshotChest.ForeColor = coulddo;
            }
            else
            {
                WaterLongshotChest.ForeColor = NotAvailable;
            }
            //Central Bow Target Chest
            if (Water_Temple_Access && Has(i.IronBoots) && Has(i.Strength) && Has(i.ZeldasLullaby) && Has(i.Bow) && (Has(i.HoverBoots) || has_longshot))
            {
                WaterCentralBowTargetChest.ForeColor = Available;
            }
            else
            {
                WaterCentralBowTargetChest.ForeColor = NotAvailable;
            }
            //Central Pillar
            if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (Has(i.ZoraTunic) || (i.Wallet.State == 2 && (Has(i.RutoLetter) && (Has(i.Bomb) ||Has(i.Scales)) || rainbowbridge == true && has_bottle))) && (DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 || Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterCentralPillarChest.ForeColor = Available;
            }
            else if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.ZoraTunic) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterCentralPillarChest.ForeColor = coulddo;
            }
            else
            {
                WaterCentralPillarChest.ForeColor = NotAvailable;
            }
            //Boss Key
            if (Water_Temple_Access && has_longshot && Has(i.IronBoots) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 && (Has(i.HoverBoots) || (Has(i.Bomb) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Water_Temple_Access && has_longshot && Has(i.IronBoots) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5 && (Has(i.HoverBoots) || (Has(i.Bombchu) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = OoLwithBombchus;
            }
            else if (Water_Temple_Access && has_longshot && Has(i.IronBoots) && (Has(i.HoverBoots) || (Has(i.Bomb) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                WaterBossKeyChest.ForeColor = NotAvailable;
            }
            //River Chest
            if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots) &&  Has(i.Bow) && Has(i.SongOfTime) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5)
            {
                WaterRiverChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots) && Has(i.Bow) && Has(i.SongOfTime))
            {
                WaterRiverChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                WaterRiverChest.ForeColor = NotAvailable;
            }
            //Morpha Heart
            if (Water_Temple_Access && has_longshot && Has(DungeonInfoPanel.WaterBossKey))
            {
                WaterMorphaHeart.ForeColor = Available;
            }
            else if (Water_Temple_Access && has_longshot)
            {
                WaterMorphaHeart.ForeColor = coulddo;
            }
            else
            {
                WaterMorphaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (Water_Temple_Access && has_longshot && Has(i.IronBoots) && DungeonInfoPanel.WaterTemple.CurrentKeys >= 5)
            {
                tokensAvailable++;
            }
            if (Water_Temple_Access && has_longshot && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.ZoraTunic) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                tokensAvailable++;
            }
            if (Water_Temple_Access && Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
