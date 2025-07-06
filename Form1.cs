using Newtonsoft.Json;
using System.Security.Principal;

namespace CeddyMapTracker
{
    public partial class Form1 : Form
    {
        List<int> SmallKeys = [];
        public ItemPanel itemPanel = new(new Point(0, 0));
        public SometimesHints SometimesHints = new(new Point(420, 360));
        public WOTHPanel wothPanel = new(new Point(380, 0)) { Goal_Count = 5 };
        public AlwaysHints alwaysHints = new(new Point(420, 150));
        public Maptracker? maptracker;
        public Form1()
        {        
            InitializeComponent();                                        
                      
            Stats stats = new(new Point(0, 700));
            maptracker = new(wothPanel,new Point(720, 0), stats);          
            KeyPanel keys = new(new Point(640, 0));
            SettingsPanel settingspanel = new(new Point(0,0));
            settingspanel.Visible = false;
            SettingsButton settingsbutton = new (new Point (0, 710));
            settingsbutton.MouseDown += (sender, e) => settingsbutton.ClickEvent(settingspanel);          
            //DungeonCounter dungeoncounter = new(maptracker);          
            Controls.Add(wothPanel);           
            Controls.Add(alwaysHints);           
            Controls.Add(SometimesHints);           
            Controls.Add(maptracker);         
            Controls.Add(stats);
            Controls.Add(settingsbutton);
            Controls.Add(itemPanel);
            Controls.Add(settingspanel);         
            itemPanel.LoadItems();
            itemPanel.LoadEquips();
            itemPanel.LoadQuestItems();
            itemPanel.LoadSongs();          
            Controls.Add(keys);          
            List<Keys> SmallKeys = [keys.Forest_SmallKeys, keys.Fire_SmallKeys, keys.Water_SmallKeys, keys.Shadow_SmallKeys, keys.Spirit_SmallKeys, keys.BotW_SmallKeys, keys.GTG_SmallKeys];
            List<Item> BossKeys = [itemPanel.ForestBossKey, itemPanel.FireBossKey, itemPanel.WaterBossKey, itemPanel.ShadowBossKey, itemPanel.SpiritBossKey];                    
            keys.LoadSmallKeys(SmallKeys);
            keys.LoadBossKeys(BossKeys);
            //Precise locations
            stats.Location = new Point(maptracker.Location.X, maptracker.Location.Y);
            stats.BringToFront();
            alwaysHints.Location = new Point(wothPanel.Location.X, wothPanel.Size.Height + 1);
            SometimesHints.Location = new Point(alwaysHints.Location.X, alwaysHints.Size.Height + alwaysHints.Location.Y + 1);
            //Controls.Add(dungeoncounter);
            //Load logic for the first time
            maptracker.Sphere0Checks();
            maptracker.ItemLogic(itemPanel, keys);            
            //Stats
            maptracker.UpdateStatVariables(stats);
            stats.UpdateChecksAvailable();
            //Update checks and stats
            itemPanel.ValueChanged += (sender,e) => maptracker.ItemLogic(itemPanel, keys);
            itemPanel.ValueChanged += (sender, e) => maptracker.UpdateStatVariables(stats);
            itemPanel.ValueChanged += (sender, e) => stats.UpdateChecksAvailable();
            //Update checks and stats
            keys.ValueChanged += (sender, e) => maptracker.ItemLogic(itemPanel, keys);
            keys.ValueChanged += (sender, e) => maptracker.UpdateStatVariables(stats);
            keys.ValueChanged += (sender, e) => stats.UpdateChecksAvailable();
            //Settingspanel assign functions
            settingspanel.button1.MouseDown += (sender,e) => settingspanel.ConfirmSettings(this);
            settingspanel.button1.MouseDown += (sender, e) => UpdateLocations(alwaysHints,SometimesHints,wothPanel);
            settingspanel.Load_Preset_Button.MouseDown += (sender, e) => settingspanel.LoadPreset(itemPanel, this, SometimesHints, alwaysHints, wothPanel);
            settingspanel.Load_Preset_Button.MouseDown += (sender, e) => UpdateLocations(alwaysHints, SometimesHints, wothPanel);
        }
        public void UpdateLocations(AlwaysHints alwaysHints, SometimesHints sometimesHints, WOTHPanel wothPanel)
        {
            alwaysHints.Location = new Point(wothPanel.Location.X, wothPanel.Size.Height + 1);
            sometimesHints.Location = new Point(alwaysHints.Location.X, alwaysHints.Size.Height + alwaysHints.Location.Y + 1);

        }
        

    }
}
