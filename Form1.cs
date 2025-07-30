using Newtonsoft.Json;
using System.Security.Principal;

namespace CeddyMapTracker
{
    public partial class Form1 : Form
    {  
        public ItemPanel ItemPanel = new(new Point(0, 0));
        public SometimesHints SometimesHints = new(new Point(420, 360));
        public WOTHPanel WotHPanel = new(new Point(380, 0)) { Goal_Count = 5 };
        public AlwaysHints AlwaysHints = new(new Point(420, 150));
        public Maptracker? MapTracker;
        public Form1()
        {        
            InitializeComponent();                                        
                      
            Stats Stats = new(new Point(0, 700));
            MapTracker = new(WotHPanel,new Point(720, 0), Stats);          
            KeyPanel Keys = new(new Point(640, 0));
            SettingsPanel SettingsPanel = new(new Point(0,0));
            SettingsPanel.Visible = false;
            SettingsButton SettingsButton = new (new Point (0, 490));
            SettingsButton.MouseDown += (sender, e) => SettingsButton.ClickEvent(SettingsPanel);          
            //DungeonCounter dungeoncounter = new(maptracker);          
            Controls.Add(WotHPanel);           
            Controls.Add(AlwaysHints);           
            Controls.Add(SometimesHints);           
            Controls.Add(MapTracker);         
            Controls.Add(Stats);
            Controls.Add(SettingsButton);
            Controls.Add(ItemPanel);
            Controls.Add(SettingsPanel);         
            ItemPanel.LoadItems();
            ItemPanel.LoadEquips();
            ItemPanel.LoadQuestItems();
            ItemPanel.LoadSongs();          
            Controls.Add(Keys);          
            List<Keys> SmallKeys = [Keys.Forest_SmallKeys, Keys.Fire_SmallKeys, Keys.Water_SmallKeys, Keys.Shadow_SmallKeys, Keys.Spirit_SmallKeys, Keys.BotW_SmallKeys, Keys.GTG_SmallKeys];
            List<Item> BossKeys = [ItemPanel.ForestBossKey, ItemPanel.FireBossKey, ItemPanel.WaterBossKey, ItemPanel.ShadowBossKey, ItemPanel.SpiritBossKey];                    
            Keys.LoadSmallKeys(SmallKeys);
            Keys.LoadBossKeys(BossKeys);
            //Precise locations
            Stats.Location = new Point(MapTracker.Location.X, MapTracker.Location.Y);
            Stats.BringToFront();
            AlwaysHints.Location = new Point(WotHPanel.Location.X, WotHPanel.Size.Height + 1);
            SometimesHints.Location = new Point(AlwaysHints.Location.X, AlwaysHints.Size.Height + AlwaysHints.Location.Y + 1);
            //Controls.Add(dungeoncounter);
            //Load logic for the first time
            MapTracker.Sphere0Checks();
            MapTracker.ItemLogic(ItemPanel, Keys);            
            //Stats
            MapTracker.UpdateStatVariables(Stats);
            Stats.UpdateChecksAvailable();
            //Update checks and stats
            ItemPanel.ValueChanged += (sender,e) => MapTracker.ItemLogic(ItemPanel, Keys);
            ItemPanel.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            ItemPanel.ValueChanged += (sender, e) => Stats.UpdateChecksAvailable();
            //Update checks and stats
            Keys.ValueChanged += (sender, e) => MapTracker.ItemLogic(ItemPanel, Keys);
            Keys.ValueChanged += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            Keys.ValueChanged += (sender, e) => Stats.UpdateChecksAvailable();
            //Settingspanel assign functions
            SettingsPanel.button1.MouseDown += (sender,e) => SettingsPanel.ConfirmSettings(this);
            SettingsPanel.button1.MouseDown += (sender, e) => UpdateLocations(AlwaysHints,SometimesHints,WotHPanel);
            SettingsPanel.Load_Preset_Button.MouseDown += (sender, e) => SettingsPanel.LoadPreset(ItemPanel, this, SometimesHints, AlwaysHints, WotHPanel, MapTracker);
            SettingsPanel.Load_Preset_Button.MouseDown += (sender, e) => UpdateLocations(AlwaysHints, SometimesHints, WotHPanel);
            SettingsPanel.Load_Preset_Button.MouseDown += (sender, e) => MapTracker.UpdateStatVariables(Stats);
            SettingsPanel.changeStyleButton1.MouseDown += (sender, e) => SettingsPanel.changeStyleButton1.OnClick(ItemPanel);
        }
        public void UpdateLocations(AlwaysHints alwaysHints, SometimesHints sometimesHints, WOTHPanel wothPanel)
        {
            alwaysHints.Location = new Point(wothPanel.Location.X, wothPanel.Size.Height + 1);
            sometimesHints.Location = new Point(alwaysHints.Location.X, alwaysHints.Size.Height + alwaysHints.Location.Y + 1);

        }
        

    }
}
