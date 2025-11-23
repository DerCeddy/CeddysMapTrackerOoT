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
            MapTracker.WastelandSalesman.RichToolTip.CheckName = Konfig.checkname.WastelandSalesman;
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
            MapTracker.MarketBazaar.RichToolTip.CheckName = Konfig.checkname.MarketBazaar;
            MapTracker.MarketPotionShop.RichToolTip.CheckName = Konfig.checkname.MarketPotionShop;
            MapTracker.MarketBombchuShop.RichToolTip.CheckName = Konfig.checkname.MarketBombchuShop;
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
            MapTracker.ZDShop.RichToolTip.CheckName = Konfig.checkname.ZDShop;
            MapTracker.ZFGreatFairy.RichToolTip.CheckName = Konfig.checkname.ZFGreatFairy;
            MapTracker.ZFFreestandingPoH.RichToolTip.CheckName = Konfig.checkname.ZFFreestandingPoH;
            MapTracker.ZFBottomPoH.RichToolTip.CheckName = Konfig.checkname.ZFBottomPoH;
            MapTracker.KFMidos.RichToolTip.CheckName = Konfig.checkname.KFMidos;
            MapTracker.KFKokiriSwordChest.RichToolTip.CheckName = Konfig.checkname.KFKokiriSwordChest;
            MapTracker.KFStormGrottoChest.RichToolTip.CheckName = Konfig.checkname.KFStormGrottoChest;
            MapTracker.KFShop.RichToolTip.CheckName = Konfig.checkname.KFShop;
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
            MapTracker.KFShop.RichToolTip.CheckLogic = $"\r\n• Nothing";
            //Lost Woods
            MapTracker.LWScrubNearBridge.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.LWSkullKid.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.SariasSong.Item_Name}";
            MapTracker.LWOcarinaGame.RichToolTip.CheckLogic = $"\r\n• Nothing";
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
            MapTracker.WastelandSalesman.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Wallet.Item_Name}";
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
            MapTracker.MarketBazaar.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.MarketPotionShop.RichToolTip.CheckLogic = $"\r\n• Nothing";
            MapTracker.MarketBombchuShop.RichToolTip.CheckLogic = $"\r\n• Nothing";
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
            MapTracker.DMCShiek.RichToolTip.CheckLogic = $"\r\n• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))";
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
            MapTracker.ZDKingZora.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.RutoLetter.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name})) or ({ItemPanel.Bottle2.Item_Name} and ({ItemPanel.Wallet.Item_Name1} or Ganon's Castle Access))\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.ZDShop.RichToolTip.CheckLogic = $"\r\nChild access\r\n• {ItemPanel.Scales.Item_Name} or ({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name})\r\n•Adult access\r\n• {ItemPanel.Bottle2.Item_Name} and ({ItemPanel.Wallet.Item_Name1} or Ganon's Castle Access) and {ItemPanel.ZeldasLullaby.Item_Name}";
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
            MapTracker.ForestEyeSwitchChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount1}";
            MapTracker.ForestBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount2}";
            MapTracker.ForestFloormasterChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• ({ItemPanel.Bow.Item_Name} and {ItemPanel.Strength.Item_Name} and {DungeonInfo.ForestTemple.KeyCount2}) or ({ItemPanel.HoverBoots.Item_Name} and {DungeonInfo.ForestTemple.KeyCount1})";
            MapTracker.ForestRedPoeChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount3}";
            MapTracker.ForestBowChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount3}";
            MapTracker.ForestBluePoeChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount3}";
            MapTracker.ForestFallingCeillingRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount5}";
            MapTracker.ForestBasementChest.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount5}";
            MapTracker.ForestPhantomGanonHeart.RichToolTip.CheckLogic = $"• {ItemPanel.SariasSong.Item_Name} or {ItemPanel.Minuet.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ForestTemple.KeyCount5}\r\n• {DungeonInfo.ForestBossKey.Item_Name}";
            //Fire Temple
            MapTracker.FireNearBossChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))";
            MapTracker.FireFlareDancerChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Hammer.Item_Name}";
            MapTracker.FireBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Hammer.Item_Name}";
            MapTracker.FireBigLavaRoomLowerDoorChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {DungeonInfo.FireTemple.KeyCount1}";
            MapTracker.FireBigLavaRoomBlockedDoorChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount1}";
            MapTracker.FireBoulderMazeLowerChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount3}";
            MapTracker.FireBoulderMazeSideRoomChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount3}";
            MapTracker.FireMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• ({DungeonInfo.FireTemple.KeyCount4} and {ItemPanel.Bow.Item_Name}) or {DungeonInfo.FireTemple.KeyCount5}";
            MapTracker.FireBoulderMazeShortcutChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount5}";
            MapTracker.FireBoulderMazeUpperChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount5} ";
            MapTracker.FireScarecrowChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount5}";
            MapTracker.FireCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {DungeonInfo.FireTemple.KeyCount6}";
            MapTracker.FireMegatonHammerChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• ({DungeonInfo.FireTemple.KeyCount6} and {ItemPanel.HoverBoots.Item_Name} and {ItemPanel.Hammer.Item_Name}) or {DungeonInfo.FireTemple.KeyCount7} ";
            MapTracker.FireHighestGoronChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Hammer.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• ({DungeonInfo.FireTemple.KeyCount6} and {ItemPanel.HoverBoots.Item_Name}) or ({DungeonInfo.FireTemple.KeyCount7} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.SongOfTime.Item_Name}))";
            MapTracker.FireVolvagiaHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Bolero.Item_Name} or (({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}))\r\n• {ItemPanel.Hammer.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name} or {ItemPanel.GoronTunic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name} or ({DungeonInfo.FireTemple.KeyCount7} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.SongOfTime.Item_Name}))\r\n• {DungeonInfo.FireBossKey.Item_Name}";
            //Water Temple
            MapTracker.WaterCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}";
            MapTracker.WaterMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}";
            MapTracker.WaterCrackedWallChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name}) or {DungeonInfo.WaterTemple.KeyCount5}";
            MapTracker.WaterTorchesChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name})";
            MapTracker.WaterBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name} or ({ItemPanel.Bomb.Item_Name} and {ItemPanel.Strength.Item_Name})\r\n• {DungeonInfo.WaterTemple.KeyCount5}";
            MapTracker.WaterCentralPillarChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.ZoraTunic.Item_Name} or (({ItemPanel.RutoLetter.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name})) or ({ItemPanel.Bottle2.Item_Name} and Ganon's Castle Access) and {ItemPanel.Wallet.Item_Name1})\r\n• {DungeonInfo.WaterTemple.KeyCount5} or {ItemPanel.Bow.Item_Name} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name})";
            MapTracker.WaterCentralBowTargetChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name} or {ItemPanel.Hookshot.Item_Name1}";
            MapTracker.WaterLongshotChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {DungeonInfo.WaterTemple.KeyCount5}";
            MapTracker.WaterRiverChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.SongOfTime.Item_Name}\r\n• {DungeonInfo.WaterTemple.KeyCount5}";
            MapTracker.WaterDragonChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• ({ItemPanel.Strength.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.SongOfTime.Item_Name} and {DungeonInfo.WaterTemple.KeyCount5})";
            MapTracker.WaterMorphaHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.IronBoots.Item_Name}\r\n• {DungeonInfo.WaterBossKey.Item_Name}";
            //Shadow Temple
            MapTracker.ShadowMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}";
            MapTracker.ShadowHoverBootsChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name}";
            MapTracker.ShadowCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}";
            MapTracker.ShadowEarlySilverRupeeChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}";
            MapTracker.ShadowInvisibleBladesVisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount1}";
            MapTracker.ShadowInvisibleBladesInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount1}";
            MapTracker.ShadowFallingSpikesLowerChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount1}";
            MapTracker.ShadowFallingSpikesUpperChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount1}";
            MapTracker.ShadowFallingSpikesSwitchChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Strength.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount1}";
            MapTracker.ShadowInvisibleSpikesChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount2}";
            MapTracker.ShadowFreestandingKey.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount2}";
            MapTracker.ShadowWindHintChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount3}";
            MapTracker.ShadowAfterWindEnemyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount3}";
            MapTracker.ShadowAfterWindHiddenChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount3}";
            MapTracker.ShadowSpikeWallsLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount4}";
            MapTracker.ShadowBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount4}";
            MapTracker.ShadowInvisibleFloormasterChest.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.ShadowTemple.KeyCount4}";
            MapTracker.ShadowBongoBongoHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Nocturne.Item_Name}\r\n• {ItemPanel.Dins.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.HoverBoots.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bow.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.ShadowTemple.KeyCount5}\r\n• {DungeonInfo.ShadowBossKey.Item_Name}";
            // Spirit Temple
            MapTracker.SpiritChildBridgeChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}";
            MapTracker.SpiritChildEarlyTorchesChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}";
            MapTracker.SpiritChildClimbNorthChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• (({ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name})) or {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount1}";
            MapTracker.SpiritChildClimbEastChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\n• {ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• (({ItemPanel.Slingshot.Item_Name} or {ItemPanel.Boomerang.Item_Name}) and ({ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name})) or {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount1}";
            MapTracker.SpiritMapChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {DungeonInfo.SpiritTemple.KeyCount3}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount1}";
            MapTracker.SpiritSunBlockRoomChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {DungeonInfo.SpiritTemple.KeyCount3}\r\nAge unknown route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount1}";
            MapTracker.SpiritSilverGauntletsChest.RichToolTip.CheckLogic = $"Child route\r\n• {ItemPanel.Reqiuem.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\nAdult route\r\n• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}) ";
            MapTracker.SpiritCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.SpiritEarlyAdultRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}";
            MapTracker.SpiritFirstMirrorLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}";
            MapTracker.SpiritFirstMirrorRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}";
            MapTracker.SpiritStatueRoomNortheastChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}";
            MapTracker.SpiritStatueRoomHandChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount3}";
            MapTracker.SpiritNearFourArmosChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.MirrorShield.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount4}";
            MapTracker.SpiritHallwayLeftInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount4}";
            MapTracker.SpiritHallwayRightInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount4}";
            MapTracker.SpiritMirrorShieldChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount4}";
            MapTracker.SpiritBossKeyChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}";
            MapTracker.SpiritTopmostChest.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.MirrorShield.Item_Name}\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Bomb.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}";
            MapTracker.SpiritTwinrovaHeart.RichToolTip.CheckLogic = $"• {ItemPanel.Reqiuem.Item_Name} or ((({ItemPanel.EponasSong.Item_Name} and {ItemPanel.HoverBoots.Item_Name}) or {ItemPanel.Hookshot.Item_Name1}) and {ItemPanel.Magic.Item_Name} and {ItemPanel.Lens.Item_Name})\r\n• {ItemPanel.Strength.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.MirrorShield.Item_Name}\r\n• {DungeonInfo.SpiritTemple.KeyCount5}\r\n• {DungeonInfo.SpiritBossKey.Item_Name}";
            //GTG
            MapTracker.GTGLobbyLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Bow.Item_Name}";
            MapTracker.GTGLobbyRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Bow.Item_Name}";
            MapTracker.GTGStalfosChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}";
            MapTracker.GTGBeforeHeavyBlockChest.RichToolTip.CheckLogic = $"•{ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}";
            MapTracker.GTGHeavyBlockFirstChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}";
            MapTracker.GTGHeavyBlockSecondChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}";
            MapTracker.GTGHeavyBlockThirdChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}";
            MapTracker.GTGHeavyBlockFourthChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Strength.Item_Name1}";
            MapTracker.GTGEyeStatueChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}";
            MapTracker.GTGNearScarecrowChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bow.Item_Name}";
            MapTracker.GTGHammerRoomClearChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}";
            MapTracker.GTGHammerRoomSwitchChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Hammer.Item_Name}";
            MapTracker.GTGFreestandingKey.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n•(({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hookshot.Item_Name}) and {ItemPanel.SongOfTime.Item_Name}) or {DungeonInfo.GTG.KeyCount9}";
            MapTracker.GTGMazeRightCentralChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n•(({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hookshot.Item_Name}) and {ItemPanel.SongOfTime.Item_Name}) or {DungeonInfo.GTG.KeyCount9}";
            MapTracker.GTGMazeRightSideChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n•(({ItemPanel.Bomb.Item_Name} or {ItemPanel.Hookshot.Item_Name}) and {ItemPanel.SongOfTime.Item_Name}) or {DungeonInfo.GTG.KeyCount9}";
            MapTracker.GTGUnderwaterSilverRupeeChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.SongOfTime.Item_Name}\r\n• {ItemPanel.IronBoots.Item_Name}";
            MapTracker.GTGBeamosChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.GTGHiddenCeilingChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.GTG.KeyCount3}";
            MapTracker.GTGMazePathFirstChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.GTG.KeyCount4}";
            MapTracker.GTGMazePathSecondChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.GTG.KeyCount6}";
            MapTracker.GTGMazePathThirdChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.GTG.KeyCount7}";
            MapTracker.GTGMazePathFinalChest.RichToolTip.CheckLogic = $"• {ItemPanel.EponasSong.Item_Name} or {ItemPanel.Hookshot.Item_Name1}\r\n• {DungeonInfo.GTG.KeyCount9}";
            //BotW
            MapTracker.BotWFrontLeftFakeWallChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.BotWFrontCenterBombableChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.BotWBackLeftBombableChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.BotWUnderwaterLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.BotWFreestandingKey.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.BotWCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.BotWCenterSkulltulaChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.BotWRightBottomFakeWallChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}";
            MapTracker.BotWFireKeeseChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {DungeonInfo.BotW.KeyCount3}";
            MapTracker.BotWLikeLikeChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {DungeonInfo.BotW.KeyCount3}";
            MapTracker.BotWMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or ({ItemPanel.Strength.Item_Name} and ({DungeonInfo.BotW.KeyCount3} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name})))";
            MapTracker.BotWUnderwaterFrontChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.BotWInvisibleChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.BotWLensofTruthChest.RichToolTip.CheckLogic = $"• {ItemPanel.SongOfStorms.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Ice Cavern
            MapTracker.IceCavernMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.IceCavernCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.IceCavernIronBootsChest.RichToolTip.CheckLogic = $"• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.IceCavernFreestandingPoH.RichToolTip.CheckLogic = $"• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}";
            MapTracker.IceCavernShiek.RichToolTip.CheckLogic = $"• {ItemPanel.RutoLetter.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name}";
            //Kakariko
            MapTracker.KakAnjuasChild.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakAnjuasAdult.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakImpasHouseFreestandingPoH.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakWindmillFreestandingPoH.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.WindmillSong.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakManonRoof.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakOpenGrottoChest.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakRedeadGrottoChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name}";
            MapTracker.KakShootingGalleryReward.RichToolTip.CheckLogic = $"• {ItemPanel.Bow.Item_Name}";
            MapTracker.KakShiek.RichToolTip.CheckLogic = $"• {ItemPanel.ForestMedallion.Item_Name}\r\n• {ItemPanel.FireMedallion.Item_Name}\r\n• {ItemPanel.WaterMedallion.Item_Name}";
            MapTracker.Kak10GoldSkulltulaReward.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.Kak20GoldSkulltulaReward.RichToolTip.CheckLogic = $"• 20 Skulls";
            MapTracker.Kak30GoldSkulltulaReward.RichToolTip.CheckLogic = $"• 30 Skulls";
            MapTracker.Kak40GoldSkulltulaReward.RichToolTip.CheckLogic = $"• 40 Skulls";
            MapTracker.Kak50GoldSkulltulaReward.RichToolTip.CheckLogic = $"• 50 Skulls";
            MapTracker.KakGranny.RichToolTip.CheckLogic = $"• {ItemPanel.Wallet.Item_Name}";
            MapTracker.KakBazaarTopLeft.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakBazaarTopRight.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakBazaarBottomLeft.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakBazaarBottomRight.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakPotionShopTopLeft.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakPotionShopTopRight.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakPotionShopBottomLeft.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.KakPotionShopBottomRight.RichToolTip.CheckLogic = $"• Nothing";
            //Graveyard
            MapTracker.GraveyardShieldGraveChest.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.GraveyardHeartPieceGraveChest.RichToolTip.CheckLogic = $"• {ItemPanel.SunSong.Item_Name}";
            MapTracker.GraveyardRoyalFamilysTombChest.RichToolTip.CheckLogic = $"• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.Magic.Item_Name}\r\n• {ItemPanel.Dins.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name})";
            MapTracker.GraveyardFreestandingPoH.RichToolTip.CheckLogic = $"• {ItemPanel.Beans.Item_Name} or {ItemPanel.Hookshot.Item_Name1}";
            MapTracker.GraveyardDampeGravediggingTour.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.GraveyardDampeRaceHookshotChest.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.GraveyardDampeRaceFreestandingPoH.RichToolTip.CheckLogic = $"• Nothing";
            MapTracker.GraveyardComposerSong.RichToolTip.CheckLogic = $"• {ItemPanel.ZeldasLullaby.Item_Name}";
            //Goron City
            MapTracker.GCDaruniasJoy.RichToolTip.CheckLogic = $"• {ItemPanel.ZeldasLullaby.Item_Name}\r\n• {ItemPanel.SariasSong.Item_Name}";
            MapTracker.GCPotFreestandingPoH.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name}\r\n• {ItemPanel.ZeldasLullaby.Item_Name} or ({ItemPanel.Dins.Item_Name} and {ItemPanel.Magic.Item_Name})";
            MapTracker.GCRollingGoronasChild.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name}";
            MapTracker.GCRollingGoronasAdult.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Strength.Item_Name} or {ItemPanel.Bow.Item_Name}";
            MapTracker.GCMazeLeftChest.RichToolTip.CheckLogic = $"• {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name1}";
            MapTracker.GCMazeCenterChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name1}";
            MapTracker.GCMazeRightChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name1}";
            MapTracker.GCMedigoron.RichToolTip.CheckLogic = $"• {ItemPanel.Bomb.Item_Name} or {ItemPanel.Hammer.Item_Name} or {ItemPanel.Strength.Item_Name}\r\n• {ItemPanel.Wallet.Item_Name}";
            MapTracker.GoronShopTopLeft.RichToolTip.CheckLogic = $"• {ItemPanel.Strength.Item_Name} or {ItemPanel.Bomb.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.ZeldasLullaby.Item_Name} or ({ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            MapTracker.GoronShopTopRight.RichToolTip.CheckLogic = $"• {ItemPanel.Strength.Item_Name} or {ItemPanel.Bomb.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.ZeldasLullaby.Item_Name} or ({ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            MapTracker.GoronShopBottomLeft.RichToolTip.CheckLogic = $"• {ItemPanel.Strength.Item_Name} or {ItemPanel.Bomb.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.ZeldasLullaby.Item_Name} or ({ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            MapTracker.GoronShopBottomRight.RichToolTip.CheckLogic = $"• {ItemPanel.Strength.Item_Name} or {ItemPanel.Bomb.Item_Name} or {ItemPanel.Bow.Item_Name} or {ItemPanel.ZeldasLullaby.Item_Name} or ({ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name})";
            //ToT
            MapTracker.ToTLACS.RichToolTip.CheckLogic = $"• {ItemPanel.SpiritMedallion.Item_Name}\r\n• {ItemPanel.ShadowMedallion.Item_Name}";
            MapTracker.ToTShiek.RichToolTip.CheckLogic = $"• {ItemPanel.ForestMedallion.Item_Name}";
            //Ganons Castle
            MapTracker.GanonsCastleForestTrialChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access";
            MapTracker.GanonsCastleWaterTrialLeftChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access";
            MapTracker.GanonsCastleWaterTrialRightChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access";
            MapTracker.GanonsCastleShadowTrialFrontChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Hookshot.Item_Name} or {ItemPanel.HoverBoots.Item_Name} or {ItemPanel.SongOfTime.Item_Name} or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
            MapTracker.GanonsCastleShadowTrialGoldenGauntletsChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• ({ItemPanel.Hookshot.Item_Name1} and ({ItemPanel.HoverBoots.Item_Name} or ({ItemPanel.Magic.Item_Name} and {ItemPanel.Dins.Item_Name}))) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.FireArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
            MapTracker.GanonsCastleLightTrialFirstLeftChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialSecondLeftChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialThirdLeftChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialFirstRightChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialSecondRightChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialThirdRightChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialInvisibleEnemiesChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}";
            MapTracker.GanonsCastleLightTrialLullabyChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Strength.Item_Name2}\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
            MapTracker.GanonsCastleSpiritTrialCrystalSwitchChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Hookshot.Item_Name}";
            MapTracker.GanonsCastleSpiritTrialInvisibleChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access\r\n• {ItemPanel.Hookshot.Item_Name}\r\n• {ItemPanel.Bomb.Item_Name}";
            MapTracker.GanonsTowerBossKeyChest.RichToolTip.CheckLogic = $"• Ganon's Castle Access";
        }
    }
}
