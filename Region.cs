using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CeddyMapTracker
{
    /*
    public class Region
    {
        public Region_Button_Dense RegionButton; 
        public RegionPanel RegionPanel = new();
        public List<Region_Panel_Check> Checks;
        public List<ShopPanelCheck> ShopChecks = [];
        public DungeonButton DungeonButton
        {
            get
            {
                return dungeonButton;
            }
            set
            {
                dungeonButton = value;
                DungeonButtonChanged(null);
            }
        }
        private DungeonButton dungeonButton;
        public event EventHandler DungeonButtonChangedEvent;
        protected virtual void DungeonButtonChanged(EventArgs e)
        {
            if (DungeonButtonChangedEvent != null)
                DungeonButtonChangedEvent(this, e);
        }
        //public string RegionName;
        public int DungeonEntrance;
        public int StateChange
        {
            get
            {
                return _StateChange;
            }
            set
            {
                _StateChange = value;
                OnValueChanged(null);
            }
        }
        private int _StateChange;
        public int KeyUp
        {
            get
            {
                return _keyup;
            }
            set
            {
                _keyup = value;
                KeyValueChangedUp(null);
            }
        }
        private int _keyup;
        public int KeyDown
        {
            get
            {
                return _keydown;
            }
            set
            {
                _keydown = value;
                KeyValueChangedDown(null);
            }
        }
        private int _keydown;
        //public int _check_count;
        public Region(Region_Button_Dense rb, List<Region_Panel_Check> lc, Maptracker maptracker)
        {
            RegionButton = rb;           
            Checks = lc;
            RegionButton.MouseDown += (sender, e) => SelectRegion(e, maptracker, this);
            RegionButton.MouseDown += (sender, e) => RegionButton.ButtonClick(e,lc, ShopChecks);
            RegionButton.MouseDown += (sender, e) => UpdateCounter();
            RegionButton.MouseDown += (sender, e) => StateChange = 1;         
        }
        public Region(DungeonButton db, List<Region_Panel_Check> lc, Maptracker maptracker)
        {
            DungeonButton = db;
            Checks = lc;
            DungeonButton.MouseDown += (sender, e) => SelectDungeonRegion(e, maptracker, this);
            DungeonButton.MouseDown += (sender, e) => DungeonButton.ButtonClick(e, Checks);
            DungeonButton.MouseDown += (sender, e) => UpdateDungeonCounter();
            DungeonButton.MouseDown += (sender, e) => StateChange = 1;
        }       
        public void SelectRegion(MouseEventArgs e, Maptracker maptracker, Region Region)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel p = new();
                int DistanceBetweenHeadlineAndChecks = 0;
                if(Region.RegionName == "Bottom of the Well" || Region.RegionName == "Gerudo Training Ground")
                {
                    DistanceBetweenHeadlineAndChecks = 60;
                    //Key Buttons
                    Button KeysUp = new() { Text = "Key Value up", Location = new Point(150, 20), Size = new Size(120, 30), ForeColor = Color.White };
                    Button KeysDown = new() { Text = "Key Value down", Location = new Point(30, 20), Size = new Size(120, 30), ForeColor = Color.White };
                    KeysUp.MouseDown += (sender, e) => KeyUp = 1;
                    KeysDown.MouseDown += (sender, e) => KeyDown = 1;
                    p.Controls.Add(KeysUp);
                    p.Controls.Add(KeysDown);
                }
                else
                {
                    DistanceBetweenHeadlineAndChecks = 20;
                }
                Panel panel = new() { Location = new Point(0, 0), Size = new Size(857, 728), BackColor = Color.FromArgb(160, Color.Black) };                              
                maptracker.Controls.Add(panel);
                panel.BringToFront();
                maptracker.Controls.Add(p);
                p.BringToFront();
                p.Size = new Size(300, 650);
                p.Location = new Point(278, 40);
                p.BackColor = Color.Black;
                p.AutoScroll = true;
                p.Font = new Font("Arial", 12, GraphicsUnit.Pixel);
                Label label = new()
                {
                    Text = Region.RegionName,
                    Size = new Size(200, 20),
                    Location = new Point(70, 0),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 16, GraphicsUnit.Pixel),
                    //Font = new Font("Arial", 24, FontStyle.Bold)
                };
                p.Controls.Add(label);           
                var RegionChecksEnd = 0;
                for (int i = 0; i < Region.Checks.Count; i++)
                {
                    var temp = i;
                    Region.Checks[temp].Location = new Point(40, 24 * temp + DistanceBetweenHeadlineAndChecks);
                    Region.Checks[temp].ValueChanged += (sender, e) => Region.UpdateCounter();
                    Region.Checks[temp].ValueChanged += (sender, e) => Region.StateChange = 1;    
                    p.Controls.Add(Region.Checks[temp]);
                    RegionChecksEnd = i;
                }
                for (int j = 0; j < Region.ShopChecks.Count; j++)
                {
                    var temp = j;
                    Region.ShopChecks[temp].Location = new Point(40, 24 * (temp + RegionChecksEnd + 1) + 20);
                    Region.ShopChecks[temp].AddGossipstone(p, new Point(205, Region.ShopChecks[temp].Location.Y - 4));
                    Region.ShopChecks[temp].AddNummericUpAndDown(p, new Point(235, Region.ShopChecks[temp].Location.Y - 4));
                    Region.ShopChecks[temp].ValueChanged += (sender, e) => Region.UpdateCounter();
                    Region.ShopChecks[temp].ValueChanged += (sender, e) => Region.StateChange = 1;
                    p.Controls.Add(Region.ShopChecks[temp]);
                }
                panel.MouseDown += (sender, e) => DeletePanel(panel);
                panel.MouseDown += (sender, e) => DeletePanel(p);             
            }
        }
        public void SelectDungeonRegion(MouseEventArgs e, Maptracker maptracker, Region Region)
        {
            if (e.Button == MouseButtons.Left)
            {
                maptracker.Controls.Add(RegionPanel);
                RegionPanel.AddChecks(Region);
                //Panel p = new();
                /*
                int DistanceBetweenHeadlineAndChecks = 0;
                if (Region.RegionName == "Forest Temple" || Region.RegionName == "Fire Temple" || Region.RegionName == "Water Temple" || Region.RegionName == "Shadow Temple" || Region.RegionName == "Spirit Temple")
                {
                    DistanceBetweenHeadlineAndChecks = 60;
                    //Key Buttons
                    Button KeysUp = new() { Text = "Key Value up", Location = new Point(150, 20), Size = new Size(120, 30), ForeColor = Color.White };
                    Button KeysDown = new() { Text = "Key Value down", Location = new Point(30, 20), Size = new Size(120, 30), ForeColor = Color.White };
                    KeysUp.MouseDown += (sender, e) => KeyUp = 1;
                    KeysDown.MouseDown += (sender, e) => KeyDown = 1;
                    p.Controls.Add(KeysUp);
                    p.Controls.Add(KeysDown);
                }
                else
                {
                    DistanceBetweenHeadlineAndChecks = 20;
                }
                
                Panel panel = new() { Location = new Point(0, 0), Size = new Size(857, 728), BackColor = Color.FromArgb(160, Color.Black) };
                maptracker.Controls.Add(panel);
                /*
                panel.BringToFront();
                maptracker.Controls.Add(p);
                p.BringToFront();
                p.Size = new Size(300, 650);
                p.Location = new Point(278, 40);
                p.BackColor = Color.Black;
                p.AutoScroll = true;
                p.Font = new Font("Arial", 12, GraphicsUnit.Pixel);
                Label label = new()
                {
                    Text = Region.RegionName,
                    Size = new Size(200, 20),
                    Location = new Point(70, 0),
                    ForeColor = Color.White,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Arial", 16, GraphicsUnit.Pixel),
                    //Font = new Font("Arial", 24, FontStyle.Bold)
                };
                p.Controls.Add(label);
                var RegionChecksEnd = 0;
                for (int i = 0; i < Region.Checks.Count; i++)
                {
                    var temp = i;
                    Region.Checks[temp].Location = new Point(40, 24 * temp + DistanceBetweenHeadlineAndChecks);
                    Region.Checks[temp].ValueChanged += (sender, e) => Region.UpdateDungeonCounter();
                    Region.Checks[temp].ValueChanged += (sender, e) => Region.StateChange = 1;
                    p.Controls.Add(Region.Checks[temp]);
                    RegionChecksEnd = i;
                }  
                
                panel.MouseDown += (sender, e) => DeletePanel(panel);
                panel.MouseDown += (sender, e) => DeletePanel(RegionPanel);
            }
        }
        public void UpdateCounter()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_theoretically = 0;
            foreach (Region_Panel_Check ch in Checks)
            {
                if (ch != null)
                {
                    max_checks++;
                    if ((ch.ForeColor == Color.Lime) && !ch.Checked)
                    {
                        check_open++;                   
                    }
                    if ((ch.ForeColor == Color.Yellow) && !ch.Checked)
                    {
                        check_theoretically++;
                    }
                    if (ch.Checked)
                    {
                        check_done++;
                    }                   
                }               
            }
            foreach (ShopPanelCheck spc in ShopChecks)
            {
                if (spc != null)
                {
                    max_checks++;
                    if ((spc.ForeColor == Color.Lime) && !spc.Checked)
                    {
                        check_open++;
                    }
                    if ((spc.ForeColor == Color.Yellow) && !spc.Checked)
                    {
                        check_theoretically++;
                    }
                    if (spc.Checked)
                    {
                        check_done++;
                    }
                }
            }
            if (max_checks == check_done)
            {
                RegionButton.BackColor = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                RegionButton.BackColor = Color.Lime;
            }
            else if (check_open >= 1)
            {
                RegionButton.BackColor = Color.Orange;
            }
            else
            {
                RegionButton.BackColor = Color.Red;
            }         
            RegionButton.Text = check_open.ToString();
        }       
        public void UpdateDungeonCounter()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_theoretically = 0;
            foreach (Region_Panel_Check ch in Checks)
            {
                if (ch != null)
                {
                    max_checks++;
                    if ((ch.ForeColor == Color.Lime) && !ch.Checked)
                    {
                        check_open++;
                    }
                    if ((ch.ForeColor == Color.Yellow) && !ch.Checked)
                    {
                        check_theoretically++;
                    }
                    if (ch.Checked)
                    {
                        check_done++;
                    }
                }
            }
            if (max_checks == check_done)
            {
                DungeonButton._checksquare = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                DungeonButton._bosssquare = Color.Lime;
                DungeonButton._checksquare = Color.Lime;
                
            }
            else if (check_open >= 1)
            {
                DungeonButton._checksquare = Color.Orange;
            }
            else
            {
                DungeonButton._checksquare = Color.Red;
            }
            foreach (Region_Panel_Check c in Checks)
            {
                if (c.IsBoss == true && c.Checked == true)
                {
                    DungeonButton._bosssquare = Color.Gray;
                }
                else if (c.IsBoss == true && c.ForeColor == Color.Lime)
                {
                    DungeonButton._bosssquare = Color.Lime;
                }
                else if (c.IsBoss == true && c.ForeColor == Color.Yellow)
                {
                    DungeonButton._bosssquare = Color.Orange;
                }
                else
                {
                    DungeonButton._bosssquare = Color.Red;
                }
            }
            DungeonButton.Checks = check_open;
        }
        public static void DeletePanel(Panel p)
        {
            p.Controls.Clear();
            p.Dispose();       
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
        public event EventHandler KeyValueChangedPositive;
        protected virtual void KeyValueChangedUp(EventArgs e)
        {
            if (KeyValueChangedPositive != null)
                KeyValueChangedPositive(this, e);
        }
        public event EventHandler KeyValueChangedNegative;
        protected virtual void KeyValueChangedDown(EventArgs e)
        {
            if (KeyValueChangedNegative != null)
                KeyValueChangedNegative(this, e);
        }
        
    }
    */
}
