using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
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
        Region_Panel_Check KakAnjuasChild = new("Anju as Child");
        Region_Panel_Check KakAnjuasAdult = new("Anju as Adult");
        Region_Panel_Check KakImpasHouseFreestandingPoH = new("Impas House Freestanding PoH");
        Region_Panel_Check KakWindmillFreestandingPoH = new("Windmill Freestanding PoH");
        Region_Panel_Check WindmillSong = new("Song from Windmill");
        Region_Panel_Check KakManonRoof = new("Man on Roof");
        Region_Panel_Check KakOpenGrottoChest = new("Open Grotto Chest");
        Region_Panel_Check KakRedeadGrottoChest = new("Redead Grotto Chest");
        Region_Panel_Check KakShootingGalleryReward = new("Shooting Gallery Reward");
        Region_Panel_Check KakShiek = new("Shiek at Kakariko");
        Region_Panel_Check Kak10GoldSkulltulaReward = new("10 Gold Skulltula Reward");
        Region_Panel_Check Kak20GoldSkulltulaReward = new("20 Gold Skulltula Reward");
        Region_Panel_Check Kak30GoldSkulltulaReward = new("30 Gold Skulltula Reward");
        Region_Panel_Check Kak40GoldSkulltulaReward = new("40 Gold Skulltula Reward");
        Region_Panel_Check Kak50GoldSkulltulaReward = new("50 Gold Skulltula Reward");
        Region_Panel_Check GraveyardShieldGraveChest = new("Shield Grave Chest");
        Region_Panel_Check GraveyardHeartPieceGraveChest = new("Heart Piece Grave Chest");
        Region_Panel_Check GraveyardRoyalFamilysTombChest = new("Royal Familys Tomb Chest");
        Region_Panel_Check GraveyardFreestandingPoH = new("Freestanding PoH");
        Region_Panel_Check GraveyardDampeGravediggingTour = new("Dampe Gravedigging Tour");
        Region_Panel_Check GraveyardDampeRaceHookshotChest = new("Dampe Race Hookshot Chest");
        Region_Panel_Check GraveyardDampeRaceFreestandingPoH = new("Dampe Race Freestanding PoH");
        Region_Panel_Check GraveyardComposerSong = new("Composer Song");
        Region_Panel_Check GCDaruniasJoy = new("Darunias Joy");
        Region_Panel_Check GCPotFreestandingPoH = new("Pot Freestanding PoH");
        Region_Panel_Check GCRollingGoronasChild = new("Rolling Goron as Child");
        Region_Panel_Check GCRollingGoronasAdult = new("Rolling Goron as Adult");
        Region_Panel_Check GCMazeLeftChest = new("Maze Left Chest");
        Region_Panel_Check GCMazeCenterChest = new("Maze Center Chest");
        Region_Panel_Check GCMazeRightChest = new("Maze Right Chest");
        Region_Panel_Check DekuTreeMapChest = new("Map Chest");
        Region_Panel_Check DekuTreeSlingshotRoomSideChest = new("Slingshot Room Side Chest");
        Region_Panel_Check DekuTreeSlingshotChest = new("Slingshot Chest");
        Region_Panel_Check DekuTreeCompassChest = new("Compass Chest");
        Region_Panel_Check DekuTreeCompassRoomSideChest = new("Compass Room Side Chest");
        Region_Panel_Check DekuTreeBasementChest = new("Basement Chest");
        Region_Panel_Check DekuTreeQueenGohmaHeart = new("Queen Gohma Heart");
        Region_Panel_Check DodongosCavernMapChest = new("Map Chest");
        Region_Panel_Check DodongosCavernCompassChest = new("Compass Chest");
        Region_Panel_Check DodongosCavernBombFlowerPlatformChest = new("Bomb Flower Platform Chest");
        Region_Panel_Check DodongosCavernBombBagChest = new("Bomb Bag Chest");
        Region_Panel_Check DodongosCavernEndofBridgeChest = new("End of Bridge Chest");
        Region_Panel_Check DodongosCavernBossRoomChest = new("Boss Room Chest");
        Region_Panel_Check DodongosCavernKingDodongoHeart = new("King Dodongo Heart");
        Region_Panel_Check JabuJabusBellyBoomerangChest = new("Boomerang Chest");
        Region_Panel_Check JabuJabusBellyMapChest = new("Map Chest");
        Region_Panel_Check JabuJabusBellyCompassChest = new("Compass Chest");
        Region_Panel_Check JabuJabusBellyBarinadeHeart = new("Barinade Heart");
        Region_Panel_Check BotWFrontLeftFakeWallChest = new("Front Left Fake Wall Chest");
        Region_Panel_Check BotWFrontCenterBombableChest = new("Front Center Bombable Chest");
        Region_Panel_Check BotWBackLeftBombableChest = new("Back Left Bombable Chest");
        Region_Panel_Check BotWUnderwaterLeftChest = new("Underwater Left Chest");
        Region_Panel_Check BotWFreestandingKey = new("Freestanding Key");
        Region_Panel_Check BotWCompassChest = new("Compass Chest");
        Region_Panel_Check BotWCenterSkulltulaChest = new("Center Skulltula Chest");
        Region_Panel_Check BotWRightBottomFakeWallChest = new("Right Bottom Fake Wall Chest");
        Region_Panel_Check BotWFireKeeseChest = new("Fire Keese Chest");
        Region_Panel_Check BotWLikeLikeChest = new("Like Like Chest");
        Region_Panel_Check BotWMapChest = new("Map Chest");
        Region_Panel_Check BotWUnderwaterFrontChest = new("Underwater Front Chest");
        Region_Panel_Check BotWInvisibleChest = new("Invisible Chest");
        Region_Panel_Check BotWLensofTruthChest = new("Lens of Truth Chest");
        Region_Panel_Check ForestFirstRoomChest = new("First Room Chest");
        Region_Panel_Check ForestFirstStalfosRoomChest = new("First Stalfos Chest");
        Region_Panel_Check ForestRaisedIslandCourtyardChest = new("Raised Island Courtyard Chest");
        Region_Panel_Check ForestMapChest = new("Map Chest");
        Region_Panel_Check ForestWellChest = new("Well Chest");
        Region_Panel_Check ForestEyeSwitchChest = new("Eye Switch Chest");
        Region_Panel_Check ForestBossKeyChest = new("Boss Key Chest");
        Region_Panel_Check ForestFloormasterChest = new("Floormaster Chest");
        Region_Panel_Check ForestRedPoeChest = new("Red Poe Chest");
        Region_Panel_Check ForestBowChest = new("Bow Chest");
        Region_Panel_Check ForestBluePoeChest = new("Blue Poe Chest");
        Region_Panel_Check ForestFallingCeillingRoomChest = new("Falling Ceiling Room Chest");
        Region_Panel_Check ForestBasementChest = new("Basement Chest");
        Region_Panel_Check ForestPhantomGanonHeart = new("Phantom Ganon Heart");
        Region_Panel_Check FireNearBossChest = new("Near Boss Chest");
        Region_Panel_Check FireFlareDancerChest = new("Flare Dancer Chest");
        Region_Panel_Check FireBossKeyChest = new("Boss Key Chest");
        Region_Panel_Check FireBigLavaRoomLowerDoorChest = new("Big Lava Room Lower Open Door Chest");
        Region_Panel_Check FireBigLavaRoomBlockedDoorChest = new("Big Lava Room Blocked Door Chest"); 
        Region_Panel_Check FireBoulderMazeLowerChest = new("Boulder Maze Lower Chest");
        Region_Panel_Check FireBoulderMazeSideRoomChest = new("Boulder Maze Side Room Chest");
        Region_Panel_Check FireMapChest = new("Map Chest");
        Region_Panel_Check FireBoulderMazeShortcutChest = new("Boulder Maze Shortcut Chest");
        Region_Panel_Check FireBoulderMazeUpperChest = new("Boulder Maze Upper Chest");
        Region_Panel_Check FireScarecrowChest = new("Scarecrow Chest");
        Region_Panel_Check FireCompassChest = new("Compass Chest");
        Region_Panel_Check FireMegatonHammerChest = new("Megaton Hammer Chest");
        Region_Panel_Check FireHighestGoronChest = new("Highest Goron Chest");
        Region_Panel_Check FireVolvagiaHeart = new("Volvagia Heart");
        Region_Panel_Check WaterCompassChest = new("Compass Chest");
        Region_Panel_Check WaterMapChest = new("Map Chest");
        Region_Panel_Check WaterCrackedWallChest = new("Cracked Wall Chest");
        Region_Panel_Check WaterTorchesChest = new("Torches Chest");
        Region_Panel_Check WaterBossKeyChest = new("Boss Key Chest");
        Region_Panel_Check WaterCentralPillarChest = new("Central Pillar Chest");
        Region_Panel_Check WaterCentralBowTargetChest = new("Central Bow Target Chest");
        Region_Panel_Check WaterLongshotChest = new("Longshot Chest");
        Region_Panel_Check WaterRiverChest = new("River Chest");
        Region_Panel_Check WaterDragonChest = new("Dragon Chest");
        Region_Panel_Check WaterMorphaHeart = new("Morpha Heart");
        Region_Panel_Check ShadowMapChest = new("Map Chest");
        Region_Panel_Check ShadowHoverBootsChest = new("Hover Boots Chest");
        Region_Panel_Check ShadowCompassChest = new("Compass Chest");
        Region_Panel_Check ShadowEarlySilverRupeeChest = new("Early Silver Rupee Chest");
        Region_Panel_Check ShadowInvisibleBladesVisibleChest = new("Invisible Blades Visible Chest");
        Region_Panel_Check ShadowInvisibleBladesInvisibleChest = new("Invisible Blades Invisible Chest");
        Region_Panel_Check ShadowFallingSpikesLowerChest = new("Falling Spikes Lower Chest");
        Region_Panel_Check ShadowFallingSpikesUpperChest = new("Falling Spikes Upper Chest");
        Region_Panel_Check ShadowFallingSpikesSwitchChest = new("Falling Spikes Switch Chest");
        Region_Panel_Check ShadowInvisibleSpikesChest = new("Invisible Spikes Chest");
        Region_Panel_Check ShadowFreestandingKey = new("Freestanding Key");
        Region_Panel_Check ShadowWindHintChest = new("Wind Hint Chest");
        Region_Panel_Check ShadowAfterWindEnemyChest = new("After Wind Enemy Chest");
        Region_Panel_Check ShadowAfterWindHiddenChest = new("After Wind Hidden Chest");
        Region_Panel_Check ShadowSpikeWallsLeftChest = new("Spike Walls Left Chest");
        Region_Panel_Check ShadowBossKeyChest = new("Boss Key Chest");
        Region_Panel_Check ShadowInvisibleFloormasterChest = new("Invisible Floormaster Chest");
        Region_Panel_Check ShadowBongoBongoHeart = new("Bongo Bongo Heart");
        Region_Panel_Check SpiritChildBridgeChest = new("Child Bridge Chest");
        Region_Panel_Check SpiritChildEarlyTorchesChest = new("Child Early Torches Chest");
        Region_Panel_Check SpiritChildClimbNorthChest = new("Child Climb North Chest");
        Region_Panel_Check SpiritChildClimbEastChest = new("Child Climb East Chest");
        Region_Panel_Check SpiritMapChest = new("Map Chest");
        Region_Panel_Check SpiritSunBlockRoomChest = new("Sun Block Room Chest");
        Region_Panel_Check SpiritSilverGauntletsChest = new("Silver Gauntlets Chest");
        Region_Panel_Check SpiritCompassChest = new("Compass Chest");
        Region_Panel_Check SpiritEarlyAdultRightChest = new("Early Adult Right Chest");
        Region_Panel_Check SpiritFirstMirrorLeftChest = new("First Mirror Left Chest");
        Region_Panel_Check SpiritFirstMirrorRightChest = new("First Mirror Right Chest");
        Region_Panel_Check SpiritStatueRoomNortheastChest = new("Statue Room Northeast Chest");
        Region_Panel_Check SpiritStatueRoomHandChest = new("Statue Room Hand Chest");
        Region_Panel_Check SpiritNearFourArmosChest = new("Near Four Armos Chest");
        Region_Panel_Check SpiritHallwayRightInvisibleChest = new("Hallway Right Invisible Chest");
        Region_Panel_Check SpiritHallwayLeftInvisibleChest = new("Hallway Left Invisible Chest");
        Region_Panel_Check SpiritMirrorShieldChest = new("Mirror Shield Chest");
        Region_Panel_Check SpiritBossKeyChest = new("Boss Key Chest");
        Region_Panel_Check SpiritTopmostChest = new("Topmost Chest");
        Region_Panel_Check SpiritTwinrovaHeart = new("Twinrova Heart") { IsBoss = true };
        Region_Panel_Check IceCavernMapChest = new("Map Chest");
        Region_Panel_Check IceCavernCompassChest = new("Compass Chest");
        Region_Panel_Check IceCavernIronBootsChest = new("Iron Boots Chest");
        Region_Panel_Check IceCavernFreestandingPoH = new("Freestanding PoH");
        Region_Panel_Check IceCavernShiek = new("Shiek");
        Region_Panel_Check GTGLobbyLeftChest = new("Lobby Left Chest");
        Region_Panel_Check GTGLobbyRightChest = new("Lobby Right Chest");
        Region_Panel_Check GTGStalfosChest = new("Stalfos Chest");
        Region_Panel_Check GTGBeforeHeavyBlockChest = new("Before Heavy Block Chest");
        Region_Panel_Check GTGHeavyBlockFirstChest = new("Heavy Block First Chest");
        Region_Panel_Check GTGHeavyBlockSecondChest = new("Heavy Block Second Chest");
        Region_Panel_Check GTGHeavyBlockThirdChest = new("Heavy Block Third Chest");
        Region_Panel_Check GTGHeavyBlockFourthChest = new("Heavy Block Fourth Chest");
        Region_Panel_Check GTGEyeStatueChest = new("Eye Statue Chest");
        Region_Panel_Check GTGNearScarecrowChest = new("Near Scarecrow Chest");
        Region_Panel_Check GTGHammerRoomClearChest = new("Hammer Room Clear Chest");
        Region_Panel_Check GTGHammerRoomSwitchChest = new("Hammer Room Switch Chest");
        Region_Panel_Check GTGFreestandingKey = new("Freestanding Key");
        Region_Panel_Check GTGMazeRightCentralChest = new("Maze Right Central Chest");
        Region_Panel_Check GTGMazeRightSideChest = new("Maze Right Side Chest");
        Region_Panel_Check GTGUnderwaterSilverRupeeChest = new("Underwater Silver Rupee Chest");
        Region_Panel_Check GTGBeamosChest = new("Beamos Chest");
        Region_Panel_Check GTGHiddenCeilingChest = new("Hidden Ceiling Chest");
        Region_Panel_Check GTGMazePathFirstChest = new("Maze Path First Chest");
        Region_Panel_Check GTGMazePathSecondChest = new("Maze Path Second Chest");
        Region_Panel_Check GTGMazePathThirdChest = new("Maze Path Third Chest");
        Region_Panel_Check GTGMazePathFinalChest = new("Maze Path Final Chest");
        Region_Panel_Check GanonsCastleForestTrialChest = new("Forest Trial Chest");
        Region_Panel_Check GanonsCastleWaterTrialLeftChest = new("Water Trial Left Chest");
        Region_Panel_Check GanonsCastleWaterTrialRightChest = new("Water Trial Right Chest");
        Region_Panel_Check GanonsCastleShadowTrialFrontChest = new("Shadow Trial Front Chest");
        Region_Panel_Check GanonsCastleShadowTrialGoldenGauntletsChest = new("Shadow Trial Golden Gauntlets Chest");
        Region_Panel_Check GanonsCastleLightTrialFirstLeftChest = new("Light Trial First Left Chest");
        Region_Panel_Check GanonsCastleLightTrialSecondLeftChest = new("Light Trial Second Left Chest");
        Region_Panel_Check GanonsCastleLightTrialThirdLeftChest = new("Light Trial Third Left Chest");
        Region_Panel_Check GanonsCastleLightTrialFirstRightChest = new("Light Trial First Right Chest");
        Region_Panel_Check GanonsCastleLightTrialSecondRightChest = new("Light Trial Second Right Chest");
        Region_Panel_Check GanonsCastleLightTrialThirdRightChest = new("Light Trial Third Right Chest");
        Region_Panel_Check GanonsCastleLightTrialInvisibleEnemiesChest = new("Light Trial Invisible Enemies Chest");
        Region_Panel_Check GanonsCastleLightTrialLullabyChest = new("Light Trial Lullaby Chest");
        Region_Panel_Check GanonsCastleSpiritTrialCrystalSwitchChest = new("Spirit Trial Crystal Switch Chest");
        Region_Panel_Check GanonsCastleSpiritTrialInvisibleChest = new("Spirit Trial Invisible Chest");
        Region_Panel_Check GanonsTowerBossKeyChest = new("Boss Key Chest");
    }
}
