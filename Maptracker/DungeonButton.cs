using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public class DungeonButton : Button
    {
        public int DungeonAccess {  get; set; }
        private Color _bossSquare = Color.Red;
        private Color _checkSquare = Color.Red;
        private Color _borderColor = Color.Black;
        public string DungeonName;
        private int BorderSize;
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
        //public List<Region_Panel_Check> Checks;
        public BindingList<Region_Panel_Check> Checks = [];
        public RegionPanel RegionPanel
        {
            get
            {
                return _regionPanel;
            }
            set
            {
                _regionPanel = value;
                OnRegionPanelChanged(null);
            }
        }
        private RegionPanel _regionPanel;
        public Panel InvisiblePanel = new() { Location = new Point(0, 0), Size = new Size(857, 728), BackColor = Color.FromArgb(160, Color.Black), Visible = false };      
        public Color Bosssquare
        {
            get { return _bossSquare; }
            set
            {
                Invalidate();
                _bossSquare = value;               
            }
        }
        public Color Checksquare
        {
            get { return _checkSquare; }
            set { _checkSquare = value; Invalidate(); }
        }
        public Color Bordercolor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }
        public DungeonButton()
        {
            RegionPanel = new RegionPanel();
            Size = new Size(30,30);
            Text = CheckCount.ToString();
            BackColor = Color.Transparent;
            Font = new("Arial", 11, GraphicsUnit.Pixel );
            MouseDown += (sender,e) => ButtonClick(e);
            //CheckCountChanged += (sender,e) => Text = CheckCount.ToString();
            RegionPanelChanged += (sender, e) => ChangeChecks();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath grPath = new();
            //grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            RectangleF rect = new Rectangle(0, 0, this.Width, this.Height);
            grPath.AddRectangle(rect);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //g.SmoothingMode = SmoothingMode.AntiAlias;
            using (SolidBrush brush = new(_checkSquare))
            {             
                g.FillRectangle(brush, 3, 3, 24, 24);              
            }
            using (SolidBrush brush = new(_bossSquare))
            {
                g.FillRectangle(brush, 7, 7, 17, 17);
            }
            using (Pen selPen = new(_borderColor, 3))
            {               
                g.DrawRectangle(selPen, 2, 2, 26, 26);              
            }
            if (CheckCount < 10)
            {
                TextRenderer.DrawText(e.Graphics, CheckCount.ToString(), this.Font, new Point(10, 9), Color.Black);
                TextRenderer.DrawText(e.Graphics, CheckCount.ToString(), this.Font, new Point(9, 8), Color.White);
            }
            else
            {
                TextRenderer.DrawText(e.Graphics, CheckCount.ToString(), new("Arial", 11, FontStyle.Bold, GraphicsUnit.Pixel), new Point(7, 9), Color.Black);
                TextRenderer.DrawText(e.Graphics, CheckCount.ToString(), this.Font, new Point(6, 8), Color.White);
            }          
            //g.DrawEllipse(selPen, 0, 0, 13, 13);
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
        public void InitiateMethods()
        {
            RegionPanel.DrawPanel();
            RegionPanel.AddChecks();
            AssignMethodsToChecks();
        }
        public void ChangeChecks()
        {
            //Checks = RegionPanel.Checks;
            AssignMethodsToChecks();
        }
        public void UpdateDungeonCounter()
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
            if (max_checks == check_done)
            {
                Checksquare = Color.Gray;
            }
            else if (max_checks == check_open + check_done + check_theoretically)
            {
                Bosssquare = Color.Lime;
                Checksquare = Color.Lime;

            }
            else if (check_open >= 1)
            {
                Checksquare = Color.Orange;
            }
            else
            {
                Checksquare = Color.Red;
            }
            foreach (Region_Panel_Check c in RegionPanel.Checks)
            {
                if (c.IsBoss == true && c.Checked == true)
                {
                    Bosssquare = Color.Gray;                    
                }
                else if (c.IsBoss == true && c.ForeColor == Color.Lime)
                {
                    Bosssquare = Color.Lime;
                }
                else if (c.IsBoss == true && c.ForeColor == Color.Yellow)
                {
                    Bosssquare = Color.Orange;
                }
                else if (c.IsBoss == true)
                {
                    Bosssquare = Color.Red;
                }
            }
            CheckCount = check_open;
            //Text = CheckCount.ToString();
        }
        public void CheckEntireRegion()
        {
            int ChecksChecked = 0;
            int MaxChecks = 0;
            foreach (Region_Panel_Check cb in RegionPanel.Checks)
            {
                MaxChecks++;
                if (cb.Checked)
                {
                    ChecksChecked++;
                }              
            }
            if (MaxChecks > ChecksChecked)
            {
                foreach (Region_Panel_Check cb in RegionPanel.Checks)
                {
                    cb.Checked = true;
                    cb.State = true;
                }
            }
            else
            {
                foreach (Region_Panel_Check cb in RegionPanel.Checks)
                {
                    cb.Checked = false;
                    cb.State = false;
                }
            }            
        }
        public void AddContextMenu(MouseEventArgs e, ContextMenuForWOTHHints ContextWheel, DungeonButton DungeonButton)
        {
            int posX = e.X + DungeonButton.Location.X;
            int posY = e.Y + DungeonButton.Location.Y;
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
                ContextWheel.RegionName = DungeonButton.RegionPanel.RegionName;
            }
        }
        public void AssignMethodsToChecks()
        {
            foreach (Region_Panel_Check check in RegionPanel.Checks)
            {
                check.ValueChanged += (sender, e) => UpdateDungeonCounter();
                check.ForeColorChanged += (sender, e) => UpdateDungeonCounter();
            }
        }
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
        public event EventHandler RegionPanelChanged;
        protected virtual void OnRegionPanelChanged(EventArgs e)
        {
            //CheckCountChanged?.Invoke(this, e);
            if (RegionPanelChanged != null)
                RegionPanelChanged(this, e);
        }
    }
}
