using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Newtonsoft.Json;

namespace CeddyMapTracker
{
    public partial class Maptracker : UserControl
    {
        public List<Region> DenseRegions;
        public List<OverworldRegions> OverworldRegions;
        public List<int> SmallKeys = [];
        public OverworldRegions LLR = new();
        public OverworldRegions Wasteland = new();
        public OverworldRegions Colossus = new();
        public OverworldRegions GerudoFortress = new();
        public OverworldRegions GerudoValley = new();
        public OverworldRegions HyruleField = new();
        public OverworldRegions LakeHylia = new();
        public OverworldRegions KokiriForest = new();
        public OverworldRegions LostWoods = new();
        public OverworldRegions SFM = new();
        public OverworldRegions ZoraRiver = new();
        public OverworldRegions ZoraDomain = new();
        public OverworldRegions ZoraFountain = new();
        public OverworldRegions DMT = new();
        public OverworldRegions DMC = new();       
        public OverworldRegions HC = new();
        public OverworldRegions OGC = new();
        public OverworldRegions Market = new();
        public List<Region_Panel_Check> ForestTemple_Check_List;
        public List<Region_Panel_Check> Kakariko_Check_List;
        public List<Region_Panel_Check> Graveyard_Check_List;
        public List<Region_Panel_Check> ToT_Check_List;
        public List<Region_Panel_Check> ShadowTemple_Check_List;
        public List<Region_Panel_Check> FireTemple_Check_List;
        public List<Region_Panel_Check> WaterTemple_Check_List;
        public List<Region_Panel_Check> SpiritTemple_Check_List;
        public List<Region_Panel_Check> GTG_Check_List;
        public List<Region_Panel_Check> DekuTree_Check_List;
        public List<Region_Panel_Check> DodongosCavern_Check_List;
        public List<Region_Panel_Check> JabuJabu_Check_List;
        public List<Region_Panel_Check> GanonsCastle_Check_List;
        public List<Region_Panel_Check> IceCavern_Check_List;
        public List<Region_Panel_Check> GoronCity_Check_List;
        public List<Region_Panel_Check> BotW_Check_List;
        public List<ShopPanelCheck> KakarikoShops = [];
        public List<ShopPanelCheck> GoronShop = [];
        public bool ExpensiveMerchantShuffle;
        public bool ShopShuffle;
        public int UpdateStats
        {
            get
            {
                return _updatestats;
            }
            set
            {
                _updatestats = value;
                OnValueChanged(null);
            }
        }
        private int _updatestats;
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
        public class Settings
        {
            [JsonProperty("CheckName")]
            public required CheckName checkname;
            [JsonProperty("Item")]
            public required Item item;
        }
        public class CheckName
        {
            public string? WastelandChest;
            public string? WastelandSalesman;
            public string? ColossusShiek;
            public string? ColossusPoH;
            public string? ColossusGreatFairy;
            public string? GFChest;
            public string? HBA;
            public string? GVWaterFallPoH;
            public string? GVCratePoH;
            public string? GVChest;
            public string? LHLabDive;
            public string? LHFreestandingPoH;
            public string? LHUnderwaterItem;
            public string? LHChildFishing;
            public string? LHAdultFishing;
            public string? LHShootTheSun;
            public string? HFTektikeGrottoPoH;
            public string? HFNearMarketGrottoChest;
            public string? HFOoT;
            public string? HFSoutheastGrottoChest;
            public string? HFOpenGrottoChest;
            public string? HFSalesman;
            public string? MarketShootingGalleryReward;
            public string? MarketRichard;
            public string? MarketTreasureChestGame;
            public string? MarketBigPoes;
            public string? MarketBombchuBowling;
            public string? MarketBazaar;
            public string? MarketPotionShop;
            public string? MarketBombchuShop;
            public string? ToTLACS;
            public string? ToTShiek;
            public string? HCGreatFairy;
            public string? OGCGreatFairy;
            public string? DMTPoH;
            public string? DMTChest;
            public string? DMTStormsGrotto;
            public string? DMTGreatFairy;
            public string? DMTBiggoron;
            public string? DMCWallPoH;
            public string? DMCUpperGrotto;
            public string? DMCShiek;
            public string? DMCVolcanoPoH;
            public string? DMCGreatFairy;
            public string? ZROpenGrotto;
            public string? ZRNearGrottoPoH;
            public string? ZRPoHNearDomain;
            public string? ZRFrogsStorms;
            public string? ZRFrogsGame;
            public string? ZDChest;
            public string? ZRDivingGame;
            public string? ZDShop;
            public string? ZDKingZora;
            public string? ZFGreatFairy;
            public string? ZFFreestandingPoH;
            public string? ZFBottomPoH;
            public string? KFMidos;
            public string? KFKokiriSwordChest;
            public string? KFStormGrottoChest;
            public string? KFShop;
            public string? LWScrubNearBridge;
            public string? LWSkullKid;
            public string? LWOcarinaGame;
            public string? LWTarget;
            public string? LWNearShortcutGrottoChest;
            public string? LWSkullMask;
            public string? LWScrubGrottoFront;
            public string? SFMWolfosGrotto;
            public string? SFMSaria;
            public string? SFMShiek;
            public string? LLRTalon;
            public string? LLRMalon;
            public string? LLRPoH;
        }
        public Maptracker(WOTHPanel wothPanel, Point location, Stats stats)
        {
            InitializeComponent();
            Location = location;
            
            //Assign checks to check list
            ForestTemple_Check_List = [ForestFirstRoomChest, ForestFirstStalfosRoomChest, ForestRaisedIslandCourtyardChest, ForestMapChest, ForestWellChest, ForestEyeSwitchChest, ForestBossKeyChest, ForestFloormasterChest, ForestRedPoeChest, ForestBowChest, ForestBluePoeChest, ForestFallingCeillingRoomChest, ForestBasementChest, ForestPhantomGanonHeart];
            Kakariko_Check_List = [KakAnjuasChild, KakAnjuasAdult, KakImpasHouseFreestandingPoH, KakWindmillFreestandingPoH, WindmillSong, KakManonRoof, KakOpenGrottoChest, KakRedeadGrottoChest, KakShootingGalleryReward, KakShiek, Kak10GoldSkulltulaReward, Kak20GoldSkulltulaReward, Kak30GoldSkulltulaReward, Kak40GoldSkulltulaReward, Kak50GoldSkulltulaReward];
            Graveyard_Check_List = [GraveyardShieldGraveChest, GraveyardHeartPieceGraveChest, GraveyardRoyalFamilysTombChest, GraveyardFreestandingPoH, GraveyardDampeGravediggingTour, GraveyardDampeRaceHookshotChest, GraveyardDampeRaceFreestandingPoH, GraveyardComposerSong];
            ToT_Check_List = [ToTLACS, ToTShiek];
            ShadowTemple_Check_List = [ShadowMapChest, ShadowHoverBootsChest, ShadowCompassChest, ShadowEarlySilverRupeeChest, ShadowInvisibleBladesVisibleChest, ShadowInvisibleBladesInvisibleChest, ShadowFallingSpikesLowerChest, ShadowFallingSpikesUpperChest, ShadowFallingSpikesSwitchChest, ShadowInvisibleSpikesChest, ShadowFreestandingKey, ShadowWindHintChest, ShadowAfterWindEnemyChest, ShadowAfterWindHiddenChest, ShadowSpikeWallsLeftChest, ShadowBossKeyChest, ShadowInvisibleFloormasterChest, ShadowBongoBongoHeart];
            FireTemple_Check_List = [FireNearBossChest, FireFlareDancerChest, FireBossKeyChest, FireBigLavaRoomLowerDoorChest, FireBigLavaRoomBlockedDoorChest, FireBoulderMazeLowerChest, FireBoulderMazeSideRoomChest, FireMapChest, FireBoulderMazeShortcutChest, FireBoulderMazeUpperChest, FireScarecrowChest, FireCompassChest, FireMegatonHammerChest, FireHighestGoronChest, FireVolvagiaHeart];
            WaterTemple_Check_List = [WaterCompassChest, WaterMapChest, WaterCrackedWallChest, WaterTorchesChest, WaterBossKeyChest, WaterCentralPillarChest, WaterCentralBowTargetChest, WaterLongshotChest, WaterRiverChest, WaterDragonChest, WaterMorphaHeart];
            SpiritTemple_Check_List = [SpiritChildBridgeChest, SpiritChildEarlyTorchesChest, SpiritChildClimbNorthChest, SpiritChildClimbEastChest, SpiritMapChest, SpiritSunBlockRoomChest, SpiritSilverGauntletsChest, SpiritCompassChest, SpiritEarlyAdultRightChest, SpiritFirstMirrorLeftChest, SpiritFirstMirrorRightChest, SpiritStatueRoomNortheastChest, SpiritStatueRoomHandChest, SpiritNearFourArmosChest, SpiritHallwayRightInvisibleChest, SpiritHallwayLeftInvisibleChest, SpiritMirrorShieldChest, SpiritBossKeyChest, SpiritTopmostChest, SpiritTwinrovaHeart];
            GTG_Check_List = [GTGLobbyLeftChest, GTGLobbyRightChest, GTGStalfosChest, GTGBeforeHeavyBlockChest, GTGHeavyBlockFirstChest, GTGHeavyBlockSecondChest, GTGHeavyBlockThirdChest, GTGHeavyBlockFourthChest, GTGEyeStatueChest, GTGNearScarecrowChest, GTGHammerRoomClearChest, GTGHammerRoomSwitchChest, GTGFreestandingKey, GTGMazeRightCentralChest, GTGMazeRightSideChest, GTGUnderwaterSilverRupeeChest, GTGBeamosChest, GTGHiddenCeilingChest, GTGMazePathFirstChest, GTGMazePathSecondChest, GTGMazePathThirdChest, GTGMazePathFinalChest];
            DekuTree_Check_List = [DekuTreeMapChest, DekuTreeSlingshotRoomSideChest, DekuTreeSlingshotChest, DekuTreeCompassChest, DekuTreeCompassRoomSideChest, DekuTreeBasementChest, DekuTreeQueenGohmaHeart];
            DodongosCavern_Check_List = [DodongosCavernMapChest, DodongosCavernCompassChest, DodongosCavernBombFlowerPlatformChest, DodongosCavernBombBagChest, DodongosCavernEndofBridgeChest, DodongosCavernBossRoomChest, DodongosCavernKingDodongoHeart];
            JabuJabu_Check_List = [JabuJabusBellyBoomerangChest, JabuJabusBellyMapChest, JabuJabusBellyCompassChest, JabuJabusBellyBarinadeHeart];
            GanonsCastle_Check_List = [GanonsCastleForestTrialChest, GanonsCastleWaterTrialLeftChest, GanonsCastleWaterTrialRightChest, GanonsCastleShadowTrialFrontChest, GanonsCastleShadowTrialGoldenGauntletsChest, GanonsCastleLightTrialFirstLeftChest, GanonsCastleLightTrialSecondLeftChest, GanonsCastleLightTrialThirdLeftChest, GanonsCastleLightTrialFirstRightChest, GanonsCastleLightTrialSecondRightChest, GanonsCastleLightTrialThirdRightChest, GanonsCastleLightTrialInvisibleEnemiesChest, GanonsCastleLightTrialLullabyChest, GanonsCastleSpiritTrialCrystalSwitchChest, GanonsCastleSpiritTrialInvisibleChest, GanonsTowerBossKeyChest];
            IceCavern_Check_List = [IceCavernMapChest, IceCavernCompassChest, IceCavernIronBootsChest, IceCavernFreestandingPoH, IceCavernShiek];
            GoronCity_Check_List = [GCDaruniasJoy, GCPotFreestandingPoH, GCRollingGoronasChild, GCRollingGoronasAdult, GCMazeLeftChest, GCMazeCenterChest, GCMazeRightChest];
            BotW_Check_List = [BotWFrontLeftFakeWallChest, BotWFrontCenterBombableChest, BotWBackLeftBombableChest, BotWUnderwaterLeftChest, BotWFreestandingKey, BotWCompassChest, BotWCenterSkulltulaChest, BotWRightBottomFakeWallChest, BotWFireKeeseChest, BotWLikeLikeChest, BotWMapChest, BotWUnderwaterFrontChest, BotWInvisibleChest, BotWLensofTruthChest];           
            //Combine everything to the class region
            Region ForestTemple = new(Forest_Button, ForestTemple_Check_List, this) { RegionName = "Forest Temple"};
            Region FireTemple = new(Fire_Button, FireTemple_Check_List, this) { RegionName = "Fire Temple" };
            Region WaterTemple = new(Water_Button, WaterTemple_Check_List, this) { RegionName = "Water Temple" };
            Region SpiritTemple = new(Spirit_Button, SpiritTemple_Check_List, this) { RegionName = "Spirit Temple" };
            Region ShadowTemple = new(Shadow_Button, ShadowTemple_Check_List, this) { RegionName = "Shadow Temple" };
            Region DekuTree = new(Deku_Button, DekuTree_Check_List, this) { RegionName = "Deku Tree" };
            Region DodongosCavern = new(DC_Button, DodongosCavern_Check_List, this) { RegionName = "Dodongo's Cavern" };
            Region JabuJabu = new(Jabu_Button, JabuJabu_Check_List, this) { RegionName = "Jabu-Jabu's Belly" };
            Region BotW = new(BotW_Button, BotW_Check_List, this) { RegionName = "Bottom of the Well" };
            Region IceCavern = new(Ice_Button, IceCavern_Check_List, this) { RegionName = "Ice Cavern" };
            Region GTG = new(GTG_Button, GTG_Check_List, this) { RegionName = "Gerudo Training Ground" };
            Region Kakariko = new(Kakariko_Button, Kakariko_Check_List, this) { RegionName = "Kakariko", ShopChecks = KakarikoShops };
            Region Graveyard = new(Graveyard_Button, Graveyard_Check_List, this) { RegionName = "Graveyard" };
            Region GoronCity = new(GoronCity_Button, GoronCity_Check_List, this) { RegionName = "Goron City", ShopChecks =  GoronShop};
            Region ToT = new(ToT_Button, ToT_Check_List, this) { RegionName = "Temple of Time" };
            Region GanonsCastle = new(GanonsCastle_Button, GanonsCastle_Check_List, this) { RegionName = "Ganon's Castle" };
            DenseRegions = [ForestTemple, FireTemple, WaterTemple, SpiritTemple, ShadowTemple, DekuTree, DodongosCavern, JabuJabu, BotW, IceCavern, GTG, Kakariko, Graveyard, GoronCity, ToT, GanonsCastle];
            List<string> Denselocations_Names = ["Forest Temple", "Fire Temple", "Water Temple", "Spirit Temple", "Shadow Temple", "Deku Tree", "Dodongos Cavern", "Jabu-Jabus Belly", "Bottom of the Well", "Ice Cavern", "Gerudo Training Grounds", "Kakariko Village", "Graveyard", "Goron City", "Temple of Time", "Ganons Castle"];
            Wasteland.Checks = [WastelandChest];
            Colossus.Checks = [ColossusGreatFairy, ColossusPoH, ColossusShiek];
            GerudoFortress.Checks = [GFChest, HBA];
            GerudoValley.Checks = [GVWaterFallPoH, GVChest, GVCratePoH];
            HyruleField.Checks = [HFOoT, HFNearMarketGrottoChest, HFOpenGrottoChest, HFSalesman, HFSoutheastGrottoChest, HFTektikeGrottoPoH];
            LakeHylia.Checks = [LHChildFishing, LHAdultFishing, LHFreestandingPoH, LHLabDive, LHShootTheSun, LHUnderwaterItem];
            KokiriForest.Checks = [KFMidos, KFKokiriSwordChest, KFStormGrottoChest];
            LostWoods.Checks = [LWNearShortcutGrottoChest, LWOcarinaGame, LWScrubGrottoFront, LWScrubNearBridge, LWSkullKid, LWSkullMask, LWTarget];
            SFM.Checks = [SFMSaria, SFMShiek, SFMWolfosGrotto];
            ZoraRiver.Checks = [ZRFrogsGame, ZRFrogsStorms, ZRNearGrottoPoH, ZROpenGrotto, ZRPoHNearDomain];
            ZoraDomain.Checks = [ZDChest, ZDDivingGame, ZDKingZora];
            ZoraFountain.Checks = [ZFBottomPoH, ZFFreestandingPoH, ZFGreatFairy];
            DMT.Checks = [DMTBiggoron, DMTChest, DMTGreatFairy, DMTPoH, DMTStormsGrotto];
            DMC.Checks = [DMCGreatFairy, DMCShiek, DMCUpperGrotto, DMCVolcanoPoH, DMCWallPoH];
            Market.Checks = [MarketBigPoes, MarketBombchuBowling, MarketRichard, MarketShootingGalleryReward, MarketTreasureChestGame];
            HC.Checks = [HCGreatFairy];
            OGC.Checks = [OGCGreatFairy];
            LLR.Checks = [LLRMalon, LLRPoH, LLRTalon];
            OverworldRegions = [LLR, Wasteland, Colossus, GerudoFortress, GerudoValley, HyruleField, LakeHylia, KokiriForest, LostWoods, SFM, ZoraRiver, ZoraDomain, ZoraFountain, DMT, DMC, Market, HC, OGC];
            //MarketTest.Checks = Market_Check_List;
            //Assign checks to region buttons
            List<string> Region_Names = ["Haunted Wasteland", "Desert Colossus", "Gerudo Fortress", "Gerudo Valley", "Hyrule Field", "Lake Hylia", "Kokiri Forest", "Lost Woods", "Sacred Forest Meadow", "Zora River", "Zora Domain", "Zora Fountain", "Death Mountain Trail", "Death Mountain Crater", "Market", "Hyrule Castle", "Outside Ganons Castle", "Lon-Lon-Ranch", "Temple of Time"];           
            //Add region panels to the map
            ExpensiveMerchantShuffle = true;
            ShopShuffle = true;
            AddExtraChecks();
            var temp = 0;         
            foreach (Region region in DenseRegions)
            {               
                if (region.RegionButton != null)
                {
                    region.RegionButton._name = Denselocations_Names[temp];
                }
                if (region.DungeonButton != null)
                {
                    region.DungeonButton._name = Denselocations_Names[temp];
                }
                foreach (Region_Panel_Check c in region.Checks)
                {
                    
                    c.MouseEnter += (sender, e) => c.RichToolTip.DrawToolTip(this);
                    c.MouseLeave += (sender, e) => c.RichToolTip.DeleteToolTip(this);
                    //c.MouseEnter += (sender,e) => c.RichToolTip.SetRegionCheckLocation(c) ;
                    c.MouseEnter += (sender, e) => c.RichToolTip.Location = new Point(c.Location.X + 300, c.Location.Y + 65);
                    //c.RichToolTip.SetLocation(this);
                }       
                //Test stage change
                region.ValueChanged += (sender, e) => UpdateStatVariables(stats);
                temp++;
            }
            //Bring checks to front
            foreach (Control c in Controls)
            {
                if (c != null && c is Check check)
                {
                    check.BringToFront();
                    check.ValueChanged += (sender, e) => UpdateStatVariables(stats);
                    check.MouseEnter += (sender, e) => check.RichToolTip.DrawToolTip(this);
                    check.MouseEnter += (sender, e) => check.RichToolTip.PreventTooltipOoB(this, check.Location);
                    check.MouseLeave += (sender, e) => check.RichToolTip.DeleteToolTip(this);
                    check.RichToolTip.Location = new Point(check.Location.X + 10, check.Location.Y + 20);
                }
                if (c != null && c is Region_Button_Dense rbd)
                {
                    rbd.BringToFront();
                }
                if (c != null && c is ShopButton ShopButton)
                {
                    ShopButton.MouseDown += (sender, e) => ShopButton.CreatePanel(this, e);
                    ShopButton.MouseEnter += (sender, e) => ShopButton.RichToolTip.DrawToolTip(this);
                    ShopButton.MouseEnter += (sender, e) => ShopButton.RichToolTip.PreventTooltipOoB(this, ShopButton.Location);
                    ShopButton.MouseLeave += (sender, e) => ShopButton.RichToolTip.DeleteToolTip(this);
                    ShopButton.ValueChanged += (sender, e) => UpdateStatVariables(stats);
                    ShopButton.RichToolTip.Location = new Point(ShopButton.Location.X + 10, ShopButton.Location.Y + 20);
                }
            }
            //Assign tooltips to Goron City and Zora's Domain Shops
            List<ShopPanelCheck> KakAndGCShopChecks = [GoronShopTopLeft, GoronShopTopRight, GoronShopBottomLeft, GoronShopBottomRight,KakBazaarTopLeft, KakBazaarTopRight, KakBazaarBottomLeft, KakBazaarBottomRight, KakPotionShopTopLeft, KakPotionShopTopRight, KakPotionShopBottomLeft, KakPotionShopBottomRight];
            foreach (ShopPanelCheck spc in KakAndGCShopChecks)
            {
                spc.MouseEnter += (sender, e) => spc.RichToolTip.DrawToolTip(this);
                spc.MouseEnter += (sender, e) => spc.RichToolTip.PreventTooltipOoB(this, spc.Location);
                spc.MouseLeave += (sender, e) => spc.RichToolTip.DeleteToolTip(this);
                spc.MouseEnter += (sender, e) => spc.RichToolTip.Location = new Point(spc.Location.X + 300, spc.Location.Y + 65);
            }                    
        }

