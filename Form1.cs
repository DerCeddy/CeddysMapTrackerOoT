using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Drawing;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public partial class Form1 : Form
    {  
        public ItemPanel ItemPanel = new(new Point(0, 0));
        public SometimesHintsPanel SometimesHints = new(new Point(420, 360));
        public WOTHPanel WotHPanel = new(new Point(380, 0));
        public AlwaysHintsPanel AlwaysHints = new(new Point(420, 150));
        public ImportantHintPanel ImportantHint = new(new Point(380,700));
        public Maptracker? MapTracker;
        public SettingsPanel Settings = new(new Point(0, 0));
        //public KeyPanel Keys;
        public Stats Stats = new(new Point(0, 700));
        public DungeonInfoPanel DungeonInfo = new() { Location = new Point(0,456)};
        public Form1()
        {        
            InitializeComponent();                                                                       
            MapTracker = new(WotHPanel,new Point(720, 0), Stats); 
            AutoScaleMode = AutoScaleMode.None;
            MapTracker.AutoScaleMode = AutoScaleMode.None;
            //Keys = new(new Point(640, 0));    
            Settings.Visible = false;
            SettingsButton SettingsButton = new (new Point (0, 660));
            SettingsButton.MouseDown += (sender, e) => SettingsButton.ClickEvent(Settings);
            //DungeonCounter dungeoncounter = new(maptracker);
            //Add ContextWheel
            ContextMenuForWOTHHints ContextWheel = new();
            MapTracker.MouseDown += (sender, e) => MapTracker.GetRegionName(e, ContextWheel);
            foreach(DungeonButton button in MapTracker.DungeonButtons)
            {
                button.MouseDown += (sender, e) => button.AddContextMenu(e, ContextWheel, button);
            }
            foreach (RegionButton button in MapTracker.RegionButtons)
            {
                button.MouseDown += (sender, e) => button.AddContextMenu(e, ContextWheel, button);
            }
            MapTracker.Controls.Add(ContextWheel);
            ContextWheel.Visible = false;
            ContextWheel.ValueChanged += (sender, e) => MapTracker.UpdateWOTHGoals(WotHPanel, ImportantHint, ContextWheel);
            /*
            foreach(Region Region in MapTracker.DenseRegions)
            {
                if (Region.RegionButton != null)
                {
                    Region.RegionButton.MouseDown += (sender, e) => MapTracker.AddContextMenu(e, ContextWheel, Region);
                }
                if (Region.DungeonButton != null)
                {
                    Region.DungeonButton.MouseDown += (sender, e) => MapTracker.AddContextMenu(e, ContextWheel, Region.DungeonButton);
                }
            }
            */
            Controls.Add(WotHPanel);           
            Controls.Add(AlwaysHints);           
            Controls.Add(SometimesHints);           
            Controls.Add(MapTracker);         
            Controls.Add(Stats);
            Controls.Add(SettingsButton);
            Controls.Add(ItemPanel);
            Controls.Add(Settings);          
            ItemPanel.LoadItems();
            ItemPanel.LoadEquips();
            ItemPanel.LoadQuestItems();
            ItemPanel.LoadSongs(); 
            //Controls.Add(Keys); 
            Controls.Add(DungeonInfo);
            /*
            List<Keys> SmallKeys = [Keys.Forest_SmallKeys, Keys.Fire_SmallKeys, Keys.Water_SmallKeys, Keys.Shadow_SmallKeys, Keys.Spirit_SmallKeys, Keys.BotW_SmallKeys, Keys.GTG_SmallKeys];
            List<Item> BossKeys = [ItemPanel.ForestBossKey, ItemPanel.FireBossKey, ItemPanel.WaterBossKey, ItemPanel.ShadowBossKey, ItemPanel.SpiritBossKey];                    
            Keys.LoadSmallKeys(SmallKeys);
            Keys.LoadBossKeys(BossKeys);
            */
            //Precise locations
            Stats.Location = new Point(MapTracker.Location.X, MapTracker.Location.Y);
            Stats.BringToFront();
            AlwaysHints.Location = new Point(WotHPanel.Location.X, WotHPanel.Size.Height + 1);
            SometimesHints.Location = new Point(AlwaysHints.Location.X, AlwaysHints.Size.Height + AlwaysHints.Location.Y + 1);
            //Controls.Add(dungeoncounter);
            //Load Hints
            AlwaysHints.DrawPanel();
            SometimesHints.GenerateHintsAndStones();
            //Load logic for the first time
            MapTracker.Sphere0Checks();
            MapTracker.ItemLogic(ItemPanel, DungeonInfo);
            MapTracker.MarketPotionShop.UpdateColor();
            //Stats
            MapTracker.UpdateStatVariables(Stats);
            MapTracker.ValueChanged += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
            MapTracker.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            //Update checks and stats
            ItemPanel.ValueChanged += (sender,e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
            ItemPanel.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            //Update checks and stats
            DungeonInfo.ValueChanged += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
            DungeonInfo.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            //Update checks and stats after changing shop prices
            foreach(Control c  in MapTracker.Controls)
            {
                if(c != null && c is ShopButton ShopButton)
                {
                    ShopButton.ValueChanged += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
                }
            } 
            //Settingspanel assign functions
            Settings.button1.MouseDown += (sender,e) => Settings.ConfirmSettings(this);
            Settings.button1.MouseDown += (sender, e) => UpdateLocationsOfTrackerElements();
            Settings.Load_Preset_Button.MouseDown += (sender, e) => Settings.LoadPreset(ItemPanel, this, SometimesHints, AlwaysHints, WotHPanel, MapTracker);
            Settings.Load_Preset_Button.MouseDown += (sender, e) => UpdateLocationsOfTrackerElements();
            Settings.Load_Preset_Button.MouseDown += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            Settings.changeStyleButton1.MouseDown += (sender, e) => Settings.changeStyleButton1.OnClick(ItemPanel);
            Settings.ValueChanged += (sender, e) => SetShuffleOptionsForMaptracker(Settings);
            Settings.ExpensiveMerchants.ValueChanged += (sender, e) => MapTracker.AddExpensiveMerchants();
            Settings.ShopShuffle.ValueChanged += (sender, e) => MapTracker.AddShopShuffle();
            Settings.DungeonERShuffle.ValueChanged += (sender, e) => MapTracker.AddDungeonER();
            Settings.BlueFireArrows.ValueChanged += (sender, e) => ChangeBlueFireArrowMode();
            Settings.ValueChanged += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
            //SettingsPanel.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            //Update text color for richtooltip
            AssignTextToRichToolTips();
            //Initialize color-coded function for tooltips          
            foreach(Control c in MapTracker.Controls)
            {
                if(c is Check check && c != null)
                {
                    check.MouseEnter += (sender, e) => check.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);
                }
                if(c is ShopButton ShopButton && c != null)
                {
                    ShopButton.MouseEnter += (sender, e) => ShopButton.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);
                }
                
            }  
            foreach(DungeonButton DungeonButtons in MapTracker.DungeonButtons)
            {              
                foreach (Region_Panel_Check c in DungeonButtons.RegionPanel.Checks)
                {
                    c.MouseEnter += (sender, e) => c.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);                   
                }
                DungeonButtons.MouseEnter += (sender, e) => DungeonButtons.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);
            }
            foreach (RegionButton RegionButtons in MapTracker.RegionButtons)
            {
                foreach (Region_Panel_Check c in RegionButtons.RegionPanel.Checks)
                {
                    c.MouseEnter += (sender, e) => c.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);
                }
            }
            //Assign tooltips to Goron City and Zora's Domain Shops
            List<ShopPanelCheck> KakAndGCShopChecks = [MapTracker.GoronShopTopLeft, MapTracker.GoronShopTopRight, MapTracker.GoronShopBottomLeft, MapTracker.GoronShopBottomRight, MapTracker.KakBazaarTopLeft, MapTracker.KakBazaarTopRight, MapTracker.KakBazaarBottomLeft, MapTracker.KakBazaarBottomRight, MapTracker.KakPotionShopTopLeft, MapTracker.KakPotionShopTopRight, MapTracker.KakPotionShopBottomLeft, MapTracker.KakPotionShopBottomRight];
            foreach (ShopPanelCheck spc in KakAndGCShopChecks)
            {
                spc.MouseEnter += (sender, e) => spc.RichToolTip.RichToolTipTextChanged(ItemPanel, DungeonInfo, MapTracker);
            }
            MapTracker.ExpensiveMerchantShuffle = false;
            MapTracker.ShopShuffle = false;
            MapTracker.AddExtraChecks();
            MapTracker.AddDungeonER();
            UpdateLocationsOfTrackerElements();
            //Test for automatic checking of hints
            foreach (AlwaysHint Alwayshint in AlwaysHints.AlwaysHintsList)
            {
                Alwayshint.Gossipstone.ValueChanged += (sender, e) => { Alwayshint.CheckCheckOnMaptracker(MapTracker,Alwayshint.Gossipstone, Alwayshint.AlwaysHintIndex); };
                Alwayshint.Gossipstone.ValueChanged += (sender, e) => { Alwayshint.Gossipstone.UpdateImage(); };
                Alwayshint.Gossipstone.ValueChanged += (sender, e) => { MapTracker.UpdateStatVariables(Stats); };
                Alwayshint.Gossipstone2.ValueChanged += (sender, e) => { Alwayshint.CheckCheckOnMaptracker(MapTracker, Alwayshint.Gossipstone2, Alwayshint.AlwaysHintIndex2); };
                Alwayshint.Gossipstone2.ValueChanged += (sender, e) => { Alwayshint.Gossipstone2.UpdateImage(); };
                Alwayshint.Gossipstone2.ValueChanged += (sender, e) => { MapTracker.UpdateStatVariables(Stats); };
            }
            AssignFunctionsToGossipstonesInSometimesPanel(Stats);
            //Dungeon Info           
            List<BindingList<Region_Panel_Check>> DungeonCheckLists = [MapTracker.ForestTemple_Check_List, MapTracker.FireTemple_Check_List, MapTracker.WaterTemple_Check_List, MapTracker.ShadowTemple_Check_List, MapTracker.SpiritTemple_Check_List, MapTracker.BotW_Check_List, MapTracker.GTG_Check_List];           
            for (int i = 0; DungeonInfo.DungeonInfoElements.Count > i; i++)
            {
                var temp = i;
                DungeonInfo.DungeonInfoElements[temp].Checks = MapTracker.RegionWithKeys[temp].Checks;
                foreach (Region_Panel_Check Check in MapTracker.RegionWithKeys[temp].Checks)
                {
                    Check.MouseDown += (sender, e) => MarkCheckAndUpdateKeyCount(e, Check, DungeonInfo.DungeonInfoElements[temp], MapTracker.RegionWithKeys[temp]);
                    Check.MouseDown += (sender, e) => DungeonInfo.DungeonInfoElements[temp].UpdateItemCounterText();
                    Check.ValueChanged += (sender,e) => DungeonInfo.DungeonInfoElements[temp].UpdateItemCounterText();
                }
                DungeonInfo.DungeonInfoElements[temp].UpdateItemCounterText();
                MapTracker.RegionWithKeys[temp].KeyValueChangedPositive += (sender, e) => DungeonInfo.DungeonInfoElements[temp].CurrentKeys += 1;
                MapTracker.RegionWithKeys[temp].KeyValueChangedPositive += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
                MapTracker.RegionWithKeys[temp].KeyValueChangedPositive += (sender, e) => MapTracker.UpdateStatVariables(Stats);
                MapTracker.RegionWithKeys[temp].KeyValueChangedPositive += (sender, e) => DungeonInfo.DungeonInfoElements[temp].UpdateItemCounterText();
                MapTracker.RegionWithKeys[temp].KeyValueChangedNegative += (sender, e) => DungeonInfo.DungeonInfoElements[temp].CurrentKeys -= 1;
                MapTracker.RegionWithKeys[temp].KeyValueChangedNegative += (sender, e) => MapTracker.ItemLogic(ItemPanel, DungeonInfo);
                MapTracker.RegionWithKeys[temp].KeyValueChangedNegative += (sender, e) => MapTracker.UpdateStatVariables(Stats);
                MapTracker.RegionWithKeys[temp].KeyValueChangedNegative += (sender, e) => DungeonInfo.DungeonInfoElements[temp].UpdateItemCounterText();
            }                     
        }
        public void UpdateLocationsOfTrackerElements()
        {
            ImportantHint.Location = new Point(AlwaysHints.Location.X, WotHPanel.Size.Height + 1);
            if(ImportantHint.Goal_Count > 0)
            {
                Controls.Add(ImportantHint);
                AlwaysHints.Location = new Point(WotHPanel.Location.X, ImportantHint.Height + ImportantHint.Location.Y + 1);
                SometimesHints.Location = new Point(AlwaysHints.Location.X, AlwaysHints.Height + AlwaysHints.Location.Y + 1);
            }
            else
            {
                Controls.Remove(ImportantHint);
                AlwaysHints.Location = new Point(WotHPanel.Location.X, WotHPanel.Size.Height + 1);
                SometimesHints.Location = new Point(AlwaysHints.Location.X, AlwaysHints.Height + AlwaysHints.Location.Y + 1);
            }            
        }
        public void SetShuffleOptionsForMaptracker(SettingsPanel SettingsPanel)
        {
            MapTracker.ExpensiveMerchantShuffle = SettingsPanel.ExpensiveMerchants.Checked;
            MapTracker.ShopShuffle = SettingsPanel.ShopShuffle.Checked;
            MapTracker.DungeonER = SettingsPanel.DungeonERShuffle.Checked;
        }
        public void AssignFunctionsToGossipstonesInSometimesPanel(Stats Stats)
        {
            //Test for automatic checking of hints in sometimes panel
            foreach (SometimesHint SometimesHint in SometimesHints.SometimesHints)
            {
                SometimesHint.Gossipstone.ValueChanged += (sender, e) => { SometimesHint.AssignIndexFromText(SometimesHint.ComboBox.Text); };
                SometimesHint.Gossipstone.ValueChanged += (sender, e) => { SometimesHint.CheckCheckOnMaptracker(MapTracker, SometimesHint.ComboBox.Text); };
                SometimesHint.Gossipstone.ValueChanged += (sender, e) => { SometimesHint.Gossipstone.UpdateImage(); };
                SometimesHint.Gossipstone.ValueChanged += (sender, e) => { MapTracker.UpdateStatVariables(Stats); };
                SometimesHint.Gossipstone2.ValueChanged += (sender, e) => { SometimesHint.AssignIndexFromText(SometimesHint.ComboBox.Text); };
                SometimesHint.Gossipstone2.ValueChanged += (sender, e) => { SometimesHint.CheckCheckOnMaptracker(MapTracker, SometimesHint.ComboBox.Text); };
                SometimesHint.Gossipstone2.ValueChanged += (sender, e) => { SometimesHint.Gossipstone2.UpdateImage(); };
                SometimesHint.Gossipstone2.ValueChanged += (sender, e) => { MapTracker.UpdateStatVariables(Stats); };
            }
        }
        public void MarkCheckAndUpdateKeyCount(MouseEventArgs e, Region_Panel_Check Check, DungeonInfoElement DungeonInfoElement, RegionPanel Region)
        {
            if(e.Button == MouseButtons.Right)
            {
                if (!Check.Checked)
                {
                    Check.Checked = true;
                    Check.State = true;
                    Region.KeyCountUp += 1;                   
                }
                else
                {
                    Check.Checked = false;
                    Check.State = false;
                }
                if (!Check.UserClickedCheck)
                {
                    Check.UserClickedCheck = true;
                }
                else
                {
                    Check.UserClickedCheck = false;
                }               
            }
        }
        public void ChangeBlueFireArrowMode()
        {
            if(Settings.BlueFireArrows.Checked)
            {
                MapTracker.BlueFireArrowsEnabled = true;
                MapTracker.ZDKingZora.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.RutoLetter.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name})) or ({ItemPanel.Bottle2.Item_Name} and ({ItemPanel.Wallet.Item_Name1} or Ganon's Castle Access)) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
                MapTracker.IceCavernMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
                MapTracker.IceCavernCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
                MapTracker.IceCavernIronBootsChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
                MapTracker.IceCavernFreestandingPoH.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
                MapTracker.IceCavernShiek.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name}) or ({ItemPanel.Bow.Item_Name} and {ItemPanel.IceArrow.Item_Name} and {ItemPanel.Magic.Item_Name})";
            }
            else
            {
                MapTracker.BlueFireArrowsEnabled = false;
                MapTracker.ZDKingZora.RichToolTip.CheckLogic = $"\r\n• ({ItemPanel.RutoLetter.Item_Name} and ({ItemPanel.Bomb.Item_Name} or {ItemPanel.Scales.Item_Name})) or ({ItemPanel.Bottle2.Item_Name} and ({ItemPanel.Wallet.Item_Name1} or Ganon's Castle Access))\r\n• {ItemPanel.ZeldasLullaby.Item_Name}";
                MapTracker.IceCavernMapChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name})";
                MapTracker.IceCavernCompassChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name})";
                MapTracker.IceCavernIronBootsChest.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name})";
                MapTracker.IceCavernFreestandingPoH.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name})";
                MapTracker.IceCavernShiek.RichToolTip.CheckLogic = $"• {ItemPanel.Bottle2.Item_Name} or (({ItemPanel.Bomb.Item_Name} and {ItemPanel.ZeldasLullaby.Item_Name}) or {ItemPanel.Scales.Item_Name} and {ItemPanel.RutoLetter.Item_Name})";
            }
            MapTracker.ItemLogic(ItemPanel,DungeonInfo);
            MapTracker.UpdateStatVariables(Stats);
        }
        public void InitiateDungeonEntranceLogic(Maptracker Maptracker)
        {
            Maptracker.Forest_Temple_Access = Maptracker.DungeonER1(Maptracker.Forest_Temple_Access, ItemPanel, 3);
        }
    }
}
