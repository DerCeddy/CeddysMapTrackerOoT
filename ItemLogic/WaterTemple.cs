using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_WaterTemple(ItemPanel i, KeyPanel keys)
        {
            //Entrance Chests
            if (Has(i.Hookshot) && Has(i.IronBoots))
            {
                WaterMapChest.ForeColor = Available;
                WaterCompassChest.ForeColor = Available;
            }
            else
            {
                WaterMapChest.ForeColor = NotAvailable;
                WaterCompassChest.ForeColor = NotAvailable;
            }
            //Dragon Chest
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (Has(i.Strength) || (Has(i.Bow) && Has(i.IronBoots) && keys.Water_SmallKeys.currentKeys >= 5 && Has(i.SongOfTime))))
            {
                WaterDragonChest.ForeColor = Available;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (Has(i.Strength) || (Has(i.Bow) && Has(i.IronBoots) && Has(i.SongOfTime))))
            {
                WaterDragonChest.ForeColor = coulddo;
            }
            else
            {
                WaterDragonChest.ForeColor = NotAvailable;
            }
            //Torches Chest
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterTorchesChest.ForeColor = Available;
            }
            else
            {
                WaterTorchesChest.ForeColor = NotAvailable;
            }
            //Cracked Wall
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && i.Bomb.State == 1 && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)) || keys.Water_SmallKeys.currentKeys >= 5))
            {
                WaterCrackedWallChest.ForeColor = Available;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bombchu) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)) || keys.Water_SmallKeys.currentKeys >= 5))
            {
                WaterCrackedWallChest.ForeColor = OoLwithBombchus;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && i.Bomb.State == 1 && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterCrackedWallChest.ForeColor = coulddo;
            }
            else
            {
                WaterCrackedWallChest.ForeColor = NotAvailable;
            }
            //Longshot Chest
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && keys.Water_SmallKeys.currentKeys >= 5)
            {
                WaterLongshotChest.ForeColor = Available;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby))
            {
                WaterLongshotChest.ForeColor = coulddo;
            }
            else
            {
                WaterLongshotChest.ForeColor = NotAvailable;
            }
            //Central Bow Target Chest
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bow) && (Has(i.HoverBoots) || has_longshot))
            {
                WaterCentralBowTargetChest.ForeColor = Available;
            }
            else
            {
                WaterCentralBowTargetChest.ForeColor = NotAvailable;
            }
            //Central Pillar
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.ZoraTunic) && (keys.Water_SmallKeys.currentKeys >= 5 || (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic)))))
            {
                WaterCentralPillarChest.ForeColor = Available;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.ZoraTunic) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                WaterCentralPillarChest.ForeColor = coulddo;
            }
            else
            {
                WaterCentralPillarChest.ForeColor = NotAvailable;
            }
            //Boss Key
            if (has_longshot && Has(i.IronBoots) && keys.Water_SmallKeys.currentKeys >= 5 && (Has(i.HoverBoots) || (Has(i.Bomb) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (has_longshot && Has(i.IronBoots) && keys.Water_SmallKeys.currentKeys >= 5 && (Has(i.HoverBoots) || (Has(i.Bombchu) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = OoLwithBombchus;
            }
            else if (has_longshot && Has(i.IronBoots) && (Has(i.HoverBoots) || (Has(i.Bomb) && Has(i.Strength))))
            {
                WaterBossKeyChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                WaterBossKeyChest.ForeColor = NotAvailable;
            }
            //River Chest
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bow) && Has(i.SongOfTime) && keys.Water_SmallKeys.currentKeys >= 5)
            {
                WaterRiverChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bow) && Has(i.SongOfTime))
            {
                WaterRiverChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                WaterRiverChest.ForeColor = NotAvailable;
            }
            //Morpha Heart
            if (has_longshot && Has(i.IronBoots) && Has(i.WaterBossKey))
            {
                WaterMorphaHeart.ForeColor = Available;
            }
            else if (has_longshot && Has(i.IronBoots))
            {
                WaterMorphaHeart.ForeColor = coulddo;
            }
            else
            {
                WaterMorphaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (has_longshot && Has(i.IronBoots) && keys.Water_SmallKeys.currentKeys >= 5)
            {
                tokensAvailable++;
            }
            if (has_longshot && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.ZoraTunic) && (Has(i.Bow) || (Has(i.Dins) && Has(i.Magic))))
            {
                tokensAvailable++;
            }
            if (Has(i.Hookshot) && Has(i.IronBoots) && Has(i.ZeldasLullaby) && Has(i.Bomb))
            {
                tokensAvailable++;
            }
        }
    }
}
