using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CeddyMapTracker
{
    public class ShopPanelCheck : CheckBox
    {
        public string _name;       
        public RichToolTip RichToolTip = new();
        public Gossipstone Gossipstone = new();
        public NumericUpDown Price = new();
        public bool StateChange
        {
            get
            {
                return _checked;
            }
            set
            {
                _checked = value;
                OnValueChanged(null);
            }
        }
        private bool _checked;
        public ShopPanelCheck(string name)
        {
            _name = name;
            Text = _name;
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
            ForeColor = Color.Red;
            Size = new Size(200, 20);
            AutoSize = true;
            AutoCheck = false;
            MouseDown += (sender, e) => ClickEvent(e);
            ForeColorChanged += (sender, e) => StateChange = true;
            CheckedChanged += (sender, e) => StateChange = true;
        }
        public void ClickEvent(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (!Checked)
                    {
                        Checked = true;                      
                    }
                    else
                    {
                        Checked = false;                      
                    }
                    break;
            }
        }
        public void AddGossipstone(Control c, Point Location)
        {
            Gossipstone.Location = Location;
            c.Controls.Add(Gossipstone);
        }
        public void AddNummericUpAndDown(Control c, Point Location)
        {
            Price.Location = Location;
            Price.Size = new Size(50, 20);
            Price.Font = new Font("Arial",14, GraphicsUnit.Pixel);
            Price.Maximum = 500;         
            Price.ValueChanged += (sender, e) => StateChange = true;
            c.Controls.Add(Price);
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
