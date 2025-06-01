using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Region
    {
        public Region_Button_Dense _region_button;
        public Region_Panel _region_panel;
        public List<Region_Panel_Check> _checks;
        public DungeonButton _dungeon_button;
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
        //public int _check_count;
        public Region(Region_Button_Dense rb, Region_Panel rp, List<Region_Panel_Check> lc, Maptracker maptracker)
        {
            _region_button = rb;
            _region_panel = rp;
            _checks = lc;
            _region_button.MouseDown += (sender, e) => SelectRegion(e, _region_panel, maptracker);
            _region_button.MouseDown += (sender, e) => _region_button.ButtonClick(e, rp);
            _region_button.MouseDown += (sender, e) => UpdateCounter();
            _region_button.MouseDown += (sender, e) => StateChange = 1;
            foreach (Region_Panel_Check check in _checks)
            {
                check.ValueChanged += (sender, e) => UpdateCounter();
                check.ValueChanged += (sender, e) => StateChange = 1;
            }
        }
        public Region(DungeonButton db, Region_Panel rp, List<Region_Panel_Check> lc, Maptracker maptracker)
        {
            _dungeon_button = db;
            _region_panel = rp;
            _checks = lc;
            _dungeon_button.MouseDown += (sender, e) => SelectRegion(e, _region_panel, maptracker);
            _dungeon_button.MouseDown += (sender, e) => _dungeon_button.ButtonClick(e, rp);
            _dungeon_button.MouseDown += (sender, e) => UpdateDungeonCounter();
            _dungeon_button.MouseDown += (sender, e) => StateChange = 1;
            foreach (Region_Panel_Check check in _checks)
            {
                check.ValueChanged += (sender, e) => UpdateDungeonCounter();
                check.ValueChanged += (sender, e) => StateChange = 1;
            }
        }
        public static void SelectRegion(MouseEventArgs e, Region_Panel region_panel, Maptracker maptracker)
        {
            if (e.Button == MouseButtons.Left)
            {
                Panel panel = new() { Location = new Point(0, 0), Size = new Size(760, 668) , BackColor = Color.FromArgb(160, Color.Black) };                              
                panel.MouseDown += (sender, e) => DeletePanel(panel, region_panel);
                maptracker.Controls.Add(panel);
                panel.BringToFront();
                region_panel.BringToFront();                            
                foreach (Control c in maptracker.Controls)
                {
                    if (c != null && c is Region_Panel && c != region_panel)
                    {
                        c.Visible = false;
                    }
                    else if (c != null && c is ContextMenuForWOTHHints)
                    {

                    }
                    else
                    {
                        c.Visible = true;
                    }
                }
            }
        }
        public void UpdateCounter()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_theoretically = 0;
            foreach (Control c in _region_panel.Controls)
            {
                if (c != null && c is Region_Panel_Check ch)
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
                _region_button.BackColor = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                _region_button.BackColor = Color.Lime;
            }
            else if (check_open >= 1)
            {
                _region_button.BackColor = Color.Orange;
            }
            else
            {
                _region_button.BackColor = Color.Red;
            }         
            _region_button.Text = check_open.ToString();
        }
        public void UpdateDungeonCounter()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_theoretically = 0;
            foreach (Control c in _region_panel.Controls)
            {
                if (c != null && c is Region_Panel_Check ch)
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
                _dungeon_button._checksquare = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                _dungeon_button._bosssquare = Color.Lime;
                _dungeon_button._checksquare = Color.Lime;
                
            }
            else if (check_open >= 1)
            {
                _dungeon_button._checksquare = Color.Orange;
            }
            else
            {
                _dungeon_button._checksquare = Color.Red;
            }
            foreach (Region_Panel_Check c in _checks)
            {
                if (c.IsBoss == true && c.ForeColor == Color.Lime)
                {
                    _dungeon_button._bosssquare = Color.Lime;
                }
                else if (c.IsBoss == true && c.Checked == true)
                {
                    _dungeon_button._bosssquare = Color.Gray;
                }
                else
                {
                    _dungeon_button._bosssquare = Color.Red;
                }
            }
            _dungeon_button.Checks = check_open;
        }
        public static void DeletePanel(Panel p, Region_Panel region_panel)
        {
            p.Dispose();
            region_panel.Visible = false;
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
