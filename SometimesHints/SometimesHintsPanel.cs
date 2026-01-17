using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeddyMapTracker.Maptracker;

namespace CeddyMapTracker
{
    public class SometimesHintsPanel : Panel
    {
        public SometimesHintElement[] SingleHints = [];
        public SometimesHintElement[] DualHints = [];
        public decimal Hint_Count = 8;
        public decimal Dual_Hint_Count = 2;
        public List<SometimesHint> SometimesHints = [];
        //Single hints
        public SometimesHintElement Skulls20 = new() { CheckIndex = 11, CheckName = "20 Skulls" };
        public SometimesHintElement BigPoes = new() { CheckIndex = 52, CheckName = "Market Big Poes" };
        public SometimesHintElement Chickens = new() { CheckIndex = 54, CheckName = "Kakariko Chickens" };
        public SometimesHintElement ComposerTorches = new() { CheckIndex = 121, CheckName = "Graveyard Composer Torches Chest" };
        public SometimesHintElement DaruniaJoy = new() { CheckIndex = 56, CheckName = "Goron City Darunia's Joy" };
        public SometimesHintElement FrogsInStorm = new() { CheckIndex = 10, CheckName = "Zora River Frogs in the Storm" };
        public SometimesHintElement GoronPot = new() { CheckIndex = 68, CheckName = "Goron City Goron Pot" };
        public SometimesHintElement GoronCityMazeLeftChest = new() { CheckIndex = 69, CheckName = "Goron City Maze Left Chest" };
        public SometimesHintElement KingZora = new() { CheckIndex = 59, CheckName = "Zora's Domain King Zora unthawed" };
        public SometimesHintElement LabDive = new() { CheckIndex = 57, CheckName = "Lake Hylia Lab Dive" };
        public SometimesHintElement ShootTheSun = new() { CheckIndex = 70, CheckName = "Lake Hylia Shoot the Sun" };
        public SometimesHintElement SkullKid = new() { CheckIndex = 51, CheckName = "Lost Woods Skull Kid" };
        public SometimesHintElement SunSongGrave = new() { CheckIndex = 55, CheckName = "Graveyard Sun Song Grave Chest" };
        public SometimesHintElement TargetInTheWoods = new() { CheckIndex = 50, CheckName = "Lost Woods Target in the Woods" };
        public SometimesHintElement TreasureChestGame = new() { CheckIndex = 53, CheckName = "Market Treasure Chest Game" };
        public SometimesHintElement WastelandTorches = new() { CheckIndex = 61, CheckName = "Haunted Wasteland Chest" };
        public SometimesHintElement ZoraFountainBottom = new() { CheckIndex = 60, CheckName = "Zora Fountain Underwater PoH" };
        public SometimesHintElement HCFairy = new() { CheckIndex = 8, CheckName = "Hyrule Castle Great Fairy" };
        public SometimesHintElement OGCFairy = new() { CheckIndex = 9, CheckName = "Outside Ganon's Castle Great Fairy" };
        public SometimesHintElement FireTempleHammerChest = new() { CheckIndex = 63, CheckName = "Fire Temple Megaton Hammer Chest" };
        public SometimesHintElement FireTempleScarecrowChest = new() { CheckIndex = 64, CheckName = "Fire Temple Scarecrow Chest" };
        public SometimesHintElement WaterTempleCentralPillarChest = new() { CheckIndex = 65, CheckName = "Water Temple Central Pillar Chest" };
        public SometimesHintElement WaterTempleBossKeyChest = new() { CheckIndex = 71, CheckName = "Water Temple Boss Key Chest" };
        public SometimesHintElement WaterTempleRiverChest = new() { CheckIndex = 128, CheckName = "Water Temple River Chest" };
        public SometimesHintElement SpiritTempleSilverGauntletChest = new() { CheckIndex = 129, CheckName = "Spirit Temple Silver Gauntlet Chest" };
        public SometimesHintElement SpiritTempleMirrorShieldChest = new() { CheckIndex = 130, CheckName = "Spirit Temple Mirror Shield Chest" };
        public SometimesHintElement GanonsCastleShadowTrial2 = new() { CheckIndex = 72, CheckName = "Ganon's Castle Golden Gauntlets Chest" };
        public SometimesHintElement GTGUnderwaterSilverRupeeChest = new() { CheckIndex = 66, CheckName = "Gerudo Training Grounds Underwater Silver Rupee Chest" };
        public SometimesHintElement IceCavernFinalChest = new() { CheckIndex = 6, CheckName = "Ice Cavern Final Chest" };
        public SometimesHintElement BoomerangChest = new() { CheckIndex = 62, CheckName = "Jabu-Jabu's Belly Boomerang Chest" };
        public SometimesHintElement ShadowTempleFreestandingKey = new() { CheckIndex = 73, CheckName = "Shadow Temple Freestanding Key" };
        public SometimesHintElement SongFromRoyalTomb = new() { CheckIndex = 122, CheckName = "Song from Royal Tomb" };
        public SometimesHintElement ShiekInForest = new() { CheckIndex = 74, CheckName = "Shiek in Forest" };
        public SometimesHintElement ShiekInTemple = new() { CheckIndex = 75, CheckName = "Shiek in Temple of Time" };
        public SometimesHintElement ShiekInCrater = new() { CheckIndex = 76, CheckName = "Shiek in Crater" };
        public SometimesHintElement ShiekInIceCavern = new() { CheckIndex = 7, CheckName = "Shiek in Ice Cavern" };
        public SometimesHintElement ShiekAtColossus = new() { CheckIndex = 78, CheckName = "Shiek at Desert Colossus" };
        //Dual hints        
        public SometimesHintElement LakeHyliaBeanChecks = new() { CheckIndex = 123, CheckIndexDual = 124, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement BombchuBowling = new() { CheckIndex = 125, CheckIndexDual = 125, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement CastleFairies = new() { CheckIndex = 8, CheckIndexDual = 9, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement ZoraDomainChildChecks = new() { CheckIndex = 131, CheckIndexDual = 132, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement GerudoValleyPoHLedges = new() { CheckIndex = 133, CheckIndexDual = 134, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement HorsebackArchery = new() { CheckIndex = 120, CheckIndexDual = 120, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement BotWDeadHandChecks = new() { CheckIndex = 135, CheckIndexDual = 136, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement FireTempleLowerHammerLoop = new() { CheckIndex = 137, CheckIndexDual = 138, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement GanonsCastleSpiritTrial = new() { CheckIndex = 139, CheckIndexDual = 140, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement ShadowTempleInvisibleBlades = new() { CheckIndex = 141, CheckIndexDual = 142, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement ShadowTempleSpikedWalls = new() { CheckIndex = 143, CheckIndexDual = 144, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement SpiritTempleChildLoop = new() { CheckIndex = 145, CheckIndexDual = 146, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement SpiritTempleColossusHands = new() { CheckIndex = 129, CheckIndexDual = 130, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement SpiritTempleEarlyAdultChecks = new() { CheckIndex = 149, CheckIndexDual = 150, CheckName = "Shiek at Desert Colossus" };
        public SometimesHintElement WaterTempleDarkLinkLoop = new() { CheckIndex = 127, CheckIndexDual = 128, CheckName = "Shiek at Desert Colossus" };

        public class SometimesHintNames()
        {
            public string? Skulls20;
            public string? BigPoes;
            public string? Chickens;
            public string? ComposerTorches;
            public string? DaruniaJoy;
            public string? FrogsInStorm;
            public string? GoronPot;
            public string? GoronCityMazeLeftChest;
            public string? KingZora;
            public string? LabDive;
            public string? ShootTheSun;
            public string? SkullKid;
            public string? SunSongGrave;
            public string? TargetInTheWoods;
            public string? TreasureChestGame;
            public string? WastelandTorches;
            public string? ZoraFountainBottom;
            public string? HCFairy;
            public string? OGCFairy;
            public string? FireTempleHammerChest;
            public string? FireTempleScarecrowChest;
            public string? WaterTempleCentralPillarChest;
            public string? WaterTempleBossKeyChest;
            public string? WaterTempleRiverChest;
            public string? SpiritTempleSilverGauntletChest;
            public string? SpiritTempleMirrorShieldChest;
            public string? GanonsCastleShadowTrial2;
            public string? GTGUnderwaterSilverRupeeChest;
            public string? IceCavernFinalChest;
            public string? BoomerangChest;
            public string? ShadowTempleFreestandingKey;
            public string? SongFromRoyalTomb;
            public string? ShiekInForest;
            public string? ShiekInTemple;
            public string? ShiekInCrater;
            public string? ShiekInIceCavern;
            public string? ShiekAtColossus;
            public string? LakeHyliaBeanChecks;
            public string? BombchuBowling;
            public string? CastleFairies;
            public string? ZoraDomainChildChecks;
            public string? GerudoValleyPoHLedges;
            public string? HorsebackArchery;
            public string? BotWDeadHandChecks;
            public string? FireTempleLowerHammerLoop;
            public string? GanonsCastleSpiritTrial;
            public string? ShadowTempleInvisibleBlades;
            public string? ShadowTempleSpikedWalls;
            public string? SpiritTempleChildLoop;
            public string? SpiritTempleColossusHands;
            public string? SpiritTempleEarlyAdultChecks;
            public string? WaterTempleDarkLinkLoop;
        }
        public SometimesHintsPanel(Point _location)
        {
            Width = 300;
            AutoSize = true;
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Sometimes Hints" , Location = new Point(0,0), ForeColor = Color.White, Size = new Size(120,20) }; 
            Controls.Add(label);
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            AssignNamesToHints();
            SingleHints = [Skulls20, BigPoes, Chickens, ComposerTorches, DaruniaJoy, FrogsInStorm, GoronPot, GoronCityMazeLeftChest, KingZora, LabDive, ShootTheSun, SkullKid, SunSongGrave, TargetInTheWoods, TreasureChestGame, WastelandTorches, ZoraFountainBottom, HCFairy, OGCFairy, FireTempleHammerChest, FireTempleScarecrowChest, WaterTempleCentralPillarChest, WaterTempleBossKeyChest, WaterTempleRiverChest, SpiritTempleSilverGauntletChest, SpiritTempleMirrorShieldChest, GanonsCastleShadowTrial2, GTGUnderwaterSilverRupeeChest, IceCavernFinalChest, BoomerangChest, ShadowTempleFreestandingKey, SongFromRoyalTomb, ShiekInForest, ShiekInTemple, ShiekInCrater, ShiekInIceCavern, ShiekAtColossus];
            DualHints = [LakeHyliaBeanChecks, BombchuBowling, CastleFairies, ZoraDomainChildChecks, GerudoValleyPoHLedges, HorsebackArchery, BotWDeadHandChecks, FireTempleLowerHammerLoop, GanonsCastleSpiritTrial, ShadowTempleInvisibleBlades, ShadowTempleSpikedWalls, SpiritTempleChildLoop, SpiritTempleColossusHands, SpiritTempleEarlyAdultChecks, WaterTempleDarkLinkLoop];                              
        }
        public void GenerateHintsAndStones()
        {
            for (int i = 0; i < Hint_Count; i++)
            {
                //Comboboxes               
                //Gossipstones
                if (Dual_Hint_Count > i)
                {
                    SometimesHint SometimesHint = new("Dual");
                    SometimesHints.Add(SometimesHint);
                    SometimesHint.Location = new Point(0,i * 24 + 24);
                    SometimesHint.ComboBox.Items.AddRange(DualHints);
                    SometimesHint.ComboBox.Sorted = true;
                    Controls.Add(SometimesHint);
                }
                else
                {
                    SometimesHint SometimesHint = new("Single");
                    SometimesHints.Add(SometimesHint);
                    SometimesHint.Location = new Point(0, i * 24 + 24);
                    SometimesHint.ComboBox.Items.AddRange(SingleHints);
                    SometimesHint.ComboBox.Sorted = true;
                    Controls.Add(SometimesHint);
                }
            }
        }
        public void DeleteHintsAndStones()
        {
            foreach (SometimesHint SometimesHint in SometimesHints)
            {
                SometimesHint?.Dispose();
            }        
            SometimesHints.Clear();
        }
        public void AssignNamesToHints()
        {
            StreamReader r = new("SometimesHintNames.json");
            string json = r.ReadToEnd();
            Settings Konfig = JsonConvert.DeserializeObject<Settings>(json); 
            //Single hints
            Skulls20.CheckName = Konfig.sometimesHint.Skulls20;
            BigPoes.CheckName = Konfig.sometimesHint.BigPoes;
            Chickens.CheckName = Konfig.sometimesHint.Chickens;
            ComposerTorches.CheckName = Konfig.sometimesHint.ComposerTorches;
            DaruniaJoy.CheckName = Konfig.sometimesHint.DaruniaJoy;
            FrogsInStorm.CheckName = Konfig.sometimesHint.FrogsInStorm;
            GoronPot.CheckName = Konfig.sometimesHint.GoronPot;
            KingZora.CheckName = Konfig.sometimesHint.KingZora;
            LabDive.CheckName = Konfig.sometimesHint.LabDive;
            ShootTheSun.CheckName = Konfig.sometimesHint.ShootTheSun;
            SkullKid.CheckName = Konfig.sometimesHint.SkullKid;
            SunSongGrave.CheckName = Konfig.sometimesHint.SunSongGrave;
            TargetInTheWoods.CheckName = Konfig.sometimesHint.TargetInTheWoods;
            TreasureChestGame.CheckName = Konfig.sometimesHint.TreasureChestGame;
            WastelandTorches.CheckName = Konfig.sometimesHint.WastelandTorches;
            ZoraFountainBottom.CheckName = Konfig.sometimesHint.ZoraFountainBottom;
            HCFairy.CheckName = Konfig.sometimesHint.HCFairy;
            OGCFairy.CheckName = Konfig.sometimesHint.OGCFairy;
            FireTempleHammerChest.CheckName = Konfig.sometimesHint.FireTempleHammerChest;
            FireTempleScarecrowChest.CheckName = Konfig.sometimesHint.FireTempleScarecrowChest;
            WaterTempleCentralPillarChest.CheckName = Konfig.sometimesHint.WaterTempleCentralPillarChest;
            WaterTempleBossKeyChest.CheckName = Konfig.sometimesHint.WaterTempleBossKeyChest;
            WaterTempleRiverChest.CheckName = Konfig.sometimesHint.WaterTempleRiverChest;
            SpiritTempleSilverGauntletChest.CheckName = Konfig.sometimesHint.SpiritTempleSilverGauntletChest;
            SpiritTempleMirrorShieldChest.CheckName = Konfig.sometimesHint.SpiritTempleMirrorShieldChest;
            GanonsCastleShadowTrial2.CheckName = Konfig.sometimesHint.GanonsCastleShadowTrial2;
            GTGUnderwaterSilverRupeeChest.CheckName = Konfig.sometimesHint.GTGUnderwaterSilverRupeeChest;
            IceCavernFinalChest.CheckName = Konfig.sometimesHint.IceCavernFinalChest;
            BoomerangChest.CheckName = Konfig.sometimesHint.BoomerangChest;
            ShadowTempleFreestandingKey.CheckName = Konfig.sometimesHint.ShadowTempleFreestandingKey;
            SongFromRoyalTomb.CheckName = Konfig.sometimesHint.SongFromRoyalTomb;
            ShiekInForest.CheckName = Konfig.sometimesHint.ShiekInForest;
            ShiekInTemple.CheckName = Konfig.sometimesHint.ShiekInTemple;
            ShiekInCrater.CheckName = Konfig.sometimesHint.ShiekInCrater;
            ShiekInIceCavern.CheckName = Konfig.sometimesHint.ShiekInIceCavern;
            ShiekAtColossus.CheckName = Konfig.sometimesHint.ShiekAtColossus;
            //Dual hints
            LakeHyliaBeanChecks.CheckName = Konfig.sometimesHint.LakeHyliaBeanChecks;
            BombchuBowling.CheckName = Konfig.sometimesHint.BombchuBowling;
            CastleFairies.CheckName = Konfig.sometimesHint.CastleFairies;
            ZoraDomainChildChecks.CheckName = Konfig.sometimesHint.ZoraDomainChildChecks;
            GerudoValleyPoHLedges.CheckName = Konfig.sometimesHint.GerudoValleyPoHLedges;
            HorsebackArchery.CheckName = Konfig.sometimesHint.HorsebackArchery;
            BotWDeadHandChecks.CheckName = Konfig.sometimesHint.BotWDeadHandChecks;
            FireTempleLowerHammerLoop.CheckName = Konfig.sometimesHint.FireTempleLowerHammerLoop;
            GanonsCastleSpiritTrial.CheckName = Konfig.sometimesHint.GanonsCastleSpiritTrial;
            ShadowTempleInvisibleBlades.CheckName = Konfig.sometimesHint.ShadowTempleInvisibleBlades;
            ShadowTempleSpikedWalls.CheckName = Konfig.sometimesHint.ShadowTempleSpikedWalls;
            SpiritTempleChildLoop.CheckName = Konfig.sometimesHint.SpiritTempleChildLoop;
            SpiritTempleColossusHands.CheckName = Konfig.sometimesHint.SpiritTempleColossusHands;
            SpiritTempleEarlyAdultChecks.CheckName = Konfig.sometimesHint.SpiritTempleEarlyAdultChecks;
            WaterTempleDarkLinkLoop.CheckName = Konfig.sometimesHint.WaterTempleDarkLinkLoop;
    }
        
    }
}
