using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CeddyMapTracker
{
    public class RegionButton : Button
    {
        public int CheckCount
        {
            get
            {
                return _checkCount;
            }
            set
            {
                _checkCount = value;
                OnCheckCountChanged(null);
            }
        }
        private int _checkCount;
        public BindingList<Region_Panel_Check> Checks = [];
        public BindingList<ShopPanelCheck> ShopChecks = [];
        public RegionPanel RegionPanel = new();             
        public Panel InvisiblePanel = new() { Location = new Point(0, 0), Size = new Size(857, 728), BackColor = Color.FromArgb(160, Color.Black), Visible = false };
        public event EventHandler CallForContextMenu;
        protected virtual void OnValueChanged(EventArgs e)
        {
            CallForContextMenu?.Invoke(this, e);
            //if (CallForContextMenu != null)
            //    CallForContextMenu(this, e);
        }
        public event EventHandler CheckCountChanged;
        protected virtual void OnCheckCountChanged(EventArgs e)
        {
            //CheckCountChanged?.Invoke(this, e);
            if (CheckCountChanged != null)
                CheckCountChanged(this, e);
        }
        //public string RegionName;
        public RegionButton()
        {          
            FlatStyle = FlatStyle.Flat;
            Size = new Size(24, 24);
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            ForeColor = Color.Black;
            BackColor = Color.Red;
            Font = new Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Pixel);
            MouseDown += (sender, e) => ButtonClick(e);
            RegionPanel.ShopChecks.RaiseListChangedEvents = true;           
        }       
        public void ButtonClick(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    DrawRegionPanel();
                    break;
                case MouseButtons.Right:
                    OnValueChanged(null);
                    break;
                case MouseButtons.Middle:
                    CheckEntireRegion();
                    break;
            }
        }
        public void DrawRegionPanel()
        {
            RegionPanel.Visible = true;
            InvisiblePanel.Visible = true;
            InvisiblePanel.BringToFront();
            RegionPanel.BringToFront();
            RegionPanel.DrawPanel();
            RegionPanel.AddChecks();
            AssignMethodsToChecks();
            InvisiblePanel.MouseDown += (sender, e) => RegionPanel.Visible = false;
            InvisiblePanel.MouseDown += (sender, e) => InvisiblePanel.Visible = false;
        }
        public void CheckEntireRegion()
        {
            int ChecksChecked = 0;
            int MaxChecks = 0;
            foreach (Region_Panel_Check rpc in RegionPanel.Checks)
            {
                MaxChecks++;
                if (rpc.Checked)
                {
                    ChecksChecked++;
                }
            }
            foreach (ShopPanelCheck spc in RegionPanel.ShopChecks)
            {
                MaxChecks++;
                if (spc.Checked)
                {
                    ChecksChecked++;
                }
            }
            if (MaxChecks > ChecksChecked)
            {
                foreach (Region_Panel_Check rpc in RegionPanel.Checks)
                {
                    rpc.Checked = true;
                    rpc.UserClickedCheck = true;
                    rpc.State = true;
                }
                foreach (ShopPanelCheck spc in RegionPanel.ShopChecks)
                {
                    spc.Checked = true;
                }
            }
            else
            {
                foreach (Region_Panel_Check rpc in RegionPanel.Checks)
                {
                    rpc.Checked = false;
                    rpc.UserClickedCheck = false;
                    rpc.State = false;
                }
                foreach (ShopPanelCheck spc in RegionPanel.ShopChecks)
                {
                    spc.Checked = false;
                }
            }
                    
        }
        public void InitiateMethods()
        {
            RegionPanel.DrawPanel();
            RegionPanel.AddChecks();
            AssignMethodsToChecks();
        }
        public void UpdateCounter()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_theoretically = 0;
            foreach (Region_Panel_Check ch in RegionPanel.Checks)
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
            foreach (ShopPanelCheck spc in RegionPanel.ShopChecks)
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
                BackColor = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                BackColor = Color.Lime;
            }
            else if (check_open >= 1)
            {
                BackColor = Color.Orange;
            }
            else
            {
                BackColor = Color.Red;
            }
            Text = check_open.ToString();
        }
        public void AssignMethodsToChecks()
        {
            foreach (Region_Panel_Check check in RegionPanel.Checks)
            {
                check.ValueChanged += (sender, e) => UpdateCounter();
                check.ForeColorChanged += (sender, e) => UpdateCounter();
                check.CheckedChanged += (sender, e) => UpdateCounter();
            }
            foreach (ShopPanelCheck check in RegionPanel.ShopChecks)
            {
                check.ValueChanged += (sender, e) => UpdateCounter();
                check.ForeColorChanged += (sender, e) => UpdateCounter();
                check.CheckedChanged += (sender, e) => UpdateCounter();
            }
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel, RegionButton RegionButton)
        {
            int posX = e.X + RegionButton.Location.X;
            int posY = e.Y + RegionButton.Location.Y;
            if (posX - 70 <= 0)
            {
                posX = 70;
            }
            if (posY - 70 <= 0)
            {
                posY = 70;
            }
            if (posX + 70 >= 857)
            {
                posX = 787;
            }
            if (posY + 70 >= 728)
            {
                posY = 658;
            }

            if (e.Button == MouseButtons.Right)
            {
                ContextWheel.AddContextMenu(this, posX - 70, posY - 70);
                ContextWheel.BringToFront();
                ContextWheel.RegionName = RegionButton.RegionPanel.RegionName;
            }
        }
    }   
}
