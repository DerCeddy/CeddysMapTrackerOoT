using CeddyMapTracker.Properties;
using Newtonsoft.Json;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CeddyMapTracker.SometimesHintsPanel;

namespace CeddyMapTracker
{
    public partial class Maptracker : UserControl
    {
        //public List<Region> DenseRegions;
        public List<OverworldRegions> OverworldRegions;
        public List<RegionPanel> RegionWithKeys;
        //public List<Region> DungeonER;
        public List<Region_Panel_Check> AllRegionChecks;
        public List<DungeonButton> DungeonButtons;
        public List<RegionButton> RegionButtons;
        public List<DungeonERGossipstone> DungeonERGossipstones;
        public List<int> SmallKeys = [];
        public List<Region_Panel_Check> AlwaysHintChecks = [];
        public List<Region_Panel_Check> SometimesHintChecks = [];
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
        public BindingList<Region_Panel_Check> ForestTemple_Check_List;
        public BindingList<Region_Panel_Check> Kakariko_Check_List;
        public BindingList<Region_Panel_Check> Graveyard_Check_List;
        public BindingList<Region_Panel_Check> ToT_Check_List;
        public BindingList<Region_Panel_Check> ShadowTemple_Check_List;
        public BindingList<Region_Panel_Check> FireTemple_Check_List;
        public BindingList<Region_Panel_Check> WaterTemple_Check_List;
        public BindingList<Region_Panel_Check> SpiritTemple_Check_List;
        public BindingList<Region_Panel_Check> GTG_Check_List;
        public BindingList<Region_Panel_Check> DekuTree_Check_List;
        public BindingList<Region_Panel_Check> DodongosCavern_Check_List;
        public BindingList<Region_Panel_Check> JabuJabu_Check_List;
        public BindingList<Region_Panel_Check> GanonsCastle_Check_List;
        public BindingList<Region_Panel_Check> IceCavern_Check_List;
        public BindingList<Region_Panel_Check> GoronCity_Check_List;
        public BindingList<Region_Panel_Check> BotW_Check_List;
        public BindingList<BindingList<Region_Panel_Check>> AllRegionPanelChecks;
        public BindingList<ShopPanelCheck> KakarikoShops = [];
        public BindingList<ShopPanelCheck> GoronShop = [];
        public BindingList<BindingList<ShopPanelCheck>> AllShopPanelChecks;
        public RegionPanel[] Dungeon_Panels = [];
        public RegionPanel[] Region_Panels = [];
        public RegionPanel Forest_RegionPanel = new() { RegionName = "Forest Temple", IsKeyDungeon = true, DungeonAccess = 3};
        public RegionPanel Fire_RegionPanel = new() { RegionName = "Fire Temple", IsKeyDungeon = true, DungeonAccess = 4};
        public RegionPanel Water_RegionPanel = new() { RegionName = "Water Temple", IsKeyDungeon = true, DungeonAccess = 5 };
        public RegionPanel Shadow_RegionPanel = new() { RegionName = "Shadow Temple", IsKeyDungeon = true, DungeonAccess = 6 };
        public RegionPanel Spirit_RegionPanel = new() { RegionName = "Spirit Temple", IsKeyDungeon = true, DungeonAccess = 7 };
        public RegionPanel GTG_RegionPanel = new() { RegionName = "Gerudo Training Grounds", IsKeyDungeon = true, DungeonAccess = 9 };
        public RegionPanel Ice_RegionPanel = new() { RegionName = "Ice Cavern", IsKeyDungeon = false, DungeonAccess = 10 };
        public RegionPanel Deku_RegionPanel = new() { RegionName = "Deku Tree", IsKeyDungeon = false, DungeonAccess = 0};
        public RegionPanel DC_RegionPanel = new() { RegionName = "Dodongo's Cavern", IsKeyDungeon = false, DungeonAccess = 1 };
        public RegionPanel Jabu_RegionPanel = new() { RegionName = "Jabu-Jabu's Belly", IsKeyDungeon = false, DungeonAccess = 2 };
        public RegionPanel BotW_RegionPanel = new() { RegionName = "Bottom of the Well", IsKeyDungeon = true, DungeonAccess = 8 };
        public RegionPanel Ganon_RegionPanel = new() { RegionName = "Ganon's Castle", IsKeyDungeon = false };
        public RegionPanel Kakariko_RegionPanel = new() { RegionName = "Kakariko", IsKeyDungeon = false };
        public RegionPanel GoronCity_RegionPanel = new() { RegionName = "Goron City", IsKeyDungeon = false };
        public RegionPanel Graveyard_RegionPanel = new() { RegionName = "Graveyard", IsKeyDungeon = false };
        public RegionPanel ToT_RegionPanel = new() { RegionName = "Temple of Time", IsKeyDungeon = false };

