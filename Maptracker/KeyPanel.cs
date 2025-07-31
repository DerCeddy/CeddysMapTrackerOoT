using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeddyMapTracker
{
    public class KeyPanel : Panel
    {
        public Keys Forest_SmallKeys = new() { maxKeys = 5, Image = Resources.keyForest_32x32 };
        public Keys Fire_SmallKeys = new() { maxKeys = 8, Image = Resources.keyFire_32x32 };
        public Keys Water_SmallKeys = new() { maxKeys = 6, Image = Resources.keyWater_32x32 };
        public Keys Shadow_SmallKeys = new() { maxKeys = 5, Image = Resources.keyShadow_32x32 };
        public Keys Spirit_SmallKeys = new() { maxKeys = 5, Image = Resources.keySpirit_32x32 };
        public Keys BotW_SmallKeys = new() { maxKeys = 3, Image = Resources.keyBotW_32x32 };
        public Keys GTG_SmallKeys = new() { maxKeys = 9, Image = Resources.keyGTG_32x32 };
        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                OnValueChanged(null);
            }
        }
        private int _state;
        public KeyPanel(Point _location)
        {
            Size = new Size(80, 260);
            BackColor = Color.Black;
            Location = _location;                            
        }
        public void LoadSmallKeys(List<Keys> keys)
        {
            for (int i = 0; i < keys.Count; i++)
            {
                var temp = i;
                keys[i].Location = new Point(24, i * 34);
                Controls.Add(keys[temp]);
                Label label = new() { Text = "0", Location = new Point(57, i * 34 + 10), ForeColor = Color.White };
                Controls.Add(label);
                keys[temp].MouseDown += (sender, e) => UpdateLabel(keys[temp], label);            
                keys[i].MouseDown += (sender, e) => { State = 1; };
            }
        }
        public void LoadBossKeys(List<Item> BossKeys)
        {
            for (int i = 0; i < BossKeys.Count; i++)
            {
                var temp = i;
                Controls.Add(BossKeys[i]);
                BossKeys[temp].Location = new Point(0, i * 34 + 10);
                BossKeys[temp].Size = new Size(20, 20);
                BossKeys[temp].Image = BossKeys[temp].ItemPicture_bw;
                BossKeys[temp].MouseDown += (sender, e) => { State = 1; };
            }
        }
        public static void UpdateLabel(Keys k, Label l)
        {
            l.Text = k.currentKeys.ToString();          
        }

        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
    }
}
