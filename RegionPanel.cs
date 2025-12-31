using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class RegionPanel : Panel
    {
        public bool IsKeyDungeon;
        public string RegionName;        
        private int DistanceBetweenHeadlineAndChecks;
        public int DungeonAccess;
        public BindingList<Region_Panel_Check> Checks = [];
        public BindingList<ShopPanelCheck> ShopChecks = [];
        public int CheckState
        {
            get
            {
                return _checkState;
            }
            set
            {
                _checkState = value;
                OnCheckStateChanged(null);
            }
        }
        private int _checkState;
        public int KeyCountUp
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
        public int KeyCountDown
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
        public RegionPanel()
        {
            Visible = false;           
        }   
        public void DrawPanel()
        {
            RemoveChecks();
            DistanceBetweenHeadlineAndChecks = 0;
            if (IsKeyDungeon)
            {
                DistanceBetweenHeadlineAndChecks = 60;
                //Key Buttons
                Button KeysUp = new() { Text = "Key Value up", Location = new Point(150, 20), Size = new Size(120, 30), ForeColor = Color.White };
                Button KeysDown = new() { Text = "Key Value down", Location = new Point(30, 20), Size = new Size(120, 30), ForeColor = Color.White };
                KeysUp.MouseDown += (sender, e) => KeyCountUp = 1;
                KeysDown.MouseDown += (sender, e) => KeyCountDown = 1;
                Controls.Add(KeysUp);
                Controls.Add(KeysDown);
            }
            else
            {
                DistanceBetweenHeadlineAndChecks = 20;
            }
            Size = new Size(300, 650);
            Location = new Point(278, 40);
            BackColor = Color.Black;
            AutoScroll = true;
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            Label label = new()
            {
                Text = RegionName,
                Size = new Size(200, 20),
                Location = new Point(70, 0),
                ForeColor = Color.White,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Arial", 16, GraphicsUnit.Pixel),
                //Font = new Font("Arial", 24, FontStyle.Bold)
            };
            Controls.Add(label);
            //panel.MouseDown += (sender, e) => DeletePanel(panel);
            //panel.MouseDown += (sender, e) => DeletePanel(p);
        }
        public void AddChecks()
        {           
            var RegionChecksEnd = 0;
            for (int i = 0; i < Checks.Count; i++)
            {
                var temp = i;
                Checks[temp].Location = new Point(40, 24 * temp + DistanceBetweenHeadlineAndChecks);
                Checks[temp].ValueChanged += (sender, e) => CheckState = 1;
                Controls.Add(Checks[temp]);
                RegionChecksEnd = i;
            }
            if(ShopChecks.Count > 0)
            {
                for (int j = 0; j < ShopChecks.Count; j++)
                {
                    var temp = j;
                    ShopChecks[temp].Location = new Point(40, 24 * (temp + RegionChecksEnd + 1) + 20);
                    ShopChecks[temp].AddGossipstone(this, new Point(205, ShopChecks[temp].Location.Y - 4));
                    ShopChecks[temp].AddNummericUpAndDown(this, new Point(235, ShopChecks[temp].Location.Y - 4));
                    ShopChecks[temp].ValueChanged += (sender, e) => CheckState = 1;
                    Controls.Add(ShopChecks[temp]);
                }
            }
        }
        public void RemoveChecks()
        {           
            Controls.Clear();
        }
        public event EventHandler CheckStateChanged;
        protected virtual void OnCheckStateChanged(EventArgs e)
        {
            if (CheckStateChanged != null)
                CheckStateChanged(this, e);
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
}