        public bool ExpensiveMerchantShuffle;
        public bool ShopShuffle;
        public bool DungeonER;
        //public ContextMenuForDungeonER DungeonERWheel = new();

        public int UpdateLogicAndStats
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
            [JsonProperty("SometimesHintNames")]
            public required SometimesHintNames sometimesHint;
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
            //Dungeon ER
            //Controls.Add(DungeonERWheel);
            //Add region panels to control
            Dungeon_Panels = [Deku_RegionPanel, DC_RegionPanel, Jabu_RegionPanel, BotW_RegionPanel, Forest_RegionPanel, Fire_RegionPanel, Water_RegionPanel, Shadow_RegionPanel, Spirit_RegionPanel, GTG_RegionPanel, Ice_RegionPanel, Ganon_RegionPanel,];
            Controls.AddRange(Dungeon_Panels);
            //Add invisible panels
            DungeonButtons = [Deku_Button, DC_Button, Jabu_Button, BotW_Button, Forest_Button, Fire_Button, Water_Button, Shadow_Button, Spirit_Button, GTG_Button, Ice_Button, GanonsCastle_Button];
            DungeonERGossipstones = [Deku_DungeonER_Gossipstone, DC_DungeonER_Gossipstone, Jabu_DungeonER_Gossipstone, BotW_DungeonER_Gossipstone, Forest_DungeonER_Gossipstone, Fire_DungeonER_Gossipstone, Water_DungeonER_Gossipstone, Shadow_DungeonER_Gossipstone, Spirit_DungeonER_Gossipstone, GTG_DungeonER_Gossipstone, Ice_DungeonER_Gossipstone];
            RegionButtons = [Kakariko_Button, GoronCity_Button, Graveyard_Button, ToT_Button];
            Region_Panels = [Kakariko_RegionPanel, GoronCity_RegionPanel, Graveyard_RegionPanel, ToT_RegionPanel];
            Controls.AddRange(Region_Panels);
            //panel.MouseDown += (sender, e) => panel.Visible = false;          
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
            AllRegionPanelChecks = [ForestTemple_Check_List, Kakariko_Check_List, Graveyard_Check_List, ToT_Check_List, ShadowTemple_Check_List, FireTemple_Check_List, WaterTemple_Check_List, SpiritTemple_Check_List, GTG_Check_List, DekuTree_Check_List, DodongosCavern_Check_List, JabuJabu_Check_List, GanonsCastle_Check_List, IceCavern_Check_List, GoronCity_Check_List, BotW_Check_List];
            AllShopPanelChecks = [KakarikoShops, GoronShop];
            //Forest_Button.Checks = ForestTemple_Check_List;
            //Fire_Button.Checks = FireTemple_Check_List;
            //Combine everything to the class region
            /*
            Region ForestTemple = new(Forest_Button, ForestTemple_Check_List, this) { RegionName = "Forest Temple", DungeonEntrance = 3 };
            Region FireTemple = new(Fire_Button, FireTemple_Check_List, this) { RegionName = "Fire Temple", DungeonEntrance = 4 };
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
            Region GoronCity = new(GoronCity_Button, GoronCity_Check_List, this) { RegionName = "Goron City", ShopChecks = GoronShop };
            Region ToT = new(ToT_Button, ToT_Check_List, this) { RegionName = "Temple of Time" };
            Region GanonsCastle = new(GanonsCastle_Button, GanonsCastle_Check_List, this) { RegionName = "Ganon's Castle" };
            */
            //DenseRegions = [ForestTemple, FireTemple, WaterTemple, SpiritTemple, ShadowTemple, DekuTree, DodongosCavern, JabuJabu, BotW, IceCavern, GTG, Kakariko, Graveyard, GoronCity, ToT, GanonsCastle];
            RegionWithKeys = [Forest_RegionPanel, Fire_RegionPanel, Water_RegionPanel, Shadow_RegionPanel, Spirit_RegionPanel, BotW_RegionPanel, GTG_RegionPanel];
            //DungeonER = [DekuTree, DodongosCavern, JabuJabu, ForestTemple, FireTemple, WaterTemple, ShadowTemple, SpiritTemple, BotW, GTG, IceCavern];          
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
            //Fill lists
            //Assign checks to dungeon panels
            Deku_RegionPanel.Checks = DekuTree_Check_List;
            DC_RegionPanel.Checks = DodongosCavern_Check_List;
            Jabu_RegionPanel.Checks = JabuJabu_Check_List;
            BotW_RegionPanel.Checks = BotW_Check_List;
            Forest_RegionPanel.Checks = ForestTemple_Check_List;
            Fire_RegionPanel.Checks = FireTemple_Check_List;
            Water_RegionPanel.Checks = WaterTemple_Check_List;
            Shadow_RegionPanel.Checks = ShadowTemple_Check_List;
            Spirit_RegionPanel.Checks = SpiritTemple_Check_List;
            GTG_RegionPanel.Checks = GTG_Check_List;
            Ice_RegionPanel.Checks = IceCavern_Check_List;
            Ganon_RegionPanel.Checks = GanonsCastle_Check_List;
            //Assign checks to region panels
            Kakariko_RegionPanel.Checks = Kakariko_Check_List;
            Kakariko_RegionPanel.ShopChecks = KakarikoShops;
            GoronCity_RegionPanel.Checks = GoronCity_Check_List;
            GoronCity_RegionPanel.ShopChecks = GoronShop;
            Graveyard_RegionPanel.Checks = Graveyard_Check_List;
            ToT_RegionPanel.Checks = ToT_Check_List;
            //Assign checks to region buttons
            List<string> Region_Names = ["Haunted Wasteland", "Desert Colossus", "Gerudo Fortress", "Gerudo Valley", "Hyrule Field", "Lake Hylia", "Kokiri Forest", "Lost Woods", "Sacred Forest Meadow", "Zora River", "Zora Domain", "Zora Fountain", "Death Mountain Trail", "Death Mountain Crater", "Market", "Hyrule Castle", "Outside Ganons Castle", "Lon-Lon-Ranch", "Temple of Time"];
            //Add region panels to the map
            ExpensiveMerchantShuffle = true;
            ShopShuffle = true;
            AddExtraChecks();
            //var temp = 0;
            
