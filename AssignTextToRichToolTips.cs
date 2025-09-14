using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeddyMapTracker.Maptracker;

namespace CeddyMapTracker
{
    public partial class Form1 : Form
    {
        public void AssignTextToRichToolTips()
        {
            StreamReader r = new("checknames.json");
            string json = r.ReadToEnd();
            Settings Konfig = JsonConvert.DeserializeObject<Settings>(json);           
            MapTracker.WastelandChest.RichToolTip.CheckName = Konfig.checkname.WastelandChest;
            MapTracker.ColossusShiek.RichToolTip.CheckName = Konfig.checkname.ColossusShiek;
            MapTracker.ColossusPoH.RichToolTip.CheckName = Konfig.checkname.ColossusPoH;
            MapTracker.ColossusGreatFairy.RichToolTip.CheckName = Konfig.checkname.ColossusGreatFairy;
            MapTracker.GFChest.RichToolTip.CheckName = Konfig.checkname.GFChest;
            MapTracker.HBA.RichToolTip.CheckName = Konfig.checkname.HBA;
            MapTracker.GVWaterFallPoH.RichToolTip.CheckName = Konfig.checkname.GVWaterFallPoH;
            MapTracker.GVCratePoH.RichToolTip.CheckName = Konfig.checkname.GVCratePoH;
            MapTracker.GVChest.RichToolTip.CheckName = Konfig.checkname.GVChest;
            MapTracker.LHLabDive.RichToolTip.CheckName = Konfig.checkname.LHLabDive;
            MapTracker.LHFreestandingPoH.RichToolTip.CheckName = Konfig.checkname.LHFreestandingPoH;
            MapTracker.LHUnderwaterItem.RichToolTip.CheckName = Konfig.checkname.LHUnderwaterItem;
            MapTracker.LHChildFishing.RichToolTip.CheckName = Konfig.checkname.LHChildFishing;
            MapTracker.LHAdultFishing.RichToolTip.CheckName = Konfig.checkname.LHAdultFishing;
            MapTracker.LHShootTheSun.RichToolTip.CheckName = Konfig.checkname.LHShootTheSun;
            MapTracker.HFTektikeGrottoPoH.RichToolTip.CheckName = Konfig.checkname.HFTektikeGrottoPoH;
            MapTracker.HFNearMarketGrottoChest.RichToolTip.CheckName = Konfig.checkname.HFNearMarketGrottoChest;
            MapTracker.HFOoT.RichToolTip.CheckName = Konfig.checkname.HFOoT;
            MapTracker.HFSoutheastGrottoChest.RichToolTip.CheckName = Konfig.checkname.HFSoutheastGrottoChest;
            MapTracker.HFOpenGrottoChest.RichToolTip.CheckName = Konfig.checkname.HFOpenGrottoChest;
            MapTracker.HFSalesman.RichToolTip.CheckName = Konfig.checkname.HFSalesman;
            MapTracker.MarketShootingGalleryReward.RichToolTip.CheckName = Konfig.checkname.MarketShootingGalleryReward;
            MapTracker.MarketRichard.RichToolTip.CheckName = Konfig.checkname.MarketRichard;
            MapTracker.MarketTreasureChestGame.RichToolTip.CheckName = Konfig.checkname.MarketTreasureChestGame;
            MapTracker.MarketBigPoes.RichToolTip.CheckName = Konfig.checkname.MarketBigPoes;
            MapTracker.MarketBombchuBowling.RichToolTip.CheckName = Konfig.checkname.MarketBombchuBowling;
            MapTracker.HCGreatFairy.RichToolTip.CheckName = Konfig.checkname.HCGreatFairy;
            MapTracker.OGCGreatFairy.RichToolTip.CheckName = Konfig.checkname.OGCGreatFairy;
            MapTracker.DMTPoH.RichToolTip.CheckName = Konfig.checkname.DMTPoH;
            MapTracker.DMTChest.RichToolTip.CheckName = Konfig.checkname.DMTChest;
            MapTracker.DMTStormsGrotto.RichToolTip.CheckName = Konfig.checkname.DMTStormsGrotto;
            MapTracker.DMTGreatFairy.RichToolTip.CheckName = Konfig.checkname.DMTGreatFairy;
            MapTracker.DMTBiggoron.RichToolTip.CheckName = Konfig.checkname.DMTBiggoron;
            MapTracker.DMCWallPoH.RichToolTip.CheckName = Konfig.checkname.DMCWallPoH;
            MapTracker.DMCUpperGrotto.RichToolTip.CheckName = Konfig.checkname.DMCUpperGrotto;
            MapTracker.DMCShiek.RichToolTip.CheckName = Konfig.checkname.DMCShiek;
            MapTracker.DMCVolcanoPoH.RichToolTip.CheckName = Konfig.checkname.DMCVolcanoPoH;
            MapTracker.DMCGreatFairy.RichToolTip.CheckName = Konfig.checkname.DMCGreatFairy;
            MapTracker.ZROpenGrotto.RichToolTip.CheckName = Konfig.checkname.ZROpenGrotto;
            MapTracker.ZRNearGrottoPoH.RichToolTip.CheckName = Konfig.checkname.ZRNearGrottoPoH;
            MapTracker.ZRPoHNearDomain.RichToolTip.CheckName = Konfig.checkname.ZRPoHNearDomain;
            MapTracker.ZRFrogsStorms.RichToolTip.CheckName = Konfig.checkname.ZRFrogsStorms;
            MapTracker.ZRFrogsGame.RichToolTip.CheckName = Konfig.checkname.ZRFrogsGame;
            MapTracker.ZDChest.RichToolTip.CheckName = Konfig.checkname.ZDChest;
            MapTracker.ZDDivingGame.RichToolTip.CheckName = Konfig.checkname.ZRDivingGame;
            MapTracker.ZDKingZora.RichToolTip.CheckName = Konfig.checkname.ZDKingZora;
            MapTracker.ZFGreatFairy.RichToolTip.CheckName = Konfig.checkname.ZFGreatFairy;
            MapTracker.ZFFreestandingPoH.RichToolTip.CheckName = Konfig.checkname.ZFFreestandingPoH;
            MapTracker.ZFBottomPoH.RichToolTip.CheckName = Konfig.checkname.ZFBottomPoH;
            MapTracker.KFMidos.RichToolTip.CheckName = Konfig.checkname.KFMidos;
            MapTracker.KFKokiriSwordChest.RichToolTip.CheckName = Konfig.checkname.KFKokiriSwordChest;
            MapTracker.KFStormGrottoChest.RichToolTip.CheckName = Konfig.checkname.KFStormGrottoChest;
            MapTracker.LWScrubNearBridge.RichToolTip.CheckName = Konfig.checkname.LWScrubNearBridge;
            MapTracker.LWSkullKid.RichToolTip.CheckName = Konfig.checkname.LWSkullKid;
            MapTracker.LWOcarinaGame.RichToolTip.CheckName = Konfig.checkname.LWOcarinaGame;
            MapTracker.LWTarget.RichToolTip.CheckName = Konfig.checkname.LWTarget;
            MapTracker.LWNearShortcutGrottoChest.RichToolTip.CheckName = Konfig.checkname.LWNearShortcutGrottoChest;
            MapTracker.LWSkullMask.RichToolTip.CheckName = Konfig.checkname.LWSkullMask;
            MapTracker.LWScrubGrottoFront.RichToolTip.CheckName = Konfig.checkname.LWScrubGrottoFront;
            MapTracker.SFMWolfosGrotto.RichToolTip.CheckName = Konfig.checkname.SFMWolfosGrotto;
            MapTracker.SFMSaria.RichToolTip.CheckName = Konfig.checkname.SFMSaria;
            MapTracker.SFMShiek.RichToolTip.CheckName = Konfig.checkname.SFMShiek;
            MapTracker.LLRTalon.RichToolTip.CheckName = Konfig.checkname.LLRTalon;
            MapTracker.LLRMalon.RichToolTip.CheckName = Konfig.checkname.LLRMalon;
            MapTracker.LLRPoH.RichToolTip.CheckName = Konfig.checkname.LLRPoH;
            //Bombchu Bowling Zora Fountain Great Fairy
            //Check logic
            //Kokiri Forest
            MapTracker.KFMidos.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.KFKokiriSwordChest.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.KFStormGrottoChest.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.SongOfStorms.Item_Name}";
            //Lost Woods
            MapTracker.LWScrubNearBridge.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LWSkullKid.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.SariasSong.Item_Name}";
            MapTracker.LWOcarinaGame.RichToolTip.CheckLogic = $"\r\n• NothingOcarina";
            MapTracker.LWTarget.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Slingshot.Item_Name}";
            MapTracker.LWNearShortcutGrottoChest.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} ";
            MapTracker.LWSkullMask.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LWScrubGrottoFront.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or (({ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}) and {ItemPanel.Hammer.Item_Name})";
            //SFM
            MapTracker.SFMSaria.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.SFMShiek.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}";
            MapTracker.SFMWolfosGrotto.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or (({ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}) and {ItemPanel.Hammer.Item_Name})";
            //Hyrule Field
            MapTracker.HFNearMarketGrottoChest.RichToolTip.CheckLogic = $"\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.HFOoT.RichToolTip.CheckLogic = $"\n• {ItemPanel.KokiriStone.Item_Name}\n• {ItemPanel.GoronStone.Item_Name}\n• {ItemPanel.ZoraStone.Item_Name}";
            MapTracker.HFOpenGrottoChest.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.HFSoutheastGrottoChest.RichToolTip.CheckLogic = $"\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.HFSalesman.RichToolTip.CheckLogic = $"\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.HFTektikeGrottoPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name} or {ItemPanel.Scales.Item_Name1}" ;
            //LLR
            MapTracker.LLRMalon.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LLRTalon.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LLRPoH.RichToolTip.CheckLogic = $"\r\n• Nothing";
            //Lake Hylia
            MapTracker.LHChildFishing.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LHUnderwaterItem.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Scales.Item_Name}";
            MapTracker.LHAdultFishing.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Beans.Item_Name}";
            MapTracker.LHFreestandingPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Beans.Item_Name}";
            MapTracker.LHLabDive.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Scales.Item_Name1}";
            MapTracker.LHShootTheSun.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Bow.Item_Name}";
            //Gerudo Valley
            MapTracker.GVWaterFallPoH.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.GVCratePoH.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.GVChest.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hammer.Item_Name}";
            //Gerudo Fortress
            MapTracker.HBA.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.EponasSong.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}";
            MapTracker.GFChest.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.EponasSong.Item_Name} and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name})) or {ItemPanel.Hookshot.Item_Name1}";
            //Wasteland
            MapTracker.WastelandChest.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}\r\n• ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name}) or {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}";
            //Desert Colossus
            MapTracker.ColossusGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.ColossusPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Beans.Item_Name}";
            MapTracker.ColossusShiek.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            //Market
            MapTracker.MarketShootingGalleryReward.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.MarketRichard.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.MarketBombchuBowling.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.MarketTreasureChestGame.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Lens.Item_Name}";
            MapTracker.MarketBigPoes.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.EponasSong.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Bottle2.Item_Name} or ({ItemPanel.RutoLetter.Item_Name} and (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name})) ";
            //Hyrule Castle
            MapTracker.HCGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Outside Ganons Castle
            MapTracker.OGCGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Strength.Item_Name2}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //DMT
            MapTracker.DMTPoH.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.DMTChest.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.DMTStormsGrotto.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.DMTGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.DMTBiggoron.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.AdultTradeItems.Item_Name3}";
            //DMC
            MapTracker.DMCShiek.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name})) ";
            MapTracker.DMCVolcanoPoH.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.HoverBoots.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.Bolero.Item_Name})) or ({ItemPanel.Beans.Item_Name} and {ItemPanel.Bolero.Item_Name})";
            MapTracker.DMCWallPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name} or ({ItemPanel.Bolero.Item_Name} and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))";
            MapTracker.DMCUpperGrotto.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.DMCGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name} or ({ItemPanel.Bolero.Item_Name} and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name})) \r\n• {ItemPanel.Hammer.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Zora River
            MapTracker.ZROpenGrotto.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.ZRNearGrottoPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.HoverBoots.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.ZRPoHNearDomain.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.HoverBoots.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.ZRFrogsStorms.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.ZRFrogsGame.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.EponasSong.Item_Name}\r\n• {ItemPanel.SariasSong.Item_Name}\r\n• {ItemPanel.SunSong.Item_Name}\r\n• {ItemPanel.SongOfTime.Item_Name}\r\n• {ItemPanel.SongOfStorms.Item_Name}";
            // Zora's Domain
            MapTracker.ZDDivingGame.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Scales.Item_Name} or ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name})";
            MapTracker.ZDChest.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Scales.Item_Name} or ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name})";
            MapTracker.ZDKingZora.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.RutoLetter.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name})) or ({ItemPanel.Bottle2.Item_Name} and ({ItemPanel.Wallet.Item_Name1} or Ganons Castle Access))\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Zora Fountain
            MapTracker.ZFFreestandingPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name} \r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.ZFGreatFairy.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} \r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.ZFBottomPoH.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name} \r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Deku Tree
            MapTracker.DekuTreeMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeSlingshotRoomSideChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeSlingshotChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeCompassRoomSideChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeBasementChest.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}";
            MapTracker.DekuTreeQueenGohmaHeart.RichToolTip.CheckLogic = $"• {ItemPanel.KokiriSword.Item_Name}\r\n• {ItemPanel.Slingshot.Item_Name}";
            //Dodongos Cavern
            MapTracker.DodongosCavernMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.DodongosCavernCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.DodongosCavernBombFlowerPlatformChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or ({ItemPanel.Hammer.Item_Name} and {ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            MapTracker.DodongosCavernBombBagChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or ({ItemPanel.Hammer.Item_Name} and {ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            MapTracker.DodongosCavernEndofBridgeChest.RichToolTip.CheckLogic = $"{ItemPanel.Bomb.Item_Name} or ({ItemPanel.Hammer.Item_Name} and ({ItemPanel.Strength.Item_Name} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name})))";
            MapTracker.DodongosCavernBossRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name}";
            MapTracker.DodongosCavernKingDodongoHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name}";
            // Jabu Jabus Belly
            MapTracker.JabuJabusBellyBoomerangChest.RichToolTip.CheckLogic = $"• ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name}";
            MapTracker.JabuJabusBellyCompassChest.RichToolTip.CheckLogic = $"• ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.Boomerang.Item_Name}";
            MapTracker.JabuJabusBellyMapChest.RichToolTip.CheckLogic = $"• ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.Boomerang.Item_Name}";
            MapTracker.JabuJabusBellyBarinadeHeart.RichToolTip.CheckLogic = $"• ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name}\r\n• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.Boomerang.Item_Name}";
            //Forest Temple
            MapTracker.ForestFirstRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}";
            MapTracker.ForestFirstStalfosRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}";
            MapTracker.ForestRaisedIslandCourtyardChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or {ItemPanel.SongOfTime.Item_Name}";
            MapTracker.ForestMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or {ItemPanel.SongOfTime.Item_Name}";
            MapTracker.ForestWellChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or {ItemPanel.SongOfTime.Item_Name}";
            MapTracker.ForestEyeSwitchChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount1}";
            MapTracker.ForestBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount2}";
            MapTracker.ForestFloormasterChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• ({ItemPanel.Bow.Item_Name} and {ItemPanel.Strength.Item_Name} and {Keys.Forest_SmallKeys.KeyCount2}) or ({ItemPanel.HoverBoots.Item_Name} and {Keys.Forest_SmallKeys.KeyCount1})";
            MapTracker.ForestRedPoeChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount3}";
            MapTracker.ForestBowChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount3}";
            MapTracker.ForestBluePoeChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount3}";
            MapTracker.ForestFallingCeillingRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount5}";
            MapTracker.ForestBasementChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount5}";
            MapTracker.ForestPhantomGanonHeart.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {Keys.Forest_SmallKeys.KeyCount5}\r\n• {ItemPanel.ForestBossKey.Item_Name}";
            //Fire Temple
            MapTracker.FireNearBossChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireFlareDancerChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBossKeyChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBigLavaRoomLowerDoorChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBigLavaRoomBlockedDoorChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBoulderMazeLowerChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBoulderMazeSideRoomChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireMapChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBoulderMazeShortcutChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireBoulderMazeUpperChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireScarecrowChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireCompassChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireMegatonHammerChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireHighestGoronChest.RichToolTip.CheckLogic = $"";
            MapTracker.FireVolvagiaHeart.RichToolTip.CheckLogic = $"";
            //Water Temple
            MapTracker.WaterCompassChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterMapChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterCrackedWallChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterTorchesChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterBossKeyChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterCentralPillarChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterCentralBowTargetChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterLongshotChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterRiverChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterDragonChest.RichToolTip.CheckLogic = $"";
            MapTracker.WaterMorphaHeart.RichToolTip.CheckLogic = $"";
            //Shadow Temple
            MapTracker.ShadowMapChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowHoverBootsChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowCompassChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowEarlySilverRupeeChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowInvisibleBladesVisibleChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowInvisibleBladesInvisibleChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowFallingSpikesLowerChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowFallingSpikesUpperChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowInvisibleSpikesChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowFallingSpikesSwitchChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowFreestandingKey.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowWindHintChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowAfterWindEnemyChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowAfterWindHiddenChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowSpikeWallsLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowBossKeyChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowInvisibleFloormasterChest.RichToolTip.CheckLogic = $"";
            MapTracker.ShadowBongoBongoHeart.RichToolTip.CheckLogic = $"\r\n• ";
            // Spirit Temple
            MapTracker.SpiritChildBridgeChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}";
            MapTracker.SpiritChildEarlyTorchesChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}";
            MapTracker.SpiritChildClimbNorthChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount5}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {Keys.Spirit_SmallKeys.KeyCount3}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• (({ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name})) or {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount1}";
            MapTracker.SpiritChildClimbEastChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount5}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {Keys.Spirit_SmallKeys.KeyCount3}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• (({ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name})) or {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount1}";
            MapTracker.SpiritMapChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {Keys.Spirit_SmallKeys.KeyCount3}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount1}";
            MapTracker.SpiritSunBlockRoomChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {Keys.Spirit_SmallKeys.KeyCount3}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount1}";
            MapTracker.SpiritSilverGauntletsChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {Keys.Spirit_SmallKeys.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name1}\r\n• {Keys.Spirit_SmallKeys.KeyCount3}) ";
            MapTracker.SpiritCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritEarlyAdultRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritFirstMirrorLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritFirstMirrorRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritStatueRoomNortheastChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritStatueRoomHandChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritNearFourArmosChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritHallwayLeftInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritHallwayRightInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritMirrorShieldChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritTopmostChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            MapTracker.SpiritTwinrovaHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})";
            //GTG
            MapTracker.GTGLobbyLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGLobbyRightChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGStalfosChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGBeforeHeavyBlockChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHeavyBlockFirstChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHeavyBlockSecondChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHeavyBlockThirdChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHeavyBlockFourthChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGEyeStatueChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGNearScarecrowChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHammerRoomClearChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHammerRoomSwitchChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGFreestandingKey.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazeRightCentralChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazeRightSideChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGUnderwaterSilverRupeeChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGBeamosChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGHiddenCeilingChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazePathFirstChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazePathSecondChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazePathThirdChest.RichToolTip.CheckLogic = $"";
            MapTracker.GTGMazePathFinalChest.RichToolTip.CheckLogic = $"";
            //BotW
            MapTracker.BotWFrontLeftFakeWallChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWFrontCenterBombableChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWBackLeftBombableChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWUnderwaterLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWFreestandingKey.RichToolTip.CheckLogic = $"";
            MapTracker.BotWCompassChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWCenterSkulltulaChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWRightBottomFakeWallChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWFireKeeseChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWLikeLikeChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWMapChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWUnderwaterFrontChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWInvisibleChest.RichToolTip.CheckLogic = $"";
            MapTracker.BotWLensofTruthChest.RichToolTip.CheckLogic = $"";
            //Ice Cavern
            MapTracker.IceCavernMapChest.RichToolTip.CheckLogic = $"";
            MapTracker.IceCavernCompassChest.RichToolTip.CheckLogic = $"";
            MapTracker.IceCavernIronBootsChest.RichToolTip.CheckLogic = $"";
            MapTracker.IceCavernFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.IceCavernShiek.RichToolTip.CheckLogic = $"";
            //Kakariko
            MapTracker.KakAnjuasChild.RichToolTip.CheckLogic = $"";
            MapTracker.KakAnjuasAdult.RichToolTip.CheckLogic = $"";
            MapTracker.KakImpasHouseFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.KakWindmillFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.WindmillSong.RichToolTip.CheckLogic = $"";
            MapTracker.KakManonRoof.RichToolTip.CheckLogic = $"";
            MapTracker.KakOpenGrottoChest.RichToolTip.CheckLogic = $"";
            MapTracker.KakRedeadGrottoChest.RichToolTip.CheckLogic = $"";
            MapTracker.KakShootingGalleryReward.RichToolTip.CheckLogic = $"";
            MapTracker.KakShiek.RichToolTip.CheckLogic = $"";
            MapTracker.Kak10GoldSkulltulaReward.RichToolTip.CheckLogic = $"";
            MapTracker.Kak20GoldSkulltulaReward.RichToolTip.CheckLogic = $"";
            MapTracker.Kak30GoldSkulltulaReward.RichToolTip.CheckLogic = $"";
            MapTracker.Kak40GoldSkulltulaReward.RichToolTip.CheckLogic = $"";
            MapTracker.Kak50GoldSkulltulaReward.RichToolTip.CheckLogic = $"";
            //Graveyard
            MapTracker.GraveyardShieldGraveChest.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardHeartPieceGraveChest.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardRoyalFamilysTombChest.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardDampeGravediggingTour.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardDampeRaceHookshotChest.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardDampeRaceFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.GraveyardComposerSong.RichToolTip.CheckLogic = $"";
            //Goron City
            MapTracker.GCDaruniasJoy.RichToolTip.CheckLogic = $"";
            MapTracker.GCPotFreestandingPoH.RichToolTip.CheckLogic = $"";
            MapTracker.GCRollingGoronasChild.RichToolTip.CheckLogic = $"";
            MapTracker.GCRollingGoronasAdult.RichToolTip.CheckLogic = $"";
            MapTracker.GCMazeLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GCMazeCenterChest.RichToolTip.CheckLogic = $"";
            MapTracker.GCMazeRightChest.RichToolTip.CheckLogic = $"";
            //ToT
            MapTracker.ToTLACS.RichToolTip.CheckLogic = $"";
            MapTracker.ToTShiek.RichToolTip.CheckLogic = $"";
            //Ganons Castle
            MapTracker.GanonsCastleForestTrialChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleWaterTrialLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleWaterTrialRightChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleShadowTrialFrontChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleShadowTrialGoldenGauntletsChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialFirstLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialSecondLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialThirdLeftChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialFirstRightChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialSecondRightChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialThirdRightChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialInvisibleEnemiesChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleLightTrialLullabyChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleSpiritTrialCrystalSwitchChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsCastleSpiritTrialInvisibleChest.RichToolTip.CheckLogic = $"";
            MapTracker.GanonsTowerBossKeyChest.RichToolTip.CheckLogic = $"";
        }
    }
}
