using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CeddyMapTracker
{
    public partial class Maptracker
    {
        public int tokensAvailable = 0;
        public bool has_explosives = false;
        public bool can_blast_or_smash = false;
        public int wastelandcrossing = 0;
        public int desertaccess = 0;
        public bool has_firesource = false;
        public int craterplatformaccess = 0;
        public int has_or_can_red_tunic = 0;
        public bool has_or_can_get_gerudocard = false;
        public bool has_longshot = false;
        public bool has_gold_scale = false;
        public bool has_bottle = false;
        public bool can_get_beans = false;
        public bool rainbowbridge;
        public int forest_keys = 0;
        public int fire_keys = 0;
        public int water_keys = 0;
        public int spirit_keys = 0;
        public int shadow_keys = 0;
        public int gtg_keys = 0;
        public int botw_keys = 0;
        public int gtg_available_checks;
        public Color Available = Color.Lime;
        public Color NotAvailable = Color.Red;
        public Color coulddo = Color.Yellow;
        public Color CanSee = Color.LightBlue;
        public Color OoLwithBombchus = Color.Blue;
        static bool Has(Item ItemToCheck)
        {
            bool State;
            if (ItemToCheck.State == 0)
            {
                State = false;
            }
            else
            {
                State = true;
            }
            return State;
        }       
        public void Sphere0Checks()
        {           
            LLRTalon.color = Available;
            LLRMalon.color = Available;
            LLRPoH.color = Available;
            KakAnjuasChild.ForeColor = Available;
            KakAnjuasAdult.ForeColor = Available;
            KakImpasHouseFreestandingPoH.ForeColor = Available;
            KakWindmillFreestandingPoH.ForeColor = Available;
            KakManonRoof.ForeColor = Available;
            KakOpenGrottoChest.ForeColor = Available;
            WindmillSong.ForeColor = Available;
            KFMidos.color = Available;        
            KFKokiriSwordChest.color = Available;
            GVCratePoH.color = Available;
            GVWaterFallPoH.color = Available;
            LHChildFishing.color = Available;
            GraveyardShieldGraveChest.ForeColor = Available;
            GraveyardDampeGravediggingTour.ForeColor = Available;
            GraveyardDampeRaceFreestandingPoH.ForeColor = Available;
            GraveyardDampeRaceHookshotChest.ForeColor = Available;
            ZROpenGrotto.color = Available;
            DMTPoH.color = Available;
            LWOcarinaGame.color = Available;
            LWScrubNearBridge.color = Available;
            LWSkullMask.color = Available;
            SFMSaria.color = Available;
            MarketShootingGalleryReward.color = Available;
            MarketRichard.color = Available;
            HFOpenGrottoChest.color = Available;            
        }
        public void ItemLogic(ItemPanel i, DungeonInfoPanel DungeonInfoPanel)
        {          
            //Forest_SmallKeys = 
            tokensAvailable = 13;
            gtg_available_checks = 0;
            ItemLogic_Helper(i);
            ItemLogic_BotW(i, DungeonInfoPanel);
            ItemLogic_Castles(i);
            ItemLogic_DekuTree(i);
            ItemLogic_DesertColossus(i);
            ItemLogic_DMC(i);
            ItemLogic_DMT(i);
            ItemLogic_DodongosCavern(i);
            ItemLogic_FireTemple(i, DungeonInfoPanel);
            ItemLogic_ForestTemple(i, DungeonInfoPanel);           
            ItemLogic_GanonsCastle(i);
            ItemLogic_GerudoFortress(i);
            ItemLogic_GerudoValley(i);
            ItemLogic_GoronCity(i);
            ItemLogic_Graveyard(i);
            ItemLogic_GTG(i, DungeonInfoPanel);
            ItemLogic_HyruleField(i);
            ItemLogic_IceCavern(i);
            ItemLogic_Jabu(i);
            ItemLogic_Kakariko(i);
            ItemLogic_KokiriForest(i);
            ItemLogic_LakeHylia(i);
            ItemLogic_LostWoods(i);
            ItemLogic_Market(i);
            //ItemLogic_ScrubShuffle(i);
            ItemLogic_SFM(i);
            ItemLogic_ShadowTemple(i, DungeonInfoPanel);
            ItemLogic_ShopShuffle(i);
            ItemLogic_SpiritTemple(i, DungeonInfoPanel);
            ItemLogic_ToT(i);
            ItemLogic_Wasteland(i);
            ItemLogic_WaterTemple(i, DungeonInfoPanel);
            ItemLogic_ZoraDomain(i);
            ItemLogic_ZoraFountain(i);
            ItemLogic_ZoraRiver(i);         
            ItemLogic_Skulltulas(i);
            UpdateCheckColors();
            UpdateDenseLocations();
            return;
        }               
    }

}