            //Assign tooltip functions to checks

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
                if (c != null && c is DungeonButton DungeonButton)
                {                   
                    DungeonButton.MouseEnter += (sender, e) => DungeonButton.RichToolTip.DrawToolTip(this);
                    DungeonButton.MouseEnter += (sender, e) => DungeonButton.RichToolTip.PreventTooltipOoB(this, DungeonButton.Location);
                    DungeonButton.MouseLeave += (sender, e) => DungeonButton.RichToolTip.DeleteToolTip(this);
                    DungeonButton.RichToolTip.Location = new Point(DungeonButton.Location.X + 10, DungeonButton.Location.Y + 36);
                }
            }
            //Assign tooltips to Goron City and Zora's Domain Shops
            List<ShopPanelCheck> KakAndGCShopChecks = [GoronShopTopLeft, GoronShopTopRight, GoronShopBottomLeft, GoronShopBottomRight, KakBazaarTopLeft, KakBazaarTopRight, KakBazaarBottomLeft, KakBazaarBottomRight, KakPotionShopTopLeft, KakPotionShopTopRight, KakPotionShopBottomLeft, KakPotionShopBottomRight];
            foreach (ShopPanelCheck spc in KakAndGCShopChecks)
            {
                spc.MouseEnter += (sender, e) => spc.RichToolTip.DrawToolTip(this);
                spc.MouseEnter += (sender, e) => spc.RichToolTip.PreventTooltipOoB(this, spc.Location);
                spc.MouseLeave += (sender, e) => spc.RichToolTip.DeleteToolTip(this);
                spc.MouseEnter += (sender, e) => spc.RichToolTip.Location = new Point(spc.Location.X + 300, spc.Location.Y + 65);
            }
            AlwaysHintChecks = [IceCavernShiek, IceCavernIronBootsChest, Kak20GoldSkulltulaReward, Kak30GoldSkulltulaReward, Kak40GoldSkulltulaReward, Kak50GoldSkulltulaReward, KakShiek];
            foreach(Control c in Controls)
            {
                if(c != null && c is RegionPanel RegionPanel)
                {
                    foreach(Region_Panel_Check Check in RegionPanel.Checks)
                    {
                        if(Check != null && Check.CheckIndex != 0)
                        {
                            SometimesHintChecks.Add(Check);
                        }
                    }
                }              
            }
            AssignDungeonPanelsToButtons();
            AssignRegionPanelsToButtons();
            foreach (DungeonButton button in DungeonButtons)
            {
                Controls.Add(button.InvisiblePanel);                
                button.InitiateMethods();
            }
            foreach (RegionButton RegionButton in RegionButtons)
            {
                Controls.Add(RegionButton.InvisiblePanel);
                RegionButton.InitiateMethods();
            }
            for (int i = 0; i < DungeonERGossipstones.Count; i++)
            {
                var temp = i;
                DungeonERGossipstones[temp].MouseDown += (sender, e) => AddDungeonERWheel(e, DungeonERGossipstones[temp], DungeonButtons[temp]);
            }
            //Assign tooltips to checks
            foreach (DungeonButton DungeonButton in DungeonButtons)
            {
                foreach (Region_Panel_Check c in DungeonButton.RegionPanel.Checks)
                {

                    c.MouseEnter += (sender, e) => c.RichToolTip.DrawToolTip(this);
                    c.MouseLeave += (sender, e) => c.RichToolTip.DeleteToolTip(this);
                    //c.MouseEnter += (sender,e) => c.RichToolTip.SetRegionCheckLocation(c) ;
                    c.MouseEnter += (sender, e) => c.RichToolTip.Location = new Point(c.Location.X + 300, c.Location.Y + 75);
                    //c.RichToolTip.SetLocation(this);
                }
            }
            foreach (RegionButton RegionButton in RegionButtons)
            {
                foreach (Region_Panel_Check c in RegionButton.RegionPanel.Checks)
                {

                    c.MouseEnter += (sender, e) => c.RichToolTip.DrawToolTip(this);
                    c.MouseLeave += (sender, e) => c.RichToolTip.DeleteToolTip(this);
                    //c.MouseEnter += (sender,e) => c.RichToolTip.SetRegionCheckLocation(c) ;
                    c.MouseEnter += (sender, e) => c.RichToolTip.Location = new Point(c.Location.X + 300, c.Location.Y + 75);
                    //c.RichToolTip.SetLocation(this);
                }
            }
            ConnectRegionPanelsAndLogic();                      
        }
        public void AssignMethodToChecks(DungeonButton DungeonButton)
        {
            foreach (Region_Panel_Check check in DungeonButton.Checks)
            {
                check.ValueChanged += (sender, e) => DungeonButton.UpdateDungeonCounter();
                check.ForeColorChanged += (sender, e) => DungeonButton.UpdateDungeonCounter();
            }
        }
        public void AddDungeonERWheel(MouseEventArgs e, DungeonERGossipstone Gossipstone, DungeonButton DungeonButton)
        {
            ContextMenuForDungeonER Wheel = new();
            Wheel.AddContextMenu(e, Gossipstone, this);
            Controls.Add(Wheel);
            Wheel.BringToFront();
            Wheel.ValueChanged += (sender, e) => UpdateDungeonRegionPanel(Wheel.Goal, DungeonButton);
            Wheel.ValueChanged += (sender, e) => Gossipstone.Image = UpdateDungeonERGossipstoneImage(Wheel.Goal);
            Wheel.ValueChanged += (sender, e) => UpdateLogicAndStats = 1;
            Wheel.ValueChanged += (sender, e) => DungeonButton.UpdateDungeonCounter();
        }
        public void UpdateDungeonRegionPanel(int ID, DungeonButton DungeonButton)
        {
            switch(ID)
            {
                case 0:
                    DungeonButton.RegionPanel = Deku_RegionPanel;
                    Deku_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;                    
                    break;
                case 1:
                    DungeonButton.RegionPanel = DC_RegionPanel;
                    DC_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 2:
                    DungeonButton.RegionPanel = Jabu_RegionPanel;
                    Jabu_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 3:
                    DungeonButton.RegionPanel = Forest_RegionPanel;
                    Forest_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 4:
                    DungeonButton.RegionPanel = Fire_RegionPanel;
                    Fire_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 5:
                    DungeonButton.RegionPanel = Water_RegionPanel;
                    Water_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 6:
                    DungeonButton.RegionPanel = Shadow_RegionPanel;
                    Shadow_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 7:
                    DungeonButton.RegionPanel = Spirit_RegionPanel;
                    Spirit_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 8:
                    DungeonButton.RegionPanel = BotW_RegionPanel;
                    BotW_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 9:
                    DungeonButton.RegionPanel = GTG_RegionPanel;
                    GTG_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;
                case 10:
                    DungeonButton.RegionPanel = Ice_RegionPanel;
                    Ice_RegionPanel.DungeonAccess = DungeonButton.DungeonAccess;
                    break;         
            }
        }
        public Bitmap UpdateDungeonERGossipstoneImage(int ID)
        {
            Bitmap Image = Resources.Unknown;
            switch (ID)
            {
                case 0:
                    Image = Resources.gohma_32x32;
                    break;
                case 1:
                    Image = Resources.dodongo_32x32;
                    break;
                case 2:
                    Image = Resources.barinade_32x32;
                    break;
                case 3:
                    Image = Resources.pg_32x32;
                    break;
                case 4:
                    Image = Resources.volvagia_32x32;
                    break;
                case 5:
                    Image = Resources.morpha_32x32;
                    break;
                case 6:
                    Image = Resources.bongo_32x32;
                    break;
                case 7:
                    Image = Resources.twinrova_32x32;
                    break;
                case 8:
                    Image = (Bitmap)System.Drawing.Image.FromFile("Textures/3DS/OoT3D_Lens_of_Truth_Icon.png");
                    break;
                case 9:
                    Image = (Bitmap)System.Drawing.Image.FromFile("Textures/3DS/OoT3D_Gerudo_Token_Icon.png");
                    break;
                case 10:
                    Image = Resources.IceCavern;
                    break;
            }
            
            return Image;
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
        public void ConnectRegionPanelsAndLogic()
        {
            foreach(RegionPanel panel in Dungeon_Panels)
            {
                panel.CheckStateChanged += (sender, e) => UpdateLogicAndStats = 1;
            }
        }
        public void AssignRegionPanelsToButtons()
        {
            for (int i = 0; i < RegionButtons.Count; i++)
            {
                RegionButtons[i].RegionPanel = Region_Panels[i];
            }
        }
        public void AssignDungeonPanelsToButtons()
        {
            for(int i = 0; i < DungeonButtons.Count; i++)
            {
                DungeonButtons[i].RegionPanel = Dungeon_Panels[i];
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
                Kakariko_RegionPanel.Checks.Remove(KakGranny);
                GoronCity_Check_List.Remove(GCMedigoron);
                Wasteland.Checks.Remove(WastelandSalesman);
                WastelandSalesman.Hide();
            }
            UpdateLogicAndStats = 1;
            UpdateRegionCounters();
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
                Kakariko_RegionPanel.ShopChecks.Add(KakBazaarTopLeft);
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
            UpdateLogicAndStats = 1;
            UpdateRegionCounters();
        }
        public void AddDungeonER()
        {
            if(DungeonER)
            {
                //Deku_DungeonER_Gossipstone.Visible = true;
                Controls.Add(Deku_DungeonER_Gossipstone);
                Controls.Add(DC_DungeonER_Gossipstone);
                Controls.Add(Jabu_DungeonER_Gossipstone);
                Controls.Add(BotW_DungeonER_Gossipstone);
                Controls.Add(Forest_DungeonER_Gossipstone);
                Controls.Add(Fire_DungeonER_Gossipstone);
                Controls.Add(Water_DungeonER_Gossipstone);
                Controls.Add(Shadow_DungeonER_Gossipstone);
                Controls.Add(Spirit_DungeonER_Gossipstone);
                Controls.Add(GTG_DungeonER_Gossipstone);
                Controls.Add(Ice_DungeonER_Gossipstone);
            }
            else
            {
                Controls.Remove(Deku_DungeonER_Gossipstone);
                Controls.Remove(DC_DungeonER_Gossipstone);
                Controls.Remove(Jabu_DungeonER_Gossipstone);
                Controls.Remove(BotW_DungeonER_Gossipstone);
                Controls.Remove(Forest_DungeonER_Gossipstone);
                Controls.Remove(Fire_DungeonER_Gossipstone);
                Controls.Remove(Water_DungeonER_Gossipstone);
                Controls.Remove(Shadow_DungeonER_Gossipstone);
                Controls.Remove(Spirit_DungeonER_Gossipstone);
                Controls.Remove(GTG_DungeonER_Gossipstone);
                Controls.Remove(Ice_DungeonER_Gossipstone);
            }
        }
        public void AddExtraChecks()
        {
            AddExpensiveMerchants();
            AddShopShuffle();
            UpdateLogicAndStats = 1;
            UpdateRegionCounters();
        }
        public void UpdateRegionCounters()
        {
            foreach(RegionButton button in RegionButtons)
            {
                button.UpdateCounter();
            }
        }
        public void UpdateStatVariables(Stats stats)
        {
            int ChecksAvailable = 0;
            int ChecksRemaining = 0;
            int ChecksDone = 0;
            for(int i = 0; i < AllRegionPanelChecks.Count; i++)
            {
                foreach (Region_Panel_Check RegionPanelCheck in AllRegionPanelChecks[i])
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
                
            }
            for (int i = 0; i < AllShopPanelChecks.Count; i++)
            {
                foreach (ShopPanelCheck ShopPanelCheck in AllShopPanelChecks[i])
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
            /*
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
            */
            for (int i = 0;i < OverworldRegions.Count; i++)
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
                UpdateLogicAndStats = 1;
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
            /*
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
            */
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
        public void UpdateDungeonLocation(ContextMenuForDungeonER DungeonERWheel, ItemPanel i)
        {
            /*
            RefreshDungeonCheckLists();
            DungeonER[3].Checks = DungeonER[DungeonERWheel.Goal].Checks;
            //Forest_Temple_Access = DungeonER1(Forest_Temple_Access, i, DungeonERWheel.Goal);
            DungeonER[DungeonERWheel.Goal].DungeonEntrance = 3;
            DungeonER[3].RegionName = DungeonER[DungeonERWheel.Goal].RegionName;
            */
        }       
        public void RefreshDungeonCheckLists()
        {
            /*
            DungeonER[0].Checks = DekuTree_Check_List;
            DungeonER[1].Checks = DodongosCavern_Check_List;
            DungeonER[2].Checks = JabuJabu_Check_List;
            DungeonER[3].Checks = ForestTemple_Check_List;
            DungeonER[4].Checks = FireTemple_Check_List;
            DungeonER[5].Checks = WaterTemple_Check_List;
            DungeonER[6].Checks = ShadowTemple_Check_List;
            DungeonER[7].Checks = SpiritTemple_Check_List;
            DungeonER[8].Checks = BotW_Check_List;
            DungeonER[9].Checks = GTG_Check_List;
            DungeonER[10].Checks = IceCavern_Check_List;
            */
        }              
    }
}
