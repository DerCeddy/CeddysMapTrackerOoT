using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public bool Spirit_Temple_Access;
        public void ItemLogic_SpiritTemple(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {
            bool childside_access = false;
            bool adultside_access = false;
            bool childclimb_access = false;
            bool centralchamber_access = false;

            //Childside access
            if (((Has(i.Reqiuem) && Spirit_Button.RegionPanel == Spirit_RegionPanel) || Spirit_Temple_Access) && (Has(i.Slingshot) || Has(i.Boomerang)))
            {
                childside_access = true;
            }
            else
            {
                childside_access = false;
            }
            //Adulutside Access
            if(Spirit_Temple_Access && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)))
            {
                adultside_access = true;
            }
            else
            {
                adultside_access= false;
            }
            //Early Child Checks
            if (childside_access)
            {
                SpiritChildBridgeChest.ForeColor = Available;
                SpiritChildEarlyTorchesChest.ForeColor = Available;
                tokensAvailable++;
            }
            else
            {
                SpiritChildBridgeChest.ForeColor = NotAvailable;
                SpiritChildEarlyTorchesChest.ForeColor = NotAvailable;

            }
            //Child Climb
            if ((childside_access && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && (Has(i.Slingshot) || Has(i.Boomerang))) || (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow))) || (Spirit_Temple_Access && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 1  && (((Has(i.Slingshot) || Has(i.Boomerang)) && (Has(i.Bow) || Has(i.Hookshot))) || i.Bomb.State == 1)))
            {
                SpiritChildClimbNorthChest.ForeColor = Available;
                SpiritChildClimbEastChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if ((childside_access && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && (Has(i.Slingshot) || Has(i.Boomerang))) || (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow))) || (Spirit_Temple_Access && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 1 && Has(i.Bombchu)))
            {
                SpiritChildClimbNorthChest.ForeColor = OoLwithBombchus;
                SpiritChildClimbEastChest.ForeColor = OoLwithBombchus;               
            }
            else if ((childside_access && (Has(i.Slingshot) || Has(i.Boomerang))) || (Spirit_Temple_Access && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow))) || (Spirit_Temple_Access && (((Has(i.Slingshot) || Has(i.Boomerang)) && (Has(i.Bow) || Has(i.Hookshot))) || i.Bomb.State == 1)))
            {
                SpiritChildClimbNorthChest.ForeColor = coulddo;
                SpiritChildClimbEastChest.ForeColor = coulddo;
                tokensAvailable++;
            }
            else
            {
                SpiritChildClimbNorthChest.ForeColor = NotAvailable;
                SpiritChildClimbEastChest.ForeColor = NotAvailable;
            }
            //Map Chest
            if ((childside_access && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && i.Bomb.State == 1) || (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && has_firesource && (Has(i.Hookshot) || Has(i.Bow))) || (Spirit_Temple_Access && Has(i.Bomb) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 1 && has_firesource))
            {
                SpiritMapChest.ForeColor = Available;
                SpiritSunBlockRoomChest.ForeColor = Available;
            }
            else if ((childside_access && (DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 || (Has(i.Dins) && Has(i.Magic) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 1)) && Has(i.Bombchu)) || (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && has_firesource && (Has(i.Hookshot) || Has(i.Bow))))
            {
                SpiritMapChest.ForeColor = OoLwithBombchus;
                SpiritSunBlockRoomChest.ForeColor = OoLwithBombchus;
            }
            else if ((childside_access && i.Bomb.State == 1) || (Spirit_Temple_Access && i.Strength.State >= 2  && has_firesource && (Has(i.Hookshot) || Has(i.Bow))) || (Spirit_Temple_Access && Has(i.Bomb) && has_firesource))
            {
                SpiritMapChest.ForeColor = coulddo;
                SpiritSunBlockRoomChest.ForeColor = coulddo;
            }
            else
            {
                SpiritMapChest.ForeColor = NotAvailable;
                SpiritSunBlockRoomChest.ForeColor = NotAvailable;
            }
            //Silver Gauntlets
            if ((childside_access && i.Bomb.State == 1 && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5) || (Spirit_Temple_Access && i.Strength.State >= 2 && has_longshot && Has(i.Bomb) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3))
            {
                SpiritSilverGauntletsChest.ForeColor = Available;
            }
            else if ((childside_access && (Has(i.Slingshot) || Has(i.Boomerang)) && Has(i.Bombchu) && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5) || (Spirit_Temple_Access && i.Strength.State >= 2 && has_longshot && Has(i.Bombchu) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3))
            {
                SpiritSilverGauntletsChest.ForeColor = OoLwithBombchus;
            }
            else if ((childside_access && (Has(i.Slingshot) || Has(i.Boomerang)) && i.Bomb.State == 1) || (Spirit_Temple_Access && i.Strength.State >= 2 && has_longshot && i.Bomb.State == 1))
            {
                SpiritSilverGauntletsChest.ForeColor = coulddo;
            }
            else
            {
                SpiritSilverGauntletsChest.ForeColor = NotAvailable;
            }
            //Adult Entry
            if (adultside_access)
            {
                SpiritEarlyAdultRightChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bombchu)))
            {
                SpiritEarlyAdultRightChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                SpiritEarlyAdultRightChest.ForeColor = NotAvailable;
            }
            //Adult Compass Chest
            if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby))
            {
                SpiritCompassChest.ForeColor = Available;
            }
            else
            {
                SpiritCompassChest.ForeColor = NotAvailable;
            }
            //Adult Climb
            if (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3)
            {

                SpiritFirstMirrorLeftChest.ForeColor = Available;
                SpiritFirstMirrorRightChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2)
            {

                SpiritFirstMirrorLeftChest.ForeColor = coulddo;
                SpiritFirstMirrorRightChest.ForeColor = coulddo;
            }
            else
            {
                SpiritFirstMirrorLeftChest.ForeColor = NotAvailable;
                SpiritFirstMirrorRightChest.ForeColor = NotAvailable;
            }
            //Adult Centerroom
            if (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3  && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomHandChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomHandChest.ForeColor = coulddo;
            }
            else
            {
                SpiritStatueRoomHandChest.ForeColor = NotAvailable;
            }
            //Adult Statue Northeast Chest
            if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3)
            {
                SpiritStatueRoomNortheastChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomNortheastChest.ForeColor = coulddo;
            }
            else
            {
                SpiritStatueRoomNortheastChest.ForeColor = NotAvailable;
            }
            //Adult beyond Anubis Room
            if (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 4 && i.Bomb.State == 1)
            {
                SpiritHallwayLeftInvisibleChest.ForeColor = Available;
                SpiritHallwayRightInvisibleChest.ForeColor = Available;
                SpiritMirrorShieldChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && i.Bomb.State == 1)
            {
                SpiritHallwayLeftInvisibleChest.ForeColor = coulddo;
                SpiritHallwayRightInvisibleChest.ForeColor = coulddo;
                SpiritMirrorShieldChest.ForeColor = coulddo;
            }
            else
            {
                SpiritHallwayLeftInvisibleChest.ForeColor = NotAvailable;
                SpiritHallwayRightInvisibleChest.ForeColor = NotAvailable;
                SpiritMirrorShieldChest.ForeColor = NotAvailable;
            }
            //Near Four Armors
            if (Spirit_Temple_Access && i.Strength.State >= 2 && i.Bomb.State == 1 && Has(i.MirrorShield) && DungeonInfoPanel.SpiritTemple.CurrentKeys >= 4)
            {
                SpiritNearFourArmosChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && i.Bomb.State == 1 && Has(i.MirrorShield))
            {
                SpiritNearFourArmosChest.ForeColor = coulddo;
            }
            else
            {
                SpiritNearFourArmosChest.ForeColor = NotAvailable;
            }
            //Boss Key Chest
            if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.ZeldasLullaby) && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && Has(i.Hookshot) && Has(i.Bow))
            {
                SpiritBossKeyChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.ZeldasLullaby) && Has(i.Hookshot) && Has(i.Bow))
            {
                SpiritBossKeyChest.ForeColor = coulddo;
            }
            else
            {
                SpiritBossKeyChest.ForeColor = NotAvailable;
            }
            //Topmost Chest
            if (Spirit_Temple_Access && i.Strength.State >= 2 && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && Has(i.MirrorShield) && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Hammer) || Has(i.Bomb)))
            {
                SpiritTopmostChest.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.MirrorShield) && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Hammer) || Has(i.Bomb)))
            {
                SpiritTopmostChest.ForeColor = coulddo;
            }
            else
            {
                SpiritTopmostChest.ForeColor = NotAvailable;
            }
            //Twinrova Heart
            if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.MirrorShield) && Has(DungeonInfoPanel.SpiritBossKey) && DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && Has(i.Hookshot) && Has(i.Bomb))
            {
                SpiritTwinrovaHeart.ForeColor = Available;
            }
            else if (Spirit_Temple_Access && i.Strength.State >= 2 && Has(i.MirrorShield) && Has(i.Hookshot) && Has(i.Bomb))
            {
                SpiritTwinrovaHeart.ForeColor = coulddo;
            }
            else
            {
                SpiritTwinrovaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (Spirit_Temple_Access && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow)) && Has(i.SongOfTime))
            {
                tokensAvailable++;
            }
            if ((DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && Has(i.Boomerang)) || (DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && (Has(i.Hookshot) || Has(i.HoverBoots))))
            {
                tokensAvailable++;
            }
            if ((DungeonInfoPanel.SpiritTemple.CurrentKeys == 5 && Has(i.Boomerang)) || (DungeonInfoPanel.SpiritTemple.CurrentKeys >= 3 && Has(i.Hookshot)))
            {
                tokensAvailable++;
            }
        }
    }
}
