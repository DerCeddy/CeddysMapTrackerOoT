using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Region_Panel_Check : CheckBox
    {
        public string _name;
        public bool IsBoss;
        public bool State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnValueChanged(null);
            }
        }
        private bool _state;
        public Region_Panel_Check(string name)
        {
            _name = name;
            Text = _name;
            Font = new Font("Arial", 9);
            ForeColor = Color.Red;
            Size = new Size(200, 20);
            AutoSize = true;
            AutoCheck = false;
            MouseDown += (sender, e) => ClickEvent(e);
        }
        public void ClickEvent(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!Checked)
                    {
                        Checked = true;
                        State = true;
                    }
                    else
                    {
                        Checked = false;
                        State = false;
                    }
                    break;                   
            }
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }

    public partial class Maptracker
    {
        public Region_Panel_Check KakAnjuasChild = new("Anju as Child");
        public Region_Panel_Check KakAnjuasAdult = new("Anju as Adult");
        public Region_Panel_Check KakImpasHouseFreestandingPoH = new("Impas House Freestanding PoH");
        public Region_Panel_Check KakWindmillFreestandingPoH = new("Windmill Freestanding PoH");
        public Region_Panel_Check WindmillSong = new("Song from Windmill");
        public Region_Panel_Check KakManonRoof = new("Man on Roof");
        public Region_Panel_Check KakOpenGrottoChest = new("Open Grotto Chest");
        public Region_Panel_Check KakRedeadGrottoChest = new("Redead Grotto Chest");
        public Region_Panel_Check KakShootingGalleryReward = new("Shooting Gallery Reward");
        public Region_Panel_Check KakShiek = new("Shiek at Kakariko");
        public Region_Panel_Check Kak10GoldSkulltulaReward = new("10 Gold Skulltula Reward");
        public Region_Panel_Check Kak20GoldSkulltulaReward = new("20 Gold Skulltula Reward");
        public Region_Panel_Check Kak30GoldSkulltulaReward = new("30 Gold Skulltula Reward");
        public Region_Panel_Check Kak40GoldSkulltulaReward = new("40 Gold Skulltula Reward");
        public Region_Panel_Check Kak50GoldSkulltulaReward = new("50 Gold Skulltula Reward");
        public Region_Panel_Check GraveyardShieldGraveChest = new("Shield Grave Chest");
        public Region_Panel_Check GraveyardHeartPieceGraveChest = new("Heart Piece Grave Chest");
        public Region_Panel_Check GraveyardRoyalFamilysTombChest = new("Royal Familys Tomb Chest");
        public Region_Panel_Check GraveyardFreestandingPoH = new("Freestanding PoH");
        public Region_Panel_Check GraveyardDampeGravediggingTour = new("Dampe Gravedigging Tour");
        public Region_Panel_Check GraveyardDampeRaceHookshotChest = new("Dampe Race Hookshot Chest");
        public Region_Panel_Check GraveyardDampeRaceFreestandingPoH = new("Dampe Race Freestanding PoH");
        public Region_Panel_Check GraveyardComposerSong = new("Composer Song");
        public Region_Panel_Check GCDaruniasJoy = new("Darunias Joy");
        public Region_Panel_Check GCPotFreestandingPoH = new("Pot Freestanding PoH");
        public Region_Panel_Check GCRollingGoronasChild = new("Rolling Goron as Child");
        public Region_Panel_Check GCRollingGoronasAdult = new("Rolling Goron as Adult");
        public Region_Panel_Check GCMazeLeftChest = new("Maze Left Chest");
        public Region_Panel_Check GCMazeCenterChest = new("Maze Center Chest");
        public Region_Panel_Check GCMazeRightChest = new("Maze Right Chest");
        public Region_Panel_Check ToTLACS = new("Light Arrow Cutscene");
        public Region_Panel_Check ToTShiek = new("Song from Shiek");
        public Region_Panel_Check DekuTreeMapChest = new("Map Chest");
        public Region_Panel_Check DekuTreeSlingshotRoomSideChest = new("Slingshot Room Side Chest");
        public Region_Panel_Check DekuTreeSlingshotChest = new("Slingshot Chest");
        public Region_Panel_Check DekuTreeCompassChest = new("Compass Chest");
        public Region_Panel_Check DekuTreeCompassRoomSideChest = new("Compass Room Side Chest");
        public Region_Panel_Check DekuTreeBasementChest = new("Basement Chest");
        public Region_Panel_Check DekuTreeQueenGohmaHeart = new("Queen Gohma Heart") { IsBoss = true };
        public Region_Panel_Check DodongosCavernMapChest = new("Map Chest");
        public Region_Panel_Check DodongosCavernCompassChest = new("Compass Chest");
        public Region_Panel_Check DodongosCavernBombFlowerPlatformChest = new("Bomb Flower Platform Chest");
        public Region_Panel_Check DodongosCavernBombBagChest = new("Bomb Bag Chest");
        public Region_Panel_Check DodongosCavernEndofBridgeChest = new("End of Bridge Chest");
        public Region_Panel_Check DodongosCavernBossRoomChest = new("Boss Room Chest");
        public Region_Panel_Check DodongosCavernKingDodongoHeart = new("King Dodongo Heart") { IsBoss = true };
        public Region_Panel_Check JabuJabusBellyBoomerangChest = new("Boomerang Chest");
        public Region_Panel_Check JabuJabusBellyMapChest = new("Map Chest");
        public Region_Panel_Check JabuJabusBellyCompassChest = new("Compass Chest");
        public Region_Panel_Check JabuJabusBellyBarinadeHeart = new("Barinade Heart") { IsBoss = true };
        public Region_Panel_Check BotWFrontLeftFakeWallChest = new("Front Left Fake Wall Chest");
        public Region_Panel_Check BotWFrontCenterBombableChest = new("Front Center Bombable Chest");
        public Region_Panel_Check BotWBackLeftBombableChest = new("Back Left Bombable Chest");
        public Region_Panel_Check BotWUnderwaterLeftChest = new("Underwater Left Chest");
        public Region_Panel_Check BotWFreestandingKey = new("Freestanding Key");
        public Region_Panel_Check BotWCompassChest = new("Compass Chest");
        public Region_Panel_Check BotWCenterSkulltulaChest = new("Center Skulltula Chest");
        public Region_Panel_Check BotWRightBottomFakeWallChest = new("Right Bottom Fake Wall Chest");
        public Region_Panel_Check BotWFireKeeseChest = new("Fire Keese Chest");
        public Region_Panel_Check BotWLikeLikeChest = new("Like Like Chest");
        public Region_Panel_Check BotWMapChest = new("Map Chest");
        public Region_Panel_Check BotWUnderwaterFrontChest = new("Underwater Front Chest");
        public Region_Panel_Check BotWInvisibleChest = new("Invisible Chest");
        public Region_Panel_Check BotWLensofTruthChest = new("Lens of Truth Chest");
        public Region_Panel_Check ForestFirstRoomChest = new("First Room Chest");
        public Region_Panel_Check ForestFirstStalfosRoomChest = new("First Stalfos Chest");
        public Region_Panel_Check ForestRaisedIslandCourtyardChest = new("Raised Island Courtyard Chest");
        public Region_Panel_Check ForestMapChest = new("Map Chest");
        public Region_Panel_Check ForestWellChest = new("Well Chest");
        public Region_Panel_Check ForestEyeSwitchChest = new("Eye Switch Chest");
        public Region_Panel_Check ForestBossKeyChest = new("Boss Key Chest");
        public Region_Panel_Check ForestFloormasterChest = new("Floormaster Chest");
        public Region_Panel_Check ForestRedPoeChest = new("Red Poe Chest");
        public Region_Panel_Check ForestBowChest = new("Bow Chest");
        public Region_Panel_Check ForestBluePoeChest = new("Blue Poe Chest");
        public Region_Panel_Check ForestFallingCeillingRoomChest = new("Falling Ceiling Room Chest");
        public Region_Panel_Check ForestBasementChest = new("Basement Chest");
        public Region_Panel_Check ForestPhantomGanonHeart = new("Phantom Ganon Heart") { IsBoss = true };
        public Region_Panel_Check FireNearBossChest = new("Near Boss Chest");
        public Region_Panel_Check FireFlareDancerChest = new("Flare Dancer Chest");
        public Region_Panel_Check FireBossKeyChest = new("Boss Key Chest");
        public Region_Panel_Check FireBigLavaRoomLowerDoorChest = new("Big Lava Room Lower Open Door Chest");
        public Region_Panel_Check FireBigLavaRoomBlockedDoorChest = new("Big Lava Room Blocked Door Chest"); 
        public Region_Panel_Check FireBoulderMazeLowerChest = new("Boulder Maze Lower Chest");
        public Region_Panel_Check FireBoulderMazeSideRoomChest = new("Boulder Maze Side Room Chest");
        public Region_Panel_Check FireMapChest = new("Map Chest");
        public Region_Panel_Check FireBoulderMazeShortcutChest = new("Boulder Maze Shortcut Chest");
        public Region_Panel_Check FireBoulderMazeUpperChest = new("Boulder Maze Upper Chest");
        public Region_Panel_Check FireScarecrowChest = new("Scarecrow Chest");
        public Region_Panel_Check FireCompassChest = new("Compass Chest");
        public Region_Panel_Check FireMegatonHammerChest = new("Megaton Hammer Chest");
        public Region_Panel_Check FireHighestGoronChest = new("Highest Goron Chest");
        public Region_Panel_Check FireVolvagiaHeart = new("Volvagia Heart") { IsBoss = true };
        public Region_Panel_Check WaterCompassChest = new("Compass Chest");
        public Region_Panel_Check WaterMapChest = new("Map Chest");
        public Region_Panel_Check WaterCrackedWallChest = new("Cracked Wall Chest");
        public Region_Panel_Check WaterTorchesChest = new("Torches Chest");
        public Region_Panel_Check WaterBossKeyChest = new("Boss Key Chest");
        public Region_Panel_Check WaterCentralPillarChest = new("Central Pillar Chest");
        public Region_Panel_Check WaterCentralBowTargetChest = new("Central Bow Target Chest");
        public Region_Panel_Check WaterLongshotChest = new("Longshot Chest");
        public Region_Panel_Check WaterRiverChest = new("River Chest");
        public Region_Panel_Check WaterDragonChest = new("Dragon Chest");
        public Region_Panel_Check WaterMorphaHeart = new("Morpha Heart") { IsBoss = true };
        public Region_Panel_Check ShadowMapChest = new("Map Chest");
        public Region_Panel_Check ShadowHoverBootsChest = new("Hover Boots Chest");
        public Region_Panel_Check ShadowCompassChest = new("Compass Chest");
        public Region_Panel_Check ShadowEarlySilverRupeeChest = new("Early Silver Rupee Chest");
        public Region_Panel_Check ShadowInvisibleBladesVisibleChest = new("Invisible Blades Visible Chest");
        public Region_Panel_Check ShadowInvisibleBladesInvisibleChest = new("Invisible Blades Invisible Chest");
        public Region_Panel_Check ShadowFallingSpikesLowerChest = new("Falling Spikes Lower Chest");
        public Region_Panel_Check ShadowFallingSpikesUpperChest = new("Falling Spikes Upper Chest");
        public Region_Panel_Check ShadowFallingSpikesSwitchChest = new("Falling Spikes Switch Chest");
        public Region_Panel_Check ShadowInvisibleSpikesChest = new("Invisible Spikes Chest");
        public Region_Panel_Check ShadowFreestandingKey = new("Freestanding Key");
        public Region_Panel_Check ShadowWindHintChest = new("Wind Hint Chest");
        public Region_Panel_Check ShadowAfterWindEnemyChest = new("After Wind Enemy Chest");
        public Region_Panel_Check ShadowAfterWindHiddenChest = new("After Wind Hidden Chest");
        public Region_Panel_Check ShadowSpikeWallsLeftChest = new("Spike Walls Left Chest");
        public Region_Panel_Check ShadowBossKeyChest = new("Boss Key Chest");
        public Region_Panel_Check ShadowInvisibleFloormasterChest = new("Invisible Floormaster Chest");
        public Region_Panel_Check ShadowBongoBongoHeart = new("Bongo Bongo Heart") { IsBoss = true};
        public Region_Panel_Check SpiritChildBridgeChest = new("Child Bridge Chest");
        public Region_Panel_Check SpiritChildEarlyTorchesChest = new("Child Early Torches Chest");
        public Region_Panel_Check SpiritChildClimbNorthChest = new("Child Climb North Chest");
        public Region_Panel_Check SpiritChildClimbEastChest = new("Child Climb East Chest");
        public Region_Panel_Check SpiritMapChest = new("Map Chest");
        public Region_Panel_Check SpiritSunBlockRoomChest = new("Sun Block Room Chest");
        public Region_Panel_Check SpiritSilverGauntletsChest = new("Silver Gauntlets Chest");
        public Region_Panel_Check SpiritCompassChest = new("Compass Chest");
        public Region_Panel_Check SpiritEarlyAdultRightChest = new("Early Adult Right Chest");
        public Region_Panel_Check SpiritFirstMirrorLeftChest = new("First Mirror Left Chest");
        public Region_Panel_Check SpiritFirstMirrorRightChest = new("First Mirror Right Chest");
        public Region_Panel_Check SpiritStatueRoomNortheastChest = new("Statue Room Northeast Chest");
        public Region_Panel_Check SpiritStatueRoomHandChest = new("Statue Room Hand Chest");
        public Region_Panel_Check SpiritNearFourArmosChest = new("Near Four Armos Chest");
        public Region_Panel_Check SpiritHallwayRightInvisibleChest = new("Hallway Right Invisible Chest");
        public Region_Panel_Check SpiritHallwayLeftInvisibleChest = new("Hallway Left Invisible Chest");
        public Region_Panel_Check SpiritMirrorShieldChest = new("Mirror Shield Chest");
        public Region_Panel_Check SpiritBossKeyChest = new("Boss Key Chest");
        public Region_Panel_Check SpiritTopmostChest = new("Topmost Chest");
        public Region_Panel_Check SpiritTwinrovaHeart = new("Twinrova Heart") { IsBoss = true };
        public Region_Panel_Check IceCavernMapChest = new("Map Chest");
        public Region_Panel_Check IceCavernCompassChest = new("Compass Chest");
        public Region_Panel_Check IceCavernIronBootsChest = new("Iron Boots Chest");
        public Region_Panel_Check IceCavernFreestandingPoH = new("Freestanding PoH");
        public Region_Panel_Check IceCavernShiek = new("Song from Shiek");
        public Region_Panel_Check GTGLobbyLeftChest = new("Lobby Left Chest");
        public Region_Panel_Check GTGLobbyRightChest = new("Lobby Right Chest");
        public Region_Panel_Check GTGStalfosChest = new("Stalfos Chest");
        public Region_Panel_Check GTGBeforeHeavyBlockChest = new("Before Heavy Block Chest");
        public Region_Panel_Check GTGHeavyBlockFirstChest = new("Heavy Block First Chest");
        public Region_Panel_Check GTGHeavyBlockSecondChest = new("Heavy Block Second Chest");
        public Region_Panel_Check GTGHeavyBlockThirdChest = new("Heavy Block Third Chest");
        public Region_Panel_Check GTGHeavyBlockFourthChest = new("Heavy Block Fourth Chest");
        public Region_Panel_Check GTGEyeStatueChest = new("Eye Statue Chest");
        public Region_Panel_Check GTGNearScarecrowChest = new("Near Scarecrow Chest");
        public Region_Panel_Check GTGHammerRoomClearChest = new("Hammer Room Clear Chest");
        public Region_Panel_Check GTGHammerRoomSwitchChest = new("Hammer Room Switch Chest");
        public Region_Panel_Check GTGFreestandingKey = new("Freestanding Key");
        public Region_Panel_Check GTGMazeRightCentralChest = new("Maze Right Central Chest");
        public Region_Panel_Check GTGMazeRightSideChest = new("Maze Right Side Chest");
        public Region_Panel_Check GTGUnderwaterSilverRupeeChest = new("Underwater Silver Rupee Chest");
        public Region_Panel_Check GTGBeamosChest = new("Beamos Chest");
        public Region_Panel_Check GTGHiddenCeilingChest = new("Hidden Ceiling Chest");
        public Region_Panel_Check GTGMazePathFirstChest = new("Maze Path First Chest");
        public Region_Panel_Check GTGMazePathSecondChest = new("Maze Path Second Chest");
        public Region_Panel_Check GTGMazePathThirdChest = new("Maze Path Third Chest");
        public Region_Panel_Check GTGMazePathFinalChest = new("Maze Path Final Chest");
        public Region_Panel_Check GanonsCastleForestTrialChest = new("Forest Trial Chest");
        public Region_Panel_Check GanonsCastleWaterTrialLeftChest = new("Water Trial Left Chest");
        public Region_Panel_Check GanonsCastleWaterTrialRightChest = new("Water Trial Right Chest");
        public Region_Panel_Check GanonsCastleShadowTrialFrontChest = new("Shadow Trial Front Chest");
        public Region_Panel_Check GanonsCastleShadowTrialGoldenGauntletsChest = new("Shadow Trial Golden Gauntlets Chest");
        public Region_Panel_Check GanonsCastleLightTrialFirstLeftChest = new("Light Trial First Left Chest");
        public Region_Panel_Check GanonsCastleLightTrialSecondLeftChest = new("Light Trial Second Left Chest");
        public Region_Panel_Check GanonsCastleLightTrialThirdLeftChest = new("Light Trial Third Left Chest");
        public Region_Panel_Check GanonsCastleLightTrialFirstRightChest = new("Light Trial First Right Chest");
        public Region_Panel_Check GanonsCastleLightTrialSecondRightChest = new("Light Trial Second Right Chest");
        public Region_Panel_Check GanonsCastleLightTrialThirdRightChest = new("Light Trial Third Right Chest");
        public Region_Panel_Check GanonsCastleLightTrialInvisibleEnemiesChest = new("Light Trial Invisible Enemies Chest");
        public Region_Panel_Check GanonsCastleLightTrialLullabyChest = new("Light Trial Lullaby Chest");
        public Region_Panel_Check GanonsCastleSpiritTrialCrystalSwitchChest = new("Spirit Trial Crystal Switch Chest");
        public Region_Panel_Check GanonsCastleSpiritTrialInvisibleChest = new("Spirit Trial Invisible Chest");
        public Region_Panel_Check GanonsTowerBossKeyChest = new("Boss Key Chest");
    }
}
