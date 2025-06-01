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
        public void ItemLogic_SpiritTemple(ItemPanel i, KeyPanel keys)
        {
            bool childside_access = false;
            bool adultside_access = false;
            bool childclimb_access = false;
            bool centralchamber_access = false;

            //Childside access
            if (Has(i.Reqiuem) && (Has(i.Slingshot) || Has(i.Boomerang)))
            {
                childside_access = true;
            }
            else
            {
                childside_access = false;
            }
            //Adulutside Access
            if(desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)))
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
            if ((Has(i.Reqiuem) && keys.Spirit_SmallKeys.currentKeys == 5 && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow))) || (desertaccess == 1 && keys.Spirit_SmallKeys.currentKeys >= 1 && (((Has(i.Slingshot) || Has(i.Boomerang)) && (Has(i.Bow) || Has(i.Hookshot))) || i.Bomb.State == 1)))
            {
                SpiritChildClimbNorthChest.ForeColor = Available;
                SpiritChildClimbEastChest.ForeColor = Available;
                tokensAvailable++;
            }
            else if ((Has(i.Reqiuem) && keys.Spirit_SmallKeys.currentKeys == 5 && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow))) || (desertaccess == 1 && keys.Spirit_SmallKeys.currentKeys >= 1 && Has(i.Bombchu)))
            {
                SpiritChildClimbNorthChest.ForeColor = OoLwithBombchus;
                SpiritChildClimbEastChest.ForeColor = OoLwithBombchus;               
            }
            else if ((Has(i.Reqiuem) && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow))) || (desertaccess == 1 && (((Has(i.Slingshot) || Has(i.Boomerang)) && (Has(i.Bow) || Has(i.Hookshot))) || i.Bomb.State == 1)))
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
            if ((Has(i.Reqiuem) && (keys.Spirit_SmallKeys.currentKeys == 5 || (Has(i.Dins) && Has(i.Magic) && keys.Spirit_SmallKeys.currentKeys >= 1)) && i.Bomb.State == 1 && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && has_firesource && (Has(i.Hookshot) || Has(i.Bow))))
            {
                SpiritMapChest.ForeColor = Available;
                SpiritSunBlockRoomChest.ForeColor = Available;
            }
            else if ((Has(i.Reqiuem) && (keys.Spirit_SmallKeys.currentKeys == 5 || (Has(i.Dins) && Has(i.Magic) && keys.Spirit_SmallKeys.currentKeys >= 1)) && Has(i.Bombchu) && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && has_firesource && (Has(i.Hookshot) || Has(i.Bow))))
            {
                SpiritMapChest.ForeColor = OoLwithBombchus;
                SpiritSunBlockRoomChest.ForeColor = OoLwithBombchus;
            }
            else if ((Has(i.Reqiuem) && ((Has(i.Dins) && Has(i.Magic))) && i.Bomb.State == 1 && (Has(i.Slingshot) || Has(i.Boomerang))) || (desertaccess == 1 && i.Strength.State >= 2 && has_firesource && (Has(i.Hookshot) || Has(i.Bow))))
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
            if ((Has(i.Reqiuem) && (Has(i.Slingshot) || Has(i.Boomerang)) && i.Bomb.State == 1 && keys.Spirit_SmallKeys.currentKeys == 5) || (desertaccess == 1 && i.Strength.State >= 2 && has_longshot && i.Bomb.State == 1 && keys.Spirit_SmallKeys.currentKeys >= 3))
            {
                SpiritSilverGauntletsChest.ForeColor = Available;
            }
            else if ((Has(i.Reqiuem) && (Has(i.Slingshot) || Has(i.Boomerang)) && Has(i.Bombchu) && keys.Spirit_SmallKeys.currentKeys == 5) || (desertaccess == 1 && i.Strength.State >= 2 && has_longshot && Has(i.Bombchu) && keys.Spirit_SmallKeys.currentKeys >= 3))
            {
                SpiritSilverGauntletsChest.ForeColor = OoLwithBombchus;
            }
            else if ((Has(i.Reqiuem) && (Has(i.Slingshot) || Has(i.Boomerang)) && i.Bomb.State == 1) || (desertaccess == 1 && i.Strength.State >= 2 && has_longshot && i.Bomb.State == 1))
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
            else if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bombchu)))
            {
                SpiritEarlyAdultRightChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                SpiritEarlyAdultRightChest.ForeColor = NotAvailable;
            }
            //Adult Compass Chest
            if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby))
            {
                SpiritCompassChest.ForeColor = Available;
            }
            else
            {
                SpiritCompassChest.ForeColor = NotAvailable;
            }
            //Adult Climb
            if (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)))
            {

                SpiritFirstMirrorLeftChest.ForeColor = Available;
                SpiritFirstMirrorRightChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)))
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
            if (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 3 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)) && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomHandChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)) && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomHandChest.ForeColor = coulddo;
            }
            else
            {
                SpiritStatueRoomHandChest.ForeColor = NotAvailable;
            }
            //Adult Statue Northeast Chest
            if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby) && keys.Spirit_SmallKeys.currentKeys >= 3)
            {
                SpiritStatueRoomNortheastChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.Hookshot) && Has(i.ZeldasLullaby))
            {
                SpiritStatueRoomNortheastChest.ForeColor = coulddo;
            }
            else
            {
                SpiritStatueRoomNortheastChest.ForeColor = NotAvailable;
            }
            //Adult beyond Anubis Room
            if (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys >= 4 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)) && i.Bomb.State == 1)
            {
                SpiritHallwayLeftInvisibleChest.ForeColor = Available;
                SpiritHallwayRightInvisibleChest.ForeColor = Available;
                SpiritMirrorShieldChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow) || Has(i.Bomb)) && i.Bomb.State == 1)
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
            if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow)) && i.Bomb.State == 1 && Has(i.MirrorShield) && keys.Spirit_SmallKeys.currentKeys >= 4)
            {
                SpiritNearFourArmosChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow)) && i.Bomb.State == 1 && Has(i.MirrorShield))
            {
                SpiritNearFourArmosChest.ForeColor = coulddo;
            }
            else
            {
                SpiritNearFourArmosChest.ForeColor = NotAvailable;
            }
            //Boss Key Chest
            if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.ZeldasLullaby) && keys.Spirit_SmallKeys.currentKeys == 5 && Has(i.Hookshot) && Has(i.Bow) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritBossKeyChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.ZeldasLullaby) && Has(i.Hookshot) && Has(i.Bow) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritBossKeyChest.ForeColor = coulddo;
            }
            else
            {
                SpiritBossKeyChest.ForeColor = NotAvailable;
            }
            //Topmost Chest
            if (desertaccess == 1 && i.Strength.State >= 2 && keys.Spirit_SmallKeys.currentKeys == 5 && Has(i.MirrorShield) && (Has(i.Hookshot) || Has(i.Bow)) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritTopmostChest.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.MirrorShield) && (Has(i.Hookshot) || Has(i.Bow)) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritTopmostChest.ForeColor = coulddo;
            }
            else
            {
                SpiritTopmostChest.ForeColor = NotAvailable;
            }
            //Twinrova Heart
            if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.MirrorShield) && Has(i.SpiritBossKey) && keys.Spirit_SmallKeys.currentKeys == 5 && (Has(i.Hookshot) || Has(i.Bow)) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritTwinrovaHeart.ForeColor = Available;
            }
            else if (desertaccess == 1 && i.Strength.State >= 2 && Has(i.MirrorShield) && (Has(i.Hookshot) || Has(i.Bow)) && ((has_longshot || i.Bomb.State == 1) || ((i.Bomb.State == 1 || (Has(i.Dins) && Has(i.Magic)) || Has(i.Nuts)) && (Has(i.Bow) || Has(i.Hookshot) || Has(i.Hammer)))))
            {
                SpiritTwinrovaHeart.ForeColor = coulddo;
            }
            else
            {
                SpiritTwinrovaHeart.ForeColor = NotAvailable;
            }
            //Skulltula
            if (desertaccess == 1 && i.Strength.State >= 2 && (Has(i.Hookshot) || Has(i.Bow)) && Has(i.SongOfTime))
            {
                tokensAvailable++;
            }
            if ((keys.Spirit_SmallKeys.currentKeys == 5 && Has(i.Boomerang)) || (keys.Spirit_SmallKeys.currentKeys >= 3 && (Has(i.Hookshot) || Has(i.HoverBoots))))
            {
                tokensAvailable++;
            }
            if ((keys.Spirit_SmallKeys.currentKeys == 5 && Has(i.Boomerang)) || (keys.Spirit_SmallKeys.currentKeys >= 3 && Has(i.Hookshot)))
            {
                tokensAvailable++;
            }
        }
    }
}
