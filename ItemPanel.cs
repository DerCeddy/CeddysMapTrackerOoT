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
        public Item Bomb = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Bombs_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Bombs_N64_bw.png"), Item_Name = "Bomb" };
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
        public Item Hammer = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Hammer_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Hammer_N64_bw.png"), Item_Name = "Hammer" };
        public Item Strength = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Goron's_Bracelet_N64.png"), State = 0, MaxCount = 3, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Goron's_Bracelet_N64_bw.png"), ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Silver_Gauntlets_N64.png"), ItemPicture2 = (Bitmap)Image.FromFile("Textures/N64/Golden_Gauntlets_N64.png"), Item_Name = "Strength" };
        public Item Bow = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Fairy_Bow_N64.png"), MaxCount = 1, MinCount = 0, State = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Fairy_Bow_N64_bw.png"), Item_Name = "Bow" };
        public Item Wallet = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Adult_Wallet_N64.png"), ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Adult_Wallet_N64_bw.png"), ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Giant's_Wallet_N64.png"), MaxCount = 2, MinCount = 0, State = 0, Item_Name = "Wallet" };
        public Item Bottle2 = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64_bw.png"), Item_Name = "Bottle" };
        public Item Bottle3 = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64_bw.png"), Item_Name = "Bottle" };
        public Item Bottle4 = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Empty_Bottle_N64_bw.png"), Item_Name = "Bottle" };
        public Item BiggoronSword = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Biggoron's_Sword_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Biggoron's_Sword_N64_bw.png"), Item_Name = "Biggoron Sword" };
        public Item MasterSword = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Master_Sword_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Master_Sword_N64_bw.png"), Item_Name = "Master Sword" };
        public Item KokiriSword = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Sword_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Sword_N64_bw.png"), Item_Name = "Kokiri Sword" };
        public Item Slingshot = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Slingshot_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Slingshot_N64_bw.png"), Item_Name = "Slingshot" };
        public Item Boomerang = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Boomerang_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Boomerang_N64_bw.png"), Item_Name = "Boomerang" };
        public Item Nuts = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Nuts_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Nuts_N64_bw.png"), Item_Name = "Nuts" };
        public Item Sticks = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Sticks_N64.png"), ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Sticks_N64_bw.png"), State = 0, MaxCount = 1, MinCount = 0, Item_Name = "Sticks" };
        public Item AdultTradeItems = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Prescription_N64.png"), ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Prescription_N64_bw.png"), State = 0, MaxCount = 4, MinCount = 0, ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Eyeball_Frog_N64.png"), ItemPicture2 = (Bitmap)Image.FromFile("Textures/N64/World's_Finest_Eye_Drops_N64.png"), ItemPicture3 = (Bitmap)Image.FromFile("Textures/N64/Claim_Check_N64.png"), Item_Name = "Adult Trade" };
        public Item ChildTradeItems = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Keaton_Mask_N64.png"), ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Skull_Mask_N64.png"), State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Keaton_Mask_N64_bw.png"), Item_Name = "Child Trade" };
        public Item Ocarina = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Fairy_Ocarina_N64.png"), State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Ocarina_of_Time_N64.png"), ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Fairy_Ocarina_N64_bw.png"), Item_Name = "Ocarina" };
        public Item Dins = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Dins_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Dins_N64_bw.png"), Item_Name = "Dins" };
        public Item FaroresWind = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Farore's_Wind_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Farore's_Wind_N64_bw.png"), Item_Name = "Farores Wind" };
        public Item NayrusLove = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Nayru's_Love_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Nayru's_Love_N64_bw.png"), Item_Name = "Nayrus Love" };
        public Item FireArrow = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Fire_Arrows_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Fire_Arrows_N64_bw.png"), Item_Name = "Fire Arrows" };
        public Item IceArrow = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Ice_Arrows_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Ice_Arrows_N64_bw.png"), Item_Name = "Ice Arrows" };
        public Item LightArrow = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Light_Arrow_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Light_Arrow_N64_bw.png"), Item_Name = "Light Arrows" };
        public Item Hookshot = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Hookshot_N64.png"), ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Longshot_N64.png"), State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Hookshot_N64_bw.png"), Item_Name = "Hookshot" };
        public Item DekuShield = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Deku_Shield_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Deku_Shield_N64_bw.png"), Item_Name = "Deku Shield" };
        public Item HylianShield = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Hylian_Shield_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Hylian_Shield_N64_bw.png"), Item_Name = "Hylian Shield" };
        public Item MirrorShield = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Mirror_Shield_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Mirror_Shield_N64_bw.png"), Item_Name = "Mirror Shield" };
        public Item KokiriBoots = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Boots_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Boots_N64_bw.png") };
        public Item IronBoots = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Iron_Boots_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Iron_Boots_N64_bw.png"), Item_Name = "Iron Boots" };
        public Item HoverBoots = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Hover_Boots_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Hover_Boots_N64_bw.png"), Item_Name = "Hover Boots" };
        public Item KokiriTunic = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Tunic_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Kokiri_Tunic_N64_bw.png") };
        public Item GoronTunic = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Goron_Tunic_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Goron_Tunic_N64_bw.png"), Item_Name = "Goron Tunic" };
        public Item ZoraTunic = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Zora_Tunic_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Zora_Tunic_N64_bw.png"), Item_Name = "Zora Tunic" };
        public Item Lens = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Lens_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Lens_N64_bw.png"), Item_Name = "Lens" };
        public Item Scales = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Silver_Scale_N64.png"), State = 0, MaxCount = 2, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Silver_Scale_N64_bw.png"), ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Golden_Scale_N64.png"), Item_Name = "Scale" };
        public Item Beans = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Beans_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Beans_N64_bw.png"), Item_Name = "Beans" };
        public Item RutoLetter = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Letter_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Letter_N64_bw.png"), Item_Name = "Letter" };
        public Item Bombchu = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Bombchu_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Bombchu_N64_bw.png"), Item_Name = "Bombchu" };
        public Item GerudoCard = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Gerudo's_Card_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Gerudo's_Card_N64_bw.png"), Item_Name = "Gerudo Token" };
        public Item Magic = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Magic.png"), State = 0, MaxCount = 2, MinCount = 0, ItemPicture1 = (Bitmap)Image.FromFile("Textures/N64/Magic2.png"), ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Magic_BW.png"), Item_Name = "Magic" };
        public Item ForestMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Forest_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Forest_Medallion_Icon_N64_bw.png"), Item_Name = "Forest Medallion" };
        public Item FireMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Fire_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Fire_Medallion_Icon_N64_bw.png"), Item_Name = "Fire Medallion" };
        public Item WaterMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Water_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Water_Medallion_Icon_N64_bw.png"), Item_Name = "Water Medallion" };
        public Item ShadowMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Shadow_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Shadow_Medallion_Icon_N64_bw.png"), Item_Name = "Shadow Medallion" };
        public Item SpiritMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Spirit_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Spirit_Medallion_Icon_N64_bw.png"), Item_Name = "Spirit Medallion" };
        public Item LightMedallion = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Light_Medallion_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Light_Medallion_Icon_N64_bw.png"), Item_Name = "Light Medallion" };
        public Item KokiriStone = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_the_Forest_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_the_Forest_Icon_N64_bw.png"), Item_Name = "Kokiri Stone" };
        public Item GoronStone = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_Fire_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_Fire_Icon_N64_bw.png"), Item_Name = "Goron Stone" };
        public Item ZoraStone = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_Water_Icon_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Spiritual_Stone_of_Water_Icon_N64_bw.png"), Item_Name = "Zora Stone" };
        public Item Agony = new() { ItemPicture = (Bitmap)Image.FromFile("Textures/N64/Stone_of_Agony_N64.png"), State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = (Bitmap)Image.FromFile("Textures/N64/Stone_of_Agony_N64_bw.png") };
        public Item DoubleDefense = new() { ItemPicture = Resources.OoT3D_Heart_Container_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Heart_Container_Icon_bw };
        public Item GoMode = new() { ItemPicture = Resources.go_mode_32x32, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.go_mode_bw_32x32 };
        public Item ForestBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Forest Boss Key" };
        public Item FireBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Fire Boss Key" };
        public Item WaterBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Water Boss Key" };
        public Item ShadowBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Shadow Boss Key" };
        public Item SpiritBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Spirit Boss Key" };       
        public List<int> Goallabel_States = [];
        public List<Item> Items = [];
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
