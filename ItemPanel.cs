using CeddyMapTracker.Properties;
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
    public partial class ItemPanel : UserControl
    {
        public Item Bomb = new() { ItemPicture = Resources.OoT3D_Bomb_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bomb_Icon_bw, Item_Name = "Bomb" };
        public Item ZeldasLullaby = new() { ItemPicture = Resources.zeldas_lullaby_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.zeldas_lullaby_bw_32x40, Item_Name = "Zeldas Lullaby" };
        public Item EponasSong = new() { ItemPicture = Resources.epona_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.epona_bw_32x40, Item_Name = "Eponas Song" };
        public Item SariasSong = new() { ItemPicture = Resources.saria_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.saria_bw_32x40, Item_Name = "Sarias Song" };
        public Item SunSong = new() { ItemPicture = Resources.suns_song_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.suns_song_bw_32x40, Item_Name = "Sun Song" };
        public Item SongOfTime = new() { ItemPicture = Resources.song_of_time_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.song_of_time_bw_32x40, Item_Name = "Song of Time" };
        public Item SongOfStorms = new() { ItemPicture = Resources.song_of_storms_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.song_of_storms_bw_32x40, Item_Name = "Song of Storms" };
        public Item Minuet = new() { ItemPicture = Resources.minuet_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.minuet_bw_32x40, Item_Name = "Minuet" };
        public Item Bolero = new() { ItemPicture = Resources.bolero_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.bolero_bw_32x40, Item_Name = "Bolero" };
        public Item Serenade = new() { ItemPicture = Resources.serenade_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.serenade_bw_32x40, Item_Name = "Serenade" };
        public Item Nocturne = new() { ItemPicture = Resources.nocturne_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.nocturne_bw_32x40, Item_Name = "Nocturne" };
        public Item Reqiuem = new() { ItemPicture = Resources.requiem_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.requiem_bw_32x40, Item_Name = "Requiem" };
        public Item Prelude = new() { ItemPicture = Resources.prelude_32x40, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.prelude_bw_32x40, Item_Name = "Prelude" };
        public Item Hammer = new() { ItemPicture = Resources.OoT3D_Megaton_Hammer_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Megaton_Hammer_Icon_bw, Item_Name = "Hammer" };
        public Item Strength = new() { ItemPicture = Resources.OoT3D_Goron_Bracelet_Icon, State = 0, MaxCount = 3, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Goron_Bracelet_Icon_bw, ItemPicture1 = Resources.OoT3D_Silver_Gauntlets_Icon, ItemPicture2 = Resources.OoT3D_Golden_Gauntlets_Icon, Item_Name = "Strength" };
        public Item Bow = new() { ItemPicture = Resources.OoT3D_Fairy_Bow_Icon, MaxCount = 1, MinCount = 0, State = 0, ItemPicture_bw = Resources.OoT3D_Fairy_Bow_Icon_bw, Item_Name = "Bow" };
        public Item Wallet = new() { ItemPicture = Resources.OoT3D_Adult_s_Wallet_Icon, ItemPicture_bw = Resources.OoT3D_Adult_s_Wallet_Icon_bw, ItemPicture1 = Resources.OoT3D_Giant_s_Wallet_Icon, MaxCount = 2, MinCount = 0, State = 0, Item_Name = "Wallet" };
        public Item Bottle2 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw, Item_Name = "Bottle" };
        public Item Bottle3 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw, Item_Name = "Bottle" };
        public Item Bottle4 = new() { ItemPicture = Resources.OoT3D_Bottle_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bottle_Icon_bw, Item_Name = "Bottle" };
        public Item BiggoronSword = new() { ItemPicture = Resources.OoT3D_Biggoron_s_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Biggoron_s_Sword_Icon_bw, Item_Name = "Biggoron Sword" };
        public Item MasterSword = new() { ItemPicture = Resources.OoT3D_Master_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Master_Sword_Icon_bw, Item_Name = "Master Sword" };
        public Item KokiriSword = new() { ItemPicture = Resources.OoT3D_Kokiri_Sword_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Sword_Icon_bw, Item_Name = "Kokiri Sword" };
        public Item Slingshot = new() { ItemPicture = Resources.OoT3D_Fairy_Slingshot_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fairy_Slingshot_Icon_bw, Item_Name = "Slingshot" };
        public Item Boomerang = new() { ItemPicture = Resources.OoT3D_Boomerang_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boomerang_Icon_bw, Item_Name = "Boomerang" };
        public Item Nuts = new() { ItemPicture = Resources.OoT3D_Deku_Nut_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Deku_Nut_Icon_bw, Item_Name = "Nuts" };
        public Item Sticks = new() { ItemPicture = Resources.OoT3D_Deku_Stick_Icon, ItemPicture_bw = Resources.OoT3D_Deku_Stick_Icon_bw, State = 0, MaxCount = 1, MinCount = 0, Item_Name = "Sticks" };
        public Item AdultTradeItems = new() { ItemPicture = Resources.OoT3D_Prescription_Icon, ItemPicture_bw = Resources.OoT3D_Prescription_Icon_bw, State = 0, MaxCount = 4, MinCount = 0, ItemPicture1 = Resources.OoT3D_Eyeball_Frog_Icon, ItemPicture2 = Resources.OoT3D_World_s_Finest_Eyedrops_Icon, ItemPicture3 = Resources.OoT3D_Claim_Check_Icon, Item_Name = "Adult Trade" };
        public Item ChildTradeItems = new() { ItemPicture = Resources.OoT3D_Keaton_Mask_Icon, ItemPicture1 = Resources.OoT3D_Skull_Mask_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Keaton_Mask_Icon_bw, Item_Name = "Child Trade" };
        public Item Ocarina = new() { ItemPicture = Resources.OoT3D_Fairy_Ocarina_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = Resources.OoT3D_Ocarina_of_Time_Icon, ItemPicture_bw = Resources.OoT3D_Fairy_Ocarina_Icon_bw, Item_Name = "Ocarina" };
        public Item Dins = new() { ItemPicture = Resources.OoT3D_Din_s_Fire_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Din_s_Fire_Icon_bw, Item_Name = "Dins" };
        public Item FaroresWind = new() { ItemPicture = Resources.OoT3D_Farore_s_Wind_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Farore_s_Wind_Icon_bw, Item_Name = "Farores Wind" };
        public Item NayrusLove = new() { ItemPicture = Resources.OoT3D_Nayru_s_Love_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Nayru_s_Love_Icon_bw, Item_Name = "Nayrus Love" };
        public Item FireArrow = new() { ItemPicture = Resources.OoT3D_Fire_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fire_Arrow_Icon_bw, Item_Name = "Fire Arrows" };
        public Item IceArrow = new() { ItemPicture = Resources.OoT3D_Ice_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Ice_Arrow_Icon_bw, Item_Name = "Ice Arrows" };
        public Item LightArrow = new() { ItemPicture = Resources.OoT3D_Light_Arrow_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Light_Arrow_Icon_bw, Item_Name = "Light Arrows" };
        public Item Hookshot = new() { ItemPicture = Resources.OoT3D_Hookshot_Icon, ItemPicture1 = Resources.OoT3D_Longshot_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hookshot_Icon_bw, Item_Name = "Hookshot" };
        public Item DekuShield = new() { ItemPicture = Resources.OoT3D_Deku_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Deku_Shield_Icon_bw, Item_Name = "Deku Shield" };
        public Item HylianShield = new() { ItemPicture = Resources.OoT3D_Hylian_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hylian_Shield_Icon_bw, Item_Name = "Hylian Shield" };
        public Item MirrorShield = new() { ItemPicture = Resources.OoT3D_Mirror_Shield_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Mirror_Shield_Icon_bw, Item_Name = "Mirror Shield" };
        public Item KokiriBoots = new() { ItemPicture = Resources.OoT3D_Kokiri_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Boots_Icon_bw };
        public Item IronBoots = new() { ItemPicture = Resources.OoT3D_Iron_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Iron_Boots_Icon_bw, Item_Name = "Iron Boots" };
        public Item HoverBoots = new() { ItemPicture = Resources.OoT3D_Hover_Boots_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Hover_Boots_Icon_bw, Item_Name = "Hover Boots" };
        public Item KokiriTunic = new() { ItemPicture = Resources.OoT3D_Kokiri_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Kokiri_Tunic_Icon_bw };
        public Item GoronTunic = new() { ItemPicture = Resources.OoT3D_Goron_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Goron_Tunic_Icon_bw, Item_Name = "Goron Tunic" };
        public Item ZoraTunic = new() { ItemPicture = Resources.OoT3D_Zora_Tunic_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Zora_Tunic_Icon_bw, Item_Name = "Zora Tunic" };
        public Item Lens = new() { ItemPicture = Resources.OoT3D_Lens_of_Truth_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Lens_of_Truth_Icon_bw, Item_Name = "Lens" };
        public Item Scales = new() { ItemPicture = Resources.OoT3D_Silver_Scale_Icon, State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Silver_Scale_Icon_bw, ItemPicture1 = Resources.OoT3D_Golden_Scale_Icon, Item_Name = "Scale" };
        public Item Beans = new() { ItemPicture = Resources.OoT3D_Magic_Bean_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Magic_Bean_Icon_bw, Item_Name = "Beans" };
        public Item RutoLetter = new() { ItemPicture = Resources.OoT3D_Ruto_s_Letter_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Ruto_s_Letter_Icon_bw, Item_Name = "Letter" };
        public Item Bombchu = new() { ItemPicture = Resources.OoT3D_Bombchu_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Bombchu_Icon_bw, Item_Name = "Bombchu" };
        public Item GerudoCard = new() { ItemPicture = Resources.OoT3D_Gerudo_Token_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Gerudo_Token_Icon_bw, Item_Name = "Gerudo Token" };
        public Item Magic = new() { ItemPicture = Resources.Magic, State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = Resources.Magic2, ItemPicture_bw = Resources.Magic_BW, Item_Name = "Magic" };
        public Item ForestMedallion = new() { ItemPicture = Resources.OoT3D_Forest_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Forest_Medallion_Icon_bw, Item_Name = "Forest Medallion" };
        public Item FireMedallion = new() { ItemPicture = Resources.OoT3D_Fire_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Fire_Medallion_Icon_bw, Item_Name = "Fire Medallion" };
        public Item WaterMedallion = new() { ItemPicture = Resources.OoT3D_Water_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Water_Medallion_Icon_bw, Item_Name = "Water Medallion" };
        public Item ShadowMedallion = new() { ItemPicture = Resources.OoT3D_Shadow_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Shadow_Medallion_Icon_bw, Item_Name = "Shadow Medallion" };
        public Item SpiritMedallion = new() { ItemPicture = Resources.OoT3D_Spirit_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spirit_Medallion_Icon_bw, Item_Name = "Spirit Medallion" };
        public Item LightMedallion = new() { ItemPicture = Resources.OoT3D_Light_Medallion_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Light_Medallion_Icon_bw, Item_Name = "Light Medallion" };
        public Item KokiriStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_the_Forest_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_the_Forest_Icon_bw, Item_Name = "Kokiri Stone" };
        public Item GoronStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_Fire_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_Fire_Icon_bw, Item_Name = "Goron Stone" };
        public Item ZoraStone = new() { ItemPicture = Resources.OoT3D_Spiritual_Stone_of_Water_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Spiritual_Stone_of_Water_Icon_bw, Item_Name = "Zora Stone" };
        public Item Agony = new() { ItemPicture = Resources.OoT3D_Shard_of_Agony_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Shard_of_Agony_Icon_bw };
        public Item DoubleDefense = new() { ItemPicture = Resources.OoT3D_Heart_Container_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Heart_Container_Icon_bw };
        public Item GoMode = new() { ItemPicture = Resources.go_mode_32x32, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.go_mode_bw_32x32 };
        public Item ForestBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Forest Boss Key" };
        public Item FireBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Fire Boss Key" };
        public Item WaterBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Water Boss Key" };
        public Item ShadowBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Shadow Boss Key" };
        public Item SpiritBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Spirit Boss Key" };       
        public List<int> Goallabel_States = [];
        private int distanceX = 49;
        private int startX = 8;
        private int startY = 9;
        private int distanceY = 49;
        public int State
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
        private int _state;
        public ItemPanel(Point location)
        {
            InitializeComponent();          
            Location = location;         
        }
        public void LoadItems()
        {
            List<Item> list = [Sticks, Nuts, Bomb, Bow, FireArrow, Dins, Slingshot, Ocarina, Bombchu, Hookshot, IceArrow, FaroresWind, Boomerang, Lens, Beans, Hammer, LightArrow, NayrusLove, RutoLetter, Bottle2, Bottle3, Bottle4, AdultTradeItems, ChildTradeItems];
            for (int i = 0; i < list.Count; i++)
            {
                
                var temp = i;
                list[temp].Image = list[temp].ItemPicture_bw;
                list[temp].ValueChanged += (sender, e) => State = 1;
                Controls.Add(list[i]);
                switch (i)
                {
                    case < 6:
                        list[i].Location = new Point(i * distanceX + startX, startY);
                        break;
                    case < 12:
                        list[i].Location = new Point((i - 6) * distanceX + startX, 1 * distanceY + startY);
                        break;
                    case < 18:
                        list[i].Location = new Point((i - 12) * distanceX + startX, 2 * distanceY + startY);
                        break;
                    case < 24:
                        list[i].Location = new Point((i - 18) * distanceX + startX, 3 * distanceY + startY);
                        break;
                }
            }
        }
        public void LoadEquips()
        {
            List<Item> list = [KokiriSword, MasterSword, BiggoronSword, Agony, GerudoCard, DekuShield, HylianShield, MirrorShield, Strength, Scales, Wallet, KokiriTunic, GoronTunic, ZoraTunic, GoMode, DoubleDefense, Magic, KokiriBoots, IronBoots, HoverBoots];
            for (int i = 0; i < list.Count; i++)
            {
                var temp = i;
                list[i].Image = list[i].ItemPicture_bw;
                Controls.Add(list[i]);
                list[i].ValueChanged += (sender, e) => State = 1;
                switch (i)
                {
                    case < 5:
                        list[i].Location = new Point(i * distanceX + startX, startY + 206);
                        break;
                    case < 11:
                        list[i].Location = new Point((i - 5) * distanceX + startX, 1 * distanceY + startY + 206);
                        break;
                    case < 17:
                        list[i].Location = new Point((i - 11) * distanceX + startX, 2 * distanceY + startY + 206);
                        break;
                    case < 23:
                        list[i].Location = new Point((i - 17) * distanceX + startX, 3 * distanceY + startY + 206);
                        break;
                }
            }
            SkulltulaTracker skulltulatracker = new(new Point(253, 200));
            Controls.Add(skulltulatracker);
        }
        public void LoadQuestItems()
        {
            List<Item> list = [KokiriStone, GoronStone, ZoraStone, ForestMedallion, FireMedallion, WaterMedallion, ShadowMedallion, SpiritMedallion, LightMedallion];
            for (int i = 0; i < list.Count; i++)
            {               
                Goallabel_States.Add(0);
                var formId = i;
                MedallionLabel goallabel = new();
                list[i].Image = list[i].ItemPicture_bw;
                Controls.Add(list[i]);
                Controls.Add(goallabel);
                list[i].ValueChanged += (sender, e) => State = 1;            
                list[i].MouseWheel += (sender, e) => goallabel.Scroll(e);
                switch (i)
                {
                    case < 3:
                        list[i].Location = new Point(i * distanceX + 10 + 144, 3 * distanceY + startY + 206);
                        goallabel.Location = new Point((i + 3) * distanceX + 1, 3 * distanceY + startY + 246);
                        break;
                    case < 10:
                        list[i].Location = new Point((i - 3) * distanceX + 8, startY + 410);
                        goallabel.Location = new Point((i - 3) * distanceX + 1, startY + 452);
                        break;
                }
            }         
        }
        public void LoadSongs()
        {
            List<Item> list = [ZeldasLullaby, EponasSong, SariasSong, SunSong, SongOfTime, SongOfStorms, Minuet, Bolero, Serenade, Nocturne, Reqiuem, Prelude];
            for (int i = 0; i < list.Count; i++)
            {
                var temp = i;
                Gossipstone gossipstone = new(new Point(342, i * 41 + 5)) { Size = new Size(24, 24) };
                Controls.Add(gossipstone);
                list[i].Size = new Size(30,42);
                list[i].SizeMode = PictureBoxSizeMode.Normal;
                list[i].Image = list[i].ItemPicture_bw;
                Controls.Add(list[i]);
                list[i].ValueChanged += (sender, e) => State = 1;
                list[i].Location = new Point(308, i * 41);
            }
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
