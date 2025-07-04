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
        public List<Region> regions;
        public List<int> SmallKeys = [];
        public List<Check> LLR_Check_List;
        public List<Check> Wasteland_Check_List;
        public List<Check> Colossus_Check_List;
        public List<Check> GerudoFortress_Check_List;
        public List<Check> GerudoValley_Check_List;
        public List<Check> HyruleField_Check_List;
        public List<Check> LakeHylia_Check_List;
        public List<Check> KokiriForest_Check_List;
        public List<Check> LostWoods_Check_List;
        public List<Check> SFM_Check_List;
        public List<Check> ZoraRiver_Check_List;
        public List<Check> ZoraDomain_Check_List;
        public List<Check> ZoraFountain_Check_List;
        public List<Check> DMT_Check_List;
        public List<Check> DMC_Check_List;
        public List<Check> Market_Check_List;
        public List<Check> HC_Check_List;
        public List<Check> OGC_Check_List;
        public List<Check> ToT_Check_List;
        public class Settings
        {
            [JsonProperty("CheckName")]
            public required CheckName checkname;
        }
        public class CheckName
        {
            public string ?WastelandChest;
            public string ?ColossusShiek;
            public string ?ColossusPoH;
            public string ?ColossusGreatFairy;
            public string ?GFChest;
            public string ?HBA;
            public string ?GVWaterFallPoH;
            public string ?GVCratePoH;
            public string ?GVChest;
            public string ?LHLabDive;
            public string ?LHFreestandingPoH;
            public string ?LHUnderwaterItem;
            public string ?LHChildFishing;
            public string ?LHAdultFishing;
            public string ?LHShootTheSun;
            public string ?HFTektikeGrottoPoH;
            public string ?HFNearMarketGrottoChest;
            public string ?HFOoT;
            public string ?HFSoutheastGrottoChest;
            public string ?HFOpenGrottoChest;
            public string ?HFSalesman;
            public string ?MarketShootingGalleryReward;
            public string ?MarketRichard;
            public string ?MarketTreasureChestGame;
            public string ?ToTLACS;
            public string ?ToTShiek;
            public string ?HCGreatFairy;
            public string ?OGCGreatFairy;
            public string ?DMTPoH;
            public string ?DMTChest;
            public string ?DMTStormsGrotto;
            public string ?DMTGreatFairy;
            public string ?DMTBiggoron;
            public string ?DMCWallPoH;
            public string ?DMCUpperGrotto;
            public string ?DMCShiek;
            public string ?DMCVolcanoPoH;
            public string ?DMCGreatFairy;
            public string ?ZROpenGrotto;
            public string ?ZRNearGrottoPoH;
            public string ?ZRPoHNearDomain;
            public string ?ZRFrogsStorms;
            public string ?ZRFrogsGame;
            public string ?ZDChest;
            public string ?ZRDivingGame;
            public string ?ZDKingZora;
            public string ?ZFGreatFairy;
            public string ?ZFFreestandingPoH;
            public string ?ZFBottomPoH;
            public string ?KFMidos;
            public string ?KFKokiriSwordChest;
            public string ?KFStormGrottoChest;
            public string ?LWScrubNearBridge;
            public string ?LWSkullKid;
            public string ?LWOcarinaGame;
            public string ?LWTarget;
            public string ?LWNearShortcutGrottoChest;
            public string ?LWSkullMask;
            public string ?LWScrubGrottoFront;
            public string ?SFMWolfosGrotto;
            public string ?SFMSaria;
            public string ?SFMShiek;
            public string? LLRTalon;
            public string? LLRMalon;
            public string? LLRPoH;
        }
        public Maptracker(WOTHPanel wothPanel, Point location, Stats stats)
        {
            InitializeComponent();
            Location = location;
            StreamReader r = new("checknames.json");
            string json = r.ReadToEnd();
            Settings Konfig = JsonConvert.DeserializeObject<Settings>(json);                    
            toolTip1.SetToolTip(WastelandChest, Konfig.checkname.WastelandChest);         
            toolTip1.SetToolTip(ColossusShiek, Konfig.checkname.ColossusShiek);
            toolTip1.SetToolTip(ColossusPoH, Konfig.checkname.ColossusPoH);
            toolTip1.SetToolTip(ColossusGreatFairy, Konfig.checkname.ColossusGreatFairy);
            toolTip1.SetToolTip(GFChest, Konfig.checkname.GFChest);
            toolTip1.SetToolTip(HBA, Konfig.checkname.HBA);
            toolTip1.SetToolTip(GVWaterFallPoH, Konfig.checkname.GVWaterFallPoH);
            toolTip1.SetToolTip(GVCratePoH, Konfig.checkname.GVCratePoH);
            toolTip1.SetToolTip(GVChest, Konfig.checkname.GVChest);
            toolTip1.SetToolTip(LHLabDive, Konfig.checkname.LHLabDive);
            toolTip1.SetToolTip(LHFreestandingPoH, Konfig.checkname.LHFreestandingPoH);
            toolTip1.SetToolTip(LHUnderwaterItem, Konfig.checkname.LHUnderwaterItem);
            toolTip1.SetToolTip(LHChildFishing, Konfig.checkname.LHChildFishing);
            toolTip1.SetToolTip(LHAdultFishing, Konfig.checkname.LHAdultFishing);
            toolTip1.SetToolTip(LHShootTheSun, Konfig.checkname.LHShootTheSun);
            toolTip1.SetToolTip(HFTektikeGrottoPoH, Konfig.checkname.HFTektikeGrottoPoH);
            toolTip1.SetToolTip(HFNearMarketGrottoChest, Konfig.checkname.HFNearMarketGrottoChest);
            toolTip1.SetToolTip(HFOoT, Konfig.checkname.HFOoT);
            toolTip1.SetToolTip(HFSoutheastGrottoChest, Konfig.checkname.HFSoutheastGrottoChest);
            toolTip1.SetToolTip(HFOpenGrottoChest, Konfig.checkname.HFOpenGrottoChest);
            toolTip1.SetToolTip(HFSalesman, Konfig.checkname.HFSalesman);
            toolTip1.SetToolTip(MarketShootingGalleryReward, Konfig.checkname.MarketShootingGalleryReward);
            toolTip1.SetToolTip(MarketRichard, Konfig.checkname.MarketRichard);
            toolTip1.SetToolTip(MarketTreasureChestGame, Konfig.checkname.MarketTreasureChestGame);
            toolTip1.SetToolTip(ToTLACS, Konfig.checkname.ToTLACS);
            toolTip1.SetToolTip(ToTShiek, Konfig.checkname.ToTShiek);
            toolTip1.SetToolTip(HCGreatFairy, Konfig.checkname.HCGreatFairy);
            toolTip1.SetToolTip(OGCGreatFairy, Konfig.checkname.OGCGreatFairy);
            toolTip1.SetToolTip(DMTPoH, Konfig.checkname.DMTPoH);
            toolTip1.SetToolTip(DMTChest, Konfig.checkname.DMTChest);
            toolTip1.SetToolTip(DMTStormsGrotto, Konfig.checkname.DMTStormsGrotto);
            toolTip1.SetToolTip(DMTGreatFairy, Konfig.checkname.DMTGreatFairy);
            toolTip1.SetToolTip(DMTBiggoron, Konfig.checkname.DMTBiggoron);
            toolTip1.SetToolTip(DMCWallPoH, Konfig.checkname.DMCWallPoH);
            toolTip1.SetToolTip(DMCUpperGrotto, Konfig.checkname.DMCUpperGrotto);
            toolTip1.SetToolTip(DMCShiek, Konfig.checkname.DMCShiek);
            toolTip1.SetToolTip(DMCVolcanoPoH, Konfig.checkname.DMCVolcanoPoH);
            toolTip1.SetToolTip(DMCGreatFairy, Konfig.checkname.DMCGreatFairy);
            toolTip1.SetToolTip(ZROpenGrotto, Konfig.checkname.ZROpenGrotto);
            toolTip1.SetToolTip(ZRNearGrottoPoH, Konfig.checkname.ZRNearGrottoPoH);
            toolTip1.SetToolTip(ZRPoHNearDomain, Konfig.checkname.ZRPoHNearDomain);
            toolTip1.SetToolTip(ZRFrogsStorms, Konfig.checkname.ZRFrogsStorms);
            toolTip1.SetToolTip(ZRFrogsGame, Konfig.checkname.ZRFrogsGame);
            toolTip1.SetToolTip(ZDChest, Konfig.checkname.ZDChest);
            toolTip1.SetToolTip(ZRDivingGame, Konfig.checkname.ZRDivingGame);
            toolTip1.SetToolTip(ZDKingZora, Konfig.checkname.ZDKingZora);
            toolTip1.SetToolTip(ZFGreatFairy, Konfig.checkname.ZFGreatFairy);
            toolTip1.SetToolTip(ZFFreestandingPoH, Konfig.checkname.ZFFreestandingPoH);
            toolTip1.SetToolTip(ZFBottomPoH, Konfig.checkname.ZFBottomPoH);
            toolTip1.SetToolTip(KFMidos, Konfig.checkname.KFMidos);
            toolTip1.SetToolTip(KFKokiriSwordChest, Konfig.checkname.KFKokiriSwordChest);
            toolTip1.SetToolTip(KFStormGrottoChest, Konfig.checkname.KFStormGrottoChest);
            toolTip1.SetToolTip(LWScrubNearBridge, Konfig.checkname.LWScrubNearBridge);
            toolTip1.SetToolTip(LWSkullKid, Konfig.checkname.LWSkullKid);
            toolTip1.SetToolTip(LWOcarinaGame, Konfig.checkname.LWOcarinaGame);
            toolTip1.SetToolTip(LWTarget, Konfig.checkname.LWTarget);
            toolTip1.SetToolTip(LWNearShortcutGrottoChest, Konfig.checkname.LWNearShortcutGrottoChest);
            toolTip1.SetToolTip(LWSkullMask, Konfig.checkname.LWSkullMask);
            toolTip1.SetToolTip(LWScrubGrottoFront, Konfig.checkname.LWScrubGrottoFront);
            toolTip1.SetToolTip(SFMWolfosGrotto, Konfig.checkname.SFMWolfosGrotto);
            toolTip1.SetToolTip(SFMSaria, Konfig.checkname.SFMSaria);
            toolTip1.SetToolTip(SFMShiek, Konfig.checkname.SFMShiek);
            toolTip1.SetToolTip(LLRTalon, Konfig.checkname.LLRTalon);
            toolTip1.SetToolTip(LLRMalon, Konfig.checkname.LLRMalon);
            toolTip1.SetToolTip(LLRPoH, Konfig.checkname.LLRPoH);
            //Assign checks to check list
            List<Region_Panel_Check> ForestTemple_Check_List = [ForestFirstRoomChest, ForestFirstStalfosRoomChest, ForestRaisedIslandCourtyardChest, ForestMapChest, ForestWellChest, ForestEyeSwitchChest, ForestBossKeyChest, ForestFloormasterChest, ForestRedPoeChest, ForestBowChest, ForestBluePoeChest, ForestFallingCeillingRoomChest, ForestBasementChest, ForestPhantomGanonHeart];
            List<Region_Panel_Check> Kakariko_Check_List = [KakAnjuasChild, KakAnjuasAdult, KakImpasHouseFreestandingPoH, KakWindmillFreestandingPoH, WindmillSong, KakManonRoof, KakOpenGrottoChest, KakRedeadGrottoChest, KakShootingGalleryReward, KakShiek, Kak10GoldSkulltulaReward, Kak20GoldSkulltulaReward, Kak30GoldSkulltulaReward, Kak40GoldSkulltulaReward, Kak50GoldSkulltulaReward];
            List<Region_Panel_Check> Graveyard_Check_List = [GraveyardShieldGraveChest, GraveyardHeartPieceGraveChest, GraveyardRoyalFamilysTombChest, GraveyardFreestandingPoH, GraveyardDampeGravediggingTour, GraveyardDampeRaceHookshotChest, GraveyardDampeRaceFreestandingPoH, GraveyardComposerSong];
            List<Region_Panel_Check> ShadowTemple_Check_List = [ShadowMapChest, ShadowHoverBootsChest, ShadowCompassChest, ShadowEarlySilverRupeeChest, ShadowInvisibleBladesVisibleChest, ShadowInvisibleBladesInvisibleChest, ShadowFallingSpikesLowerChest, ShadowFallingSpikesUpperChest, ShadowFallingSpikesSwitchChest, ShadowInvisibleSpikesChest, ShadowFreestandingKey, ShadowWindHintChest, ShadowAfterWindEnemyChest, ShadowAfterWindHiddenChest, ShadowSpikeWallsLeftChest, ShadowBossKeyChest, ShadowInvisibleFloormasterChest, ShadowBongoBongoHeart];
            List<Region_Panel_Check> FireTemple_Check_List = [FireNearBossChest, FireFlareDancerChest, FireBossKeyChest, FireBigLavaRoomLowerDoorChest, FireBigLavaRoomBlockedDoorChest, FireBoulderMazeLowerChest, FireBoulderMazeSideRoomChest, FireMapChest, FireBoulderMazeShortcutChest, FireBoulderMazeUpperChest, FireScarecrowChest, FireCompassChest, FireMegatonHammerChest, FireHighestGoronChest, FireVolvagiaHeart];
            List<Region_Panel_Check> WaterTemple_Check_List = [WaterCompassChest, WaterMapChest, WaterCrackedWallChest, WaterTorchesChest, WaterBossKeyChest, WaterCentralPillarChest, WaterCentralBowTargetChest, WaterLongshotChest, WaterRiverChest, WaterDragonChest, WaterMorphaHeart];
            List<Region_Panel_Check> SpiritTemple_Check_List = [SpiritChildBridgeChest, SpiritChildEarlyTorchesChest, SpiritChildClimbNorthChest, SpiritChildClimbEastChest, SpiritMapChest, SpiritSunBlockRoomChest, SpiritSilverGauntletsChest, SpiritCompassChest, SpiritEarlyAdultRightChest, SpiritFirstMirrorLeftChest, SpiritFirstMirrorRightChest, SpiritStatueRoomNortheastChest, SpiritStatueRoomHandChest, SpiritNearFourArmosChest, SpiritHallwayRightInvisibleChest, SpiritHallwayLeftInvisibleChest, SpiritMirrorShieldChest, SpiritBossKeyChest, SpiritTopmostChest, SpiritTwinrovaHeart];
            List<Region_Panel_Check> GTG_Check_List = [GTGLobbyLeftChest, GTGLobbyRightChest, GTGStalfosChest, GTGBeforeHeavyBlockChest, GTGHeavyBlockFirstChest, GTGHeavyBlockSecondChest, GTGHeavyBlockThirdChest, GTGHeavyBlockFourthChest, GTGEyeStatueChest, GTGNearScarecrowChest, GTGHammerRoomClearChest, GTGHammerRoomSwitchChest, GTGFreestandingKey, GTGMazeRightCentralChest, GTGMazeRightSideChest, GTGUnderwaterSilverRupeeChest, GTGBeamosChest, GTGHiddenCeilingChest, GTGMazePathFirstChest, GTGMazePathSecondChest, GTGMazePathThirdChest, GTGMazePathFinalChest];
            List<Region_Panel_Check> DekuTree_Check_List = [DekuTreeMapChest, DekuTreeSlingshotRoomSideChest, DekuTreeSlingshotChest, DekuTreeCompassChest, DekuTreeCompassRoomSideChest, DekuTreeBasementChest, DekuTreeQueenGohmaHeart];
            List<Region_Panel_Check> DodongosCavern_Check_List = [DodongosCavernMapChest, DodongosCavernCompassChest, DodongosCavernBombFlowerPlatformChest, DodongosCavernBombBagChest, DodongosCavernEndofBridgeChest, DodongosCavernBossRoomChest, DodongosCavernKingDodongoHeart];
            List<Region_Panel_Check> JabuJabu_Check_List = [JabuJabusBellyBoomerangChest, JabuJabusBellyMapChest, JabuJabusBellyCompassChest, JabuJabusBellyBarinadeHeart];
            List<Region_Panel_Check> GanonsCastle_Check_List = [GanonsCastleForestTrialChest, GanonsCastleWaterTrialLeftChest, GanonsCastleWaterTrialRightChest, GanonsCastleShadowTrialFrontChest, GanonsCastleShadowTrialGoldenGauntletsChest, GanonsCastleLightTrialFirstLeftChest, GanonsCastleLightTrialSecondLeftChest, GanonsCastleLightTrialThirdLeftChest, GanonsCastleLightTrialFirstRightChest, GanonsCastleLightTrialSecondRightChest, GanonsCastleLightTrialThirdRightChest, GanonsCastleLightTrialInvisibleEnemiesChest, GanonsCastleLightTrialLullabyChest, GanonsCastleSpiritTrialCrystalSwitchChest, GanonsCastleSpiritTrialInvisibleChest, GanonsTowerBossKeyChest];
            List<Region_Panel_Check> IceCavern_Check_List = [IceCavernMapChest, IceCavernCompassChest, IceCavernIronBootsChest, IceCavernFreestandingPoH, IceCavernShiek];
            List<Region_Panel_Check> GoronCity_Check_List = [GCDaruniasJoy, GCPotFreestandingPoH, GCRollingGoronasChild, GCRollingGoronasAdult, GCMazeLeftChest, GCMazeCenterChest, GCMazeRightChest];
            List<Region_Panel_Check> BotW_Check_List = [BotWFrontLeftFakeWallChest, BotWFrontCenterBombableChest, BotWBackLeftBombableChest, BotWUnderwaterLeftChest, BotWFreestandingKey, BotWCompassChest, BotWCenterSkulltulaChest, BotWRightBottomFakeWallChest, BotWFireKeeseChest, BotWLikeLikeChest, BotWMapChest, BotWUnderwaterFrontChest, BotWInvisibleChest, BotWLensofTruthChest];
            //Assign check list to the regions panel
            Region_Panel ForestTemple_Panel = new(ForestTemple_Check_List, "Forest Temple");
            Region_Panel Kakariko_Panel = new(Kakariko_Check_List, "Kakariko");
            Region_Panel Graveyard_Panel = new(Graveyard_Check_List, "Graveyard");
            Region_Panel ShadowTemple_Panel = new(ShadowTemple_Check_List, "Shadow Temple");
            Region_Panel FireTemple_Panel = new(FireTemple_Check_List, "Fire Temple");
            Region_Panel WaterTemple_Panel = new(WaterTemple_Check_List, "Water Temple");
            Region_Panel SpiritTemple_Panel = new(SpiritTemple_Check_List, "Spirit Temple");
            Region_Panel GTG_Panel = new(GTG_Check_List, "Gerudo Trainings Grounds");
            Region_Panel DekuTree_Panel = new(DekuTree_Check_List, "Deku Tree");
            Region_Panel DodongosCavern_Panel = new(DodongosCavern_Check_List, "Dodongos Cavern");
            Region_Panel JabuJabu_Panel = new(JabuJabu_Check_List, "Jabu-Jabus Belly");
            Region_Panel GanonsCastle_Panel = new(GanonsCastle_Check_List, "Ganons Castle");
            Region_Panel IceCavern_Panel = new(IceCavern_Check_List, "Ice Cavern");
            Region_Panel GoronCity_Panel = new(GoronCity_Check_List, "Goron City");
            Region_Panel BotW_Panel = new(BotW_Check_List, "Bottom of the Well");
            //Combine everything to the class region
            Region ForestTemple = new(Forest_Button, ForestTemple_Panel, ForestTemple_Check_List, this);
            Region FireTemple = new(Fire_Button, FireTemple_Panel, FireTemple_Check_List, this);
            Region WaterTemple = new(Water_Button, WaterTemple_Panel, WaterTemple_Check_List, this);
            Region SpiritTemple = new(Spirit_Button, SpiritTemple_Panel, SpiritTemple_Check_List, this);
            Region ShadowTemple = new(Shadow_Button, ShadowTemple_Panel, ShadowTemple_Check_List, this);
            Region DekuTree = new(Deku_Button, DekuTree_Panel, DekuTree_Check_List, this);
            Region DodongosCavern = new(DC_Button, DodongosCavern_Panel, DodongosCavern_Check_List, this);
            Region JabuJabu = new(Jabu_Button, JabuJabu_Panel, JabuJabu_Check_List, this);
            Region BotW = new(BotW_Button, BotW_Panel, BotW_Check_List, this);
            Region IceCavern = new(Ice_Button, IceCavern_Panel, IceCavern_Check_List, this);
            Region GTG = new(GTG_Button, GTG_Panel, GTG_Check_List, this);
            Region Kakariko = new(Kakariko_Button, Kakariko_Panel, Kakariko_Check_List, this);
            Region Graveyard = new(Graveyard_Button, Graveyard_Panel, Graveyard_Check_List, this);
            Region GoronCity = new(GoronCity_Button, GoronCity_Panel, GoronCity_Check_List, this);
            Region GanonsCastle = new(GanonsCastle_Button, GanonsCastle_Panel, GanonsCastle_Check_List, this);
            regions = [ForestTemple, FireTemple, WaterTemple, SpiritTemple, ShadowTemple, DekuTree, DodongosCavern, JabuJabu, BotW, IceCavern, GTG, Kakariko, Graveyard, GoronCity, GanonsCastle];
            List<string> Denselocations_Names = ["Forest Temple", "Fire Temple", "Water Temple", "Spirit Temple", "Shadow Temple", "Deku Tree", "Dodongos Cavern", "Jabu-Jabus Belly", "Bottom of the Well", "Ice Cavern", "Gerudo Training Grounds", "Kakariko Village", "Graveyard", "Goron City", "Ganons Castle"];
            Wasteland_Check_List = [WastelandChest];
            Colossus_Check_List = [ColossusGreatFairy, ColossusPoH, ColossusShiek];
            GerudoFortress_Check_List = [GFChest, HBA];
            GerudoValley_Check_List = [GVWaterFallPoH, GVChest, GVCratePoH];
            HyruleField_Check_List = [HFOoT, HFNearMarketGrottoChest, HFOpenGrottoChest, HFSalesman, HFSoutheastGrottoChest, HFTektikeGrottoPoH];
            LakeHylia_Check_List = [LHChildFishing, LHAdultFishing, LHFreestandingPoH, LHLabDive, LHShootTheSun, LHUnderwaterItem];
            KokiriForest_Check_List = [KFMidos, KFKokiriSwordChest, KFStormGrottoChest];
            LostWoods_Check_List = [LWNearShortcutGrottoChest, LWOcarinaGame, LWScrubGrottoFront, LWScrubNearBridge, LWSkullKid, LWSkullMask, LWTarget];
            SFM_Check_List = [SFMSaria, SFMShiek, SFMWolfosGrotto];
            ZoraRiver_Check_List = [ZRFrogsGame, ZRFrogsStorms, ZRNearGrottoPoH, ZROpenGrotto, ZRPoHNearDomain];
            ZoraDomain_Check_List = [ZDChest, ZRDivingGame, ZDKingZora];
            ZoraFountain_Check_List = [ZFBottomPoH, ZFFreestandingPoH, ZFGreatFairy];
            DMT_Check_List = [DMTBiggoron, DMTChest, DMTGreatFairy, DMTPoH, DMTStormsGrotto];
            DMC_Check_List = [DMCGreatFairy, DMCShiek, DMCUpperGrotto, DMCVolcanoPoH, DMCWallPoH];
            Market_Check_List = [MarketBigPoes, MarketBombchuBowling, MarketRichard, MarketShootingGalleryReward, MarketTreasureChestGame];
            HC_Check_List = [HCGreatFairy];
            OGC_Check_List = [OGCGreatFairy];
            ToT_Check_List = [ToTLACS, ToTShiek];
            LLR_Check_List = [LLRMalon, LLRPoH, LLRTalon];
            //Assign checks to region buttons
            List<string> Region_Names = ["Haunted Wasteland", "Desert Colossus", "Gerudo Fortress", "Gerudo Valley", "Hyrule Field", "Lake Hylia", "Kokiri Forest", "Lost Woods", "Sacred Forest Meadow", "Zora River", "Zora Domain", "Zora Fountain", "Death Mountain Trail", "Death Mountain Crater", "Market", "Hyrule Castle", "Outside Ganons Castle", "Lon-Lon-Ranch", "Temple of Time"];
            //List<List<Check>> Test = [Wasteland_Check_List, Colossus_Check_List, GerudoFortress_Check_List, GerudoValley_Check_List, HyruleField_Check_List, LakeHylia_Check_List, KokiriForest_Check_List, LostWoods_Check_List, SFM_Check_List, ZoraRiver_Check_List, ZoraDomain_Check_List, ZoraFountain_Check_List, DMT_Check_List, DMC_Check_List, Market_Check_List, HC_Check_List, OGC_Check_List, LLR_Check_List, ToT_Check_List];          
            ContextMenuForWOTHHints test123 = new();
            Controls.Add(test123);
            test123.Visible = false;          
            //Update WOTH Panel Goals
            test123.ValueChanged += (sender, e) => UpdateWOTHGoals(wothPanel,test123);         
            //Add region panels to the map
            var temp = 0;
            foreach (Region region in regions)
            {
                Controls.Add(region._region_panel);
                region._region_panel.Visible = false;
                if (region._region_button != null)
                {
                    region._region_button._name = Denselocations_Names[temp];
                    region._region_button.MouseDown += (sender, e) => AddContextMenu(e, test123, region);
                }
                if (region._dungeon_button != null)
                {
                    region._dungeon_button._name = Denselocations_Names[temp];
                    region._dungeon_button.MouseDown += (sender, e) => AddContextMenu(e, test123, region._dungeon_button);
                }
                /*
                foreach(Control c in region._region_panel.Controls)
                {
                    if(c != null && c is Region_Panel_Check rpc)
                    {
                        rpc.MouseDown += (sender, e) => GetChecksAvailable(stats);
                    }
                }
                */
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
                }
                if (c != null && c is Region_Button_Dense rbd)
                {
                    rbd.BringToFront();
                }
            }
            MouseDown += (sender,e) => GetRegionName(e, test123);
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
        public void UpdateDenseLocations(List<Region> regions)
        {
            foreach (Region region in regions)
            {
                if (region._region_button != null)
                {
                    region.UpdateCounter();
                } 
                else
                {
                    region.UpdateDungeonCounter();
                }
            }
        }
        public void UpdateStatVariables(Stats stats)
        {
            int ChecksAvailable = 0;
            int ChecksRemaining = 0;
            int ChecksDone = 0;
            foreach (Control c in Controls)
            {
                if (c is Check check)
                {
                    if (check.BackColor == Color.Lime)
                    {
                        ChecksAvailable++;

                    }
                    if (!check.done)
                    {
                        ChecksRemaining++;
                    }
                    if (check.done)
                    {
                        ChecksDone++;
                    }
                }
                if (c is Region_Panel panel)
                {
                    foreach (Control c1 in panel.Controls)
                    {
                        if (c1 is Region_Panel_Check rpc)
                        {
                            if (!rpc.Checked)
                            {
                                ChecksRemaining++;
                            }
                            if (rpc.ForeColor == Color.Lime && !rpc.Checked)
                            {
                                ChecksAvailable++;
                            }
                            if (rpc.Checked)
                            {
                                ChecksDone++;
                            }
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
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints test123, RegionButton RegionButton)
        {
            if (e.Button == MouseButtons.Right)
            {
                test123.AddContextMenu(this,e.X + RegionButton.Location.X - 70, e.Y + RegionButton.Location.Y - 70);
                test123.BringToFront();
                test123.RegionName = RegionButton.RegionName;
            }
        }
        public void GetRegionName(MouseEventArgs e, ContextMenuForWOTHHints test123)
        {
            string regionname = "";
            List<Check> checks = new();        
            if (e.X >= 340 && e.X <= 533 && e.Y >= 542 && e.Y <= 730)
            {
                regionname = "Lake Hylia";
                checks = LakeHylia_Check_List;
            }
            else if (e.X >= 253 && e.X <= 405 && e.Y >= 408 && e.Y <= 566)
            {
                regionname = "Gerudo Valley";
                checks = GerudoValley_Check_List;
            }
            if (e.X >= 364 && e.X <= 560 && e.Y >= 289 && e.Y <= 478)
            {
                regionname = "Hyrule Field";
                checks = HyruleField_Check_List;
            }
            if (e.X >= 430 && e.X <= 472 && e.Y >= 359 && e.Y <= 401)
            {
                regionname = "Lon-Lon-Ranch";
                checks = LLR_Check_List;
            }
            if (e.X >= 243 && e.X <= 417 && e.Y >= 151 && e.Y <= 367)
            {
                regionname = "Gerudo Fortress";
                checks = GerudoFortress_Check_List;
            }
            if (e.X >= 49 && e.X <= 246 && e.Y >= 215 && e.Y <= 397)
            {
                regionname = "Haunted Wasteland";
                checks = Wasteland_Check_List;
            }
            if (e.X >= 0 && e.X <= 85 && e.Y >= 316 && e.Y <= 385)
            {
                regionname = "Desert Colossus";
                checks = Colossus_Check_List;
            }
            if (e.X >= 415 && e.X <= 529 && e.Y >= 239 && e.Y <= 288)
            {
                regionname = "Market";
                checks = Market_Check_List;
            }
            if (e.X >= 475 && e.X <= 550 && e.Y >= 146 && e.Y <= 222)
            {
                regionname = "Hyrule Castle";
                checks = HC_Check_List;
            }
            if (e.X >= 380 && e.X <= 481 && e.Y >= 111 && e.Y <= 227)
            {
                regionname = "Outside Ganons Castle";
                checks = OGC_Check_List;
            }          
            if (e.X >= 560 && e.X <= 716 && e.Y >= 312 && e.Y <= 416)
            {
                regionname = "Zora River";
                checks = ZoraRiver_Check_List;
            }
            if (e.X >= 716 && e.X <= 838 && e.Y >= 242 && e.Y <= 371)
            {
                regionname = "Zora Domain";
                checks = ZoraDomain_Check_List;
            }
            if (e.X >= 693 && e.X <= 858 && e.Y >= 96 && e.Y <= 242)
            {
                regionname = "Zora Fountain";
                checks = ZoraFountain_Check_List;
            }
            if (e.X >= 683 && e.X <= 729 && e.Y >= 362 && e.Y <= 499)
            {
                regionname = "Sacred Forest Meadow";
                checks = SFM_Check_List;
            }
            if (e.X >= 581 && e.X <= 764 && e.Y >= 493 && e.Y <= 708)
            {
                regionname = "Lost Woods";
                checks = LostWoods_Check_List;
            }
            if (e.X >= 617 && e.X <= 687 && e.Y >= 649 && e.Y <= 723)
            {
                regionname = "Kokiri Forest";
                checks = KokiriForest_Check_List;
            }
            if (e.X >= 587 && e.X <= 684 && e.Y >= 110 && e.Y <= 260)
            {
                regionname = "Death Mountain Trial";
                checks = DMT_Check_List;
            }
            if (e.X >= 560 && e.X <= 696 && e.Y >= 1 && e.Y <= 117)
            {
                regionname = "Death Mountain Crater";
                checks = DMC_Check_List;
            }
            if (e.Button == MouseButtons.Right)
            {              
                AddContextMenu(e,test123,regionname);
            }
            if(e.Button == MouseButtons.Middle)
            {
                int ChecksChecked = 0;
                int MaxChecks = 0;
                foreach (Check cb in checks)
                {
                    MaxChecks++;
                    if (cb.done)
                    {
                        ChecksChecked++;
                    }
                }
                if (MaxChecks > ChecksChecked)
                {
                    foreach (Check cb in checks)
                    {
                        cb.done = false;
                        cb.ChangeColor();
                    }
                }
                else
                {
                    foreach (Check cb in checks)
                    {
                        cb.done = true;
                        cb.ChangeColor();
                    }
                }
            }
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints test123, string Regionname)
        {          
            test123.AddContextMenu(this, e.X - 70, e.Y - 70);
            test123.BringToFront();
            test123.RegionName = Regionname;
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints test123, Region RegionButton)
        {
            int posX = e.X;
            if (e.X + RegionButton._region_button.Location.X - 70 <= 70)
            {
                posX = 70;
            }
            
            if (e.Button == MouseButtons.Right)
            {
                test123.AddContextMenu(this, posX + RegionButton._region_button.Location.X - 70, e.Y + RegionButton._region_button.Location.Y - 70);
                test123.BringToFront();
                test123.RegionName = RegionButton._region_button._name;
            }
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints test123, DungeonButton DungeonButton)
        {
            int posX = e.X;
            if (e.X + DungeonButton.Location.X - 70 <= 70)
            {
                posX = 70;
            }

            if (e.Button == MouseButtons.Right)
            {
                test123.AddContextMenu(this, posX + DungeonButton.Location.X - 70, e.Y + DungeonButton.Location.Y - 70);
                test123.BringToFront();
                test123.RegionName = DungeonButton._name;
            }
        }
        public void UpdateWOTHGoals(WOTHPanel wothpanel, ContextMenuForWOTHHints test123)
        {                                
            foreach (GoalPathHint c in wothpanel.Goals)
            {
                if (c is GoalPathHint gph)
                {
                    if (gph.goaltext.Text == string.Empty)
                    {
                        gph.goaltext.Text = test123.RegionName;
                        gph.goalpicture.State = test123.Goal;
                        gph.goalpicture.CheckGoalState();
                        return;
                    }
                }            
            }                            
        }
    }
}
