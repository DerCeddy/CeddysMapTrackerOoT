using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class ShopButton : Button
    {
        public Color color;
        private Color Color_Done = Color.Gray;
        public ShopPanelCheck TopLeft = new("Top Left");
        public ShopPanelCheck TopRight = new("Top Right");
        public ShopPanelCheck BottomLeft = new("Bottom Left");
        public ShopPanelCheck BottomRight = new("Bottom Right");
        public int TopLeftPrice;
        public int TopRightPrice;
        public int BottomLeftPrice;
        public int BottomRightPrice;
        public List<ShopPanelCheck> ShopChecks;
        public RichToolTip RichToolTip = new();       
        public bool State
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value;
                OnValueChanged(null);
            }
        }
        private bool _done;
        public ShopButton()
        {
            Size = new Size(13, 13);
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Red;
            ForeColor = Color.Red;
            FlatAppearance.BorderSize = 1;
            FlatAppearance.BorderColor = Color.Black;
            ShopChecks = [TopLeft, TopRight, BottomLeft, BottomRight];
            foreach (ShopPanelCheck check in ShopChecks)
            {               
                check.ValueChanged += (sender, e) => UpdateColor();
                check.ValueChanged += (sender,e) => State = true;
            }          
        }
        public void CreatePanel(Control c, MouseEventArgs e)
        {
            switch(e.Button)
            {
                case MouseButtons.Left:
                    Panel Panel = new() { Size = new Size(190, 130), Location = new Point(c.Width / 2 - 95, c.Height / 2 - 75) };
                    Panel ClosingPanel = new() { Location = new Point(0, 0), Size = new Size(857, 728), BackColor = Color.FromArgb(160, Color.Black) };
                    c.Controls.Add(ClosingPanel);
                    for (int i = 0; i < ShopChecks.Count; i++)
                    {
                        Panel.Controls.Add(ShopChecks[i]);
                        ShopChecks[i].Location = new Point(0, 10 + i * 30);
                        ShopChecks[i].AddGossipstone(Panel, new Point(100, ShopChecks[i].Location.Y - 4));
                        ShopChecks[i].AddNummericUpAndDown(Panel, new Point(130, ShopChecks[i].Location.Y - 4));
                    }
                    c.Controls.Add(Panel);
                    PictureBox CloseButton = new() { Image = Resources.Soldout, Location = new Point(170, 0) };
                    c.MouseDown += (sender, e) => c.Controls.Remove(Panel);
                    ClosingPanel.BringToFront();
                    Panel.BringToFront();
                    ClosingPanel.MouseDown += (sender, e) => ClosingPanel.Dispose();
                    ClosingPanel.MouseDown += (sender, e) => Panel.Controls.Clear();
                    ClosingPanel.MouseDown += (sender, e) => Panel.Dispose();
                    break;
                case MouseButtons.Middle:
                    int ChecksChecked = 0;
                    int MaxChecks = 0;
                    foreach (ShopPanelCheck spc in ShopChecks)
                    {                      
                        MaxChecks++;
                        if (spc.Checked)
                        {
                            ChecksChecked++;
                        }                      
                    }
                    if (MaxChecks > ChecksChecked)
                    {
                        foreach (ShopPanelCheck spc in ShopChecks)
                        {                           
                            spc.Checked = true;                          
                        }
                    }
                    else
                    {
                        foreach (ShopPanelCheck spc in ShopChecks)
                        {
                            spc.Checked = false;
                        }
                    }
                    UpdateColor();
                    State = true;
                    break;
            }
                

        }
        public void UpdateColor()
        {
            int max_checks = 0;
            int check_open = 0;
            int check_done = 0;
            int check_cansee = 0;
            foreach (ShopPanelCheck ch in ShopChecks)
            {
                if (ch != null)
                {
                    max_checks++;
                    if ((ch.ForeColor == Color.Lime) && !ch.Checked)
                    {
                        check_open++;
                    }
                    if ((ch.ForeColor == Color.LightBlue) && !ch.Checked)
                    {
                        check_cansee++;
                    }
                    if (ch.Checked)
                    {
                        check_done++;
                    }
                }
            }
            if (max_checks == check_done)
            {
                BackColor = Color.Gray;
            }
            else if (max_checks == check_open + check_done)
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
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