        public void UpdateCheckColors()
        {
            foreach (Control c in Controls)
            {
                if (c is Check check)
                {
                    check.UpdateColor();
                }
            }
        }
        public void UpdateDenseLocations()
        {
            foreach (Region region in DenseRegions)
            {
                if (region.RegionButton != null)
                {
                    region.UpdateCounter();
                }
                else
                {
                    region.UpdateDungeonCounter();
                }
            }
        }
        public void AddExpensiveMerchants()
        {
            if (ExpensiveMerchantShuffle == true)
            {
                Kakariko_Check_List.Add(KakGranny);
                GoronCity_Check_List.Add(GCMedigoron);
                Wasteland.Checks.Add(WastelandSalesman);
                WastelandSalesman.Show();
            }
            else
            {
                Kakariko_Check_List.Remove(KakGranny);
                GoronCity_Check_List.Remove(GCMedigoron);
                Wasteland.Checks.Remove(WastelandSalesman);
                WastelandSalesman.Hide();
            }
            UpdateStats = 1;
        }
        public void AddShopShuffle()
        {
            if (ShopShuffle == true)
            {
                Market.ShopChecks.Add(MarketPotionShop);
                Market.ShopChecks.Add(MarketBazaar);
                Market.ShopChecks.Add(MarketBombchuShop);
                KokiriForest.ShopChecks.Add(KFShop);
                ZoraDomain.ShopChecks.Add(ZDShop);
                MarketPotionShop.Show();
                MarketBazaar.Show();
                MarketBombchuShop.Show();
                KFShop.Show();
                ZDShop.Show();
                KakarikoShops.Add(KakBazaarTopLeft);
                KakarikoShops.Add(KakBazaarTopRight);
                KakarikoShops.Add(KakBazaarBottomLeft);
                KakarikoShops.Add(KakBazaarBottomRight);
                KakarikoShops.Add(KakPotionShopTopLeft);
                KakarikoShops.Add(KakPotionShopTopRight);
                KakarikoShops.Add(KakPotionShopBottomLeft);
                KakarikoShops.Add(KakPotionShopBottomRight);
                GoronShop.Add(GoronShopTopLeft);
                GoronShop.Add(GoronShopTopRight);
                GoronShop.Add(GoronShopBottomLeft);
                GoronShop.Add(GoronShopBottomRight);
            }
            else
            {
                Market.ShopChecks.Remove(MarketPotionShop);
                Market.ShopChecks.Remove(MarketBazaar);
                Market.ShopChecks.Remove(MarketBombchuShop);
                KokiriForest.ShopChecks.Remove(KFShop);
                ZoraDomain.ShopChecks.Remove(ZDShop);
                MarketPotionShop.Hide();
                MarketBazaar.Hide();
                MarketBombchuShop.Hide();
                KFShop.Hide();
                ZDShop.Hide();
                KakarikoShops.Remove(KakBazaarTopLeft);
                KakarikoShops.Remove(KakBazaarTopRight);
                KakarikoShops.Remove(KakBazaarBottomLeft);
                KakarikoShops.Remove(KakBazaarBottomRight);
                KakarikoShops.Remove(KakPotionShopTopLeft);
                KakarikoShops.Remove(KakPotionShopTopRight);
                KakarikoShops.Remove(KakPotionShopBottomLeft);
                KakarikoShops.Remove(KakPotionShopBottomRight);
                GoronShop.Remove(GoronShopTopLeft);
                GoronShop.Remove(GoronShopTopRight);
                GoronShop.Remove(GoronShopBottomLeft);
                GoronShop.Remove(GoronShopBottomRight);
            }
            UpdateStats = 1;
        }
        public void AddExtraChecks()
        {
            AddExpensiveMerchants();
            AddShopShuffle();
            UpdateStats = 1;
        }
        public void UpdateStatVariables(Stats stats)
        {
            int ChecksAvailable = 0;
            int ChecksRemaining = 0;
            int ChecksDone = 0;
            for (int i = 0; i < DenseRegions.Count; i++)
            {
                foreach(Region_Panel_Check RegionPanelCheck in  DenseRegions[i].Checks)
                {
                    if (!RegionPanelCheck.Checked)
                    {
                        ChecksRemaining++;
                    }
                    if (RegionPanelCheck.ForeColor == Color.Lime && !RegionPanelCheck.Checked)
                    {
                        ChecksAvailable++;
                    }
                    if (RegionPanelCheck.Checked)
                    {
                        ChecksDone++;
                    }
                }
                foreach (ShopPanelCheck ShopPanelCheck in DenseRegions[i].ShopChecks)
                {
                    if (!ShopPanelCheck.Checked)
                    {
                        ChecksRemaining++;
                    }
                    if (ShopPanelCheck.ForeColor == Color.Lime && !ShopPanelCheck.Checked)
                    {
                        ChecksAvailable++;
                    }
                    if (ShopPanelCheck.Checked)
                    {
                        ChecksDone++;
                    }
                }
            }
            for(int i = 0;i < OverworldRegions.Count; i++)
            {
                foreach (Check Check in OverworldRegions[i].Checks)
                {
                    if (!Check.Done)
                    {
                        ChecksRemaining++;
                    }
                    if (Check.color == Available && !Check.Done)
                    {
                        ChecksAvailable++;
                    }
                    if (Check.Done)
                    {
                        ChecksDone++;
                    }
                }
                foreach (ShopButton sc in OverworldRegions[i].ShopChecks)
                {
                    foreach (ShopPanelCheck sc1 in sc.ShopChecks)
                    {
                        if (!sc1.Checked)
                        {
                            ChecksRemaining++;
                        }
                        if (sc1.ForeColor == Available && !sc1.Checked)
                        {
                            ChecksAvailable++;
                        }
                        if (sc1.Checked)
                        {
                            ChecksDone++;
                        }
                    }
                }
            }           
            stats.ChecksAvailable = ChecksAvailable;
            stats.ChecksRemaining = ChecksRemaining;
            stats.ChecksDone = ChecksDone;
            stats.SkulltulaAvailable = tokensAvailable;
            stats.UpdateChecksAvailable();
        }      
        public void GetRegionName(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel)
        {
            string regionname = "";
            OverworldRegions Region = new();
            if (e.X >= 340 && e.X <= 533 && e.Y >= 542 && e.Y <= 730)
            {
                regionname = "Lake Hylia";
                Region = LakeHylia;
            }
            else if (e.X >= 253 && e.X <= 405 && e.Y >= 408 && e.Y <= 566)
            {
                regionname = "Gerudo Valley";
                Region = GerudoValley;
            }
            if (e.X >= 364 && e.X <= 560 && e.Y >= 289 && e.Y <= 478)
            {
                regionname = "Hyrule Field";
                Region = HyruleField;
            }
            if (e.X >= 430 && e.X <= 472 && e.Y >= 359 && e.Y <= 401)
            {
                regionname = "Lon-Lon-Ranch";
                Region = LLR;
            }
            if (e.X >= 243 && e.X <= 417 && e.Y >= 151 && e.Y <= 367)
            {
                regionname = "Gerudo Fortress";
                Region = GerudoFortress;
            }
            if (e.X >= 49 && e.X <= 246 && e.Y >= 215 && e.Y <= 397)
            {
                regionname = "Haunted Wasteland";
                Region = Wasteland;
            }
            if (e.X >= 0 && e.X <= 85 && e.Y >= 316 && e.Y <= 385)
            {
                regionname = "Desert Colossus";
                Region = Colossus;
            }
            if (e.X >= 415 && e.X <= 529 && e.Y >= 239 && e.Y <= 288)
            {
                regionname = "Market";
                Region = Market;
            }
            if (e.X >= 475 && e.X <= 550 && e.Y >= 146 && e.Y <= 222)
            {
                regionname = "Hyrule Castle";
                Region = HC;
            }
            if (e.X >= 380 && e.X <= 481 && e.Y >= 111 && e.Y <= 227)
            {
                regionname = "Outside Ganons Castle";
                Region = OGC;
            }
            if (e.X >= 560 && e.X <= 716 && e.Y >= 312 && e.Y <= 416)
            {
                regionname = "Zora River";
                Region = ZoraRiver;
            }
            if (e.X >= 716 && e.X <= 838 && e.Y >= 242 && e.Y <= 371)
            {
                regionname = "Zora Domain";
                Region = ZoraDomain;
            }
            if (e.X >= 693 && e.X <= 858 && e.Y >= 96 && e.Y <= 242)
            {
                regionname = "Zora Fountain";
                Region = ZoraFountain;
            }
            if (e.X >= 683 && e.X <= 729 && e.Y >= 362 && e.Y <= 499)
            {
                regionname = "Sacred Forest Meadow";
                Region = SFM;
            }
            if (e.X >= 581 && e.X <= 764 && e.Y >= 493 && e.Y <= 708)
            {
                regionname = "Lost Woods";
                Region = LostWoods;
            }
            if (e.X >= 617 && e.X <= 687 && e.Y >= 649 && e.Y <= 723)
            {
                regionname = "Kokiri Forest";
                Region = KokiriForest;
            }
            if (e.X >= 587 && e.X <= 684 && e.Y >= 110 && e.Y <= 260)
            {
                regionname = "Death Mountain Trial";
                Region = DMT;
            }
            if (e.X >= 560 && e.X <= 696 && e.Y >= 1 && e.Y <= 117)
            {
                regionname = "Death Mountain Crater";
                Region = DMC;
            }
            if (e.Button == MouseButtons.Right)
            {
                AddContextMenu(e, ContextWheel, regionname);
            }
            if (e.Button == MouseButtons.Middle)
            {
                int ChecksChecked = 0;
                int MaxChecks = 0;
                foreach (Check cb in Region.Checks)
                {
                    MaxChecks++;
                    if (cb.Done)
                    {
                        ChecksChecked++;
                    }
                }
                foreach (ShopButton sc in Region.ShopChecks)
                {
                    foreach(ShopPanelCheck sc1 in sc.ShopChecks)
                    {
                        MaxChecks++;
                        if (sc1.Checked)
                        {
                            ChecksChecked++;
                        }
                    }
                }
                if (MaxChecks > ChecksChecked)
                {
                    foreach (Check cb in Region.Checks)
                    {
                        cb.Done = false;
                        cb.ChangeColor();
                    }
                    foreach (ShopButton sc in Region.ShopChecks)
                    {
                        foreach (ShopPanelCheck sc1 in sc.ShopChecks)
                        {
                            sc1.Checked = true;           
                        }
                        sc.UpdateColor();
                    }
                }
                else
                {
                    foreach (Check cb in Region.Checks)
                    {
                        cb.Done = true;
                        cb.ChangeColor();
                    }
                    foreach (ShopButton sc in Region.ShopChecks)
                    {
                        foreach (ShopPanelCheck sc1 in sc.ShopChecks)
                        {
                            sc1.Checked = false;                        
                        }
                        sc.UpdateColor();
                    }
                }
                UpdateStats = 1;
            }
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel, string Regionname)
        {
            int posX = e.X;
            int posY = e.Y;
            if (e.X - 70 <= 0)
            {
                posX = 70;
            }
            if (e.Y - 70 <= 0)
            {
                posY = 70;
            }
            if (e.X + 70 >= 857)
            {
                posX = 787;
            }
            if (e.Y + 70 >= 728)
            {
                posY = 658;
            }
            ContextWheel.AddContextMenu(this, posX - 70, posY - 70);
            ContextWheel.BringToFront();
            ContextWheel.RegionName = Regionname;
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel, Region RegionButton)
        {
            int posX = e.X + RegionButton.RegionButton.Location.X;
            int posY = e.Y + RegionButton.RegionButton.Location.Y;
            if (posX - 70 <= 0)
            {
                posX = 70;
            }
            if (posY - 70 <= 0)
            {
                posY = 70;
            }
            if (posX + 70 >= 857)
            {
                posX = 787;
            }
            if (posY + 70 >= 728)
            {
                posY = 658;
            }
            if (e.Button == MouseButtons.Right)
            {
                ContextWheel.AddContextMenu(this, posX - 70, posY - 70);
                ContextWheel.BringToFront();
                ContextWheel.RegionName = RegionButton.RegionName;
            }
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel, DungeonButton DungeonButton)
        {
            int posX = e.X + DungeonButton.Location.X;
            int posY = e.Y + DungeonButton.Location.Y;
            if (posX - 70 <= 0)
            {
                posX = 70;
            }
            if (posY - 70 <= 0)
            {
                posY = 70;
            }
            if (posX + 70 >= 857)
            {
                posX = 787;
            }
            if (posY + 70 >= 728)
            {
                posY = 658;
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextWheel.AddContextMenu(this, posX - 70, posY - 70);
                ContextWheel.BringToFront();
                ContextWheel.RegionName = DungeonButton._name;           
            }
        }
        public void UpdateWOTHGoals(WOTHPanel wothpanel, ImportantHintPanel ImportantHints, ContextMenuForWOTHHints ContextWheel)
        {
            if(ContextWheel.Goal >= -3 &&  ContextWheel.Goal <= 6)
            {
                foreach (GoalPathHint c in wothpanel.Goals)
                {
                    if (c is GoalPathHint gph)
                    {
                        if (gph.goaltext.Text == string.Empty)
                        {
                            gph.goaltext.Text = ContextWheel.RegionName;
                            gph.goalpicture.State = ContextWheel.Goal;
                            gph.goalpicture.CheckGoalState();
                            return;
                        }
                    }
                }
            }
            else
            {
                foreach (ImportantHint Hint in ImportantHints.ImportantHints)
                {
                    
                    if (Hint.RegionName.Text == string.Empty)
                    {
                        Hint.RegionName.Text = ContextWheel.RegionName;                     
                        return;
                    }                  
                }
            }
        }
        
    }
}
