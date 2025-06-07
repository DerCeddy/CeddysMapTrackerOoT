using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public partial class Maptracker : UserControl
    {
        public List<Region> regions;
        public List<int> SmallKeys = [];
        public Maptracker(WOTHPanel wothPanel, Point location, Stats stats)
        {
            InitializeComponent();
            Location = location;
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
            List<Check> Wasteland_Check_List = [WastelandChest];
            List<Check> Colossus_Check_List = [ColossusGreatFairy, ColossusPoH, ColossusShiek];
            List<Check> GerudoFortress_Check_List = [GFChest, HBA];
            List<Check> GerudoValley_Check_List = [GVWaterFallPoH, GVChest, GVCratePoH];
            List<Check> HyruleField_Check_List = [HFOoT, HFNearMarketGrottoChest, HFOpenGrottoChest, HFSalesman, HFSoutheastGrottoChest, HFTektikeGrottoPoH];
            List<Check> LakeHylia_Check_List = [LHChildFishing, LHAdultFishing, LHFreestandingPoH, LHLabDive, LHShootTheSun, LHUnderwaterItem];
            List<Check> KokiriForest_Check_List = [KFMidos, KFKokiriSwordChest, KFStormGrottoChest];
            List<Check> LostWoods_Check_List = [LWNearShortcutGrottoChest, LWOcarinaGame, LWScrubGrottoFront, LWScrubNearBridge, LWSkullKid, LWSkullMask, LWTarget];
            List<Check> SFM_Check_List = [SFMSaria, SFMShiek, SFMWolfosGrotto];
            List<Check> ZoraRiver_Check_List = [ZRFrogsGame, ZRFrogsStorms, ZRNearGrottoPoH, ZROpenGrotto, ZRPoHNearDomain];
            List<Check> ZoraDomain_Check_List = [ZDChest, ZRDivingGame, ZDKingZora];
            List<Check> ZoraFountain_Check_List = [ZFBottomPoH, ZFFreestandingPoH, ZFGreatFairy];
            List<Check> DMT_Check_List = [DMTBiggoron, DMTChest, DMTGreatFairy, DMTPoH, DMTStormsGrotto];
            List<Check> DMC_Check_List = [DMCGreatFairy, DMCShiek, DMCUpperGrotto, DMCVolcanoPoH, DMCWallPoH];
            List<Check> Market_Check_List = [MarketBigPoes, MarketBombchuBowling, MarketRichard, MarketShootingGalleryReward, MarketTreasureChestGame];
            List<Check> HC_Check_List = [HCGreatFairy];
            List<Check> OGC_Check_List = [OGCGreatFairy];
            List<Check> ToT_Check_List = [ToTLACS, ToTShiek];
            List<Check> LLR_Check_List = [LLRMalon, LLRPoH, LLRTalon];
            //Assign checks to region buttons
            List<string> Region_Names = ["Haunted Wasteland", "Desert Colossus", "Gerudo Fortress", "Gerudo Valley", "Hyrule Field", "Lake Hylia", "Kokiri Forest", "Lost Woods", "Sacred Forest Meadow", "Zora River", "Zora Domain", "Zora Fountain", "Death Mountain Trail", "Death Mountain Crater", "Market", "Hyrule Castle", "Outside Ganons Castle", "Lon-Lon-Ranch", "Temple of Time"];
            List<List<Check>> Test = [Wasteland_Check_List, Colossus_Check_List, GerudoFortress_Check_List, GerudoValley_Check_List, HyruleField_Check_List, LakeHylia_Check_List, KokiriForest_Check_List, LostWoods_Check_List, SFM_Check_List, ZoraRiver_Check_List, ZoraDomain_Check_List, ZoraFountain_Check_List, DMT_Check_List, DMC_Check_List, Market_Check_List, HC_Check_List, OGC_Check_List, LLR_Check_List, ToT_Check_List];
            List<RegionButton> RegionButton_List = [Wasteland_Button, Colossus_Button, GerudoFortress_Button, GerudoValley_Button, HyruleField_Button, LakeHylia_Button1, KokiriForest_Button, LostWoods_Button, SFM_Button, ZoraRiver_Button, ZoraDomain_Button, ZoraFountain_Button1, DMT_Button, DMC_Button, Market_Button1, HC_Button, OGC_Button, LLR_Button, ToT_Button1];
            ContextMenuForWOTHHints test123 = new();
            Controls.Add(test123);
            test123.Visible = false;
            for (int i = 0; i < RegionButton_List.Count; i++)
            {
                int index = i;
                RegionButton_List[index].MouseDown += (sender, e) => RegionButton_List[index].ButtonClick(e, wothPanel, Test[index]);
                
                RegionButton_List[index].MouseDown += (sender, e) => AddContextMenu(e,test123, RegionButton_List[index]);
                RegionButton_List[index].RegionName = Region_Names[index];
            }
            //Update WOTH Panel Goals
            test123.ValueChanged += (sender, e) => UpdateWOTHGoals(wothPanel,test123);
            //Duplicate regions mouse down event
            LakeHylia_Button2.MouseDown += (sender, e) => LakeHylia_Button2.ButtonClick(e, wothPanel, LakeHylia_Check_List);
            ZoraFountain_Button2.MouseDown += (sender, e) => ZoraFountain_Button2.ButtonClick(e, wothPanel, ZoraFountain_Check_List);
            Market_Button2.MouseDown += (sender, e) => Market_Button2.ButtonClick(e, wothPanel, Market_Check_List);
            ToT_Button2.MouseDown += (sender, e) => ToT_Button2.ButtonClick(e, wothPanel, ToT_Check_List);
            ZoraDomain_Button2.MouseDown += (sender, e) => ZoraDomain_Button2.ButtonClick(e, wothPanel, ZoraDomain_Check_List);
            //Duplicate regions assign name
            LakeHylia_Button2.RegionName = "Lake Hylia";
            ZoraFountain_Button2.RegionName = "Zora Fountain";
            Market_Button2.RegionName = "Market";
            ToT_Button2.RegionName = "Temple of Time";
            ZoraDomain_Button2.RegionName = "Zora Domain";
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
