using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace CeddyMapTracker
{
    public class DungeonInfoElement : UserControl
    {
        public PictureBox DungeonImage = new() { Size = new Size(48, 48), SizeMode = PictureBoxSizeMode.StretchImage};
        public DungeonInfoItemsCounter ItemCounter = new();
        public Item BossKey = new() {Item_Name = "Test"};
        public int CurrentKeys
        {
            get
            {
                return _currentKeys;
            }
            set
            {
                _currentKeys = value;
                if(CurrentKeys >= MaxKeys)
                {
                    _currentKeys = MaxKeys;
                }
                if (CurrentKeys < 0)
                {
                    CurrentKeys = 0;
                }
                OnValueChanged(null);
            }
        }
        private int _currentKeys;
        public Label CurrentKeys_Label = new() { Size = new Size(16,20), Font = new Font("Arial",16,GraphicsUnit.Pixel), ForeColor = Color.White};
        public Label MaxKeys_Label = new() { Size = new Size(28, 20), Font = new Font("Arial", 16, GraphicsUnit.Pixel), ForeColor = Color.White };
        public int MaxKeys;      
        public BindingList<Region_Panel_Check> Checks = new();
        public string KeyCount1;
        public string KeyCount2;
        public string KeyCount3;
        public string KeyCount4;
        public string KeyCount5;
        public string KeyCount6;
        public string KeyCount7;
        public string KeyCount8;
        public string KeyCount9;
        public Color KeyCount1_Color = Color.Red;
        public Color KeyCount2_Color = Color.Red;
        public Color KeyCount3_Color = Color.Red;
        public Color KeyCount4_Color = Color.Red;
        public Color KeyCount5_Color = Color.Red;
        public Color KeyCount6_Color = Color.Red;
        public Color KeyCount7_Color = Color.Red;
        public Color KeyCount8_Color = Color.Red;
        public Color KeyCount9_Color = Color.Red;
        public DungeonInfoElement(Bitmap Image, int MaxKeys_Int)
        {
            {
                MaxKeys = MaxKeys_Int;
                Size = new Size(48,200);
                DungeonImage.Image = Image;
                DungeonImage.Location = new Point(0,35);
                ItemCounter.Location = new Point(0,83);
                CurrentKeys_Label.Text = CurrentKeys.ToString();
                MaxKeys_Label.Text = $"/ {MaxKeys_Int}";
                CurrentKeys_Label.Location = new Point(5,134);
                MaxKeys_Label.Location = new Point(19, 134);
                Controls.Add(DungeonImage);
                Controls.Add(ItemCounter);
                Controls.Add(CurrentKeys_Label);
                Controls.Add(MaxKeys_Label);
                KeyCountChanged += (sender,e) => UpdateKeyColor();
                KeyCountChanged += (sender, e) => UpdateKeyCounter();
            }
        }
        public void UpdateItemCounterText()
        {
            int Checks_Done = 0;
            int Checks_Max = 0;
            int Checks_Display = 0;
            foreach (Region_Panel_Check check in Checks)
            {
                Checks_Max++;
                if(check.Checked)
                {
                    Checks_Done++;
                }
            }
            Checks_Display = Checks_Max - (MaxKeys - CurrentKeys) - (BossKey.MaxCount - BossKey.State) - Checks_Done; 
            ItemCounter.Text = Checks_Display.ToString();
            ItemCounter.ItemAmount = Checks_Display;
        }
        public void UpdateKeyColor()
        {
            switch (CurrentKeys)
            {
                case 0:
                    KeyCount1_Color = Color.Red;
                    KeyCount2_Color = Color.Red;
                    KeyCount3_Color = Color.Red;
                    KeyCount4_Color = Color.Red;
                    KeyCount5_Color = Color.Red;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 1:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.Red;
                    KeyCount3_Color = Color.Red;
                    KeyCount4_Color = Color.Red;
                    KeyCount5_Color = Color.Red;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 2:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.Red;
                    KeyCount4_Color = Color.Red;
                    KeyCount5_Color = Color.Red;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 3:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.Red;
                    KeyCount5_Color = Color.Red;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 4:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.Red;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 5:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.LimeGreen;
                    KeyCount6_Color = Color.Red;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 6:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.LimeGreen;
                    KeyCount6_Color = Color.LimeGreen;
                    KeyCount7_Color = Color.Red;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 7:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.LimeGreen;
                    KeyCount6_Color = Color.LimeGreen;
                    KeyCount7_Color = Color.LimeGreen;
                    KeyCount8_Color = Color.Red;
                    KeyCount9_Color = Color.Red;
                    break;
                case 8:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.LimeGreen;
                    KeyCount6_Color = Color.LimeGreen;
                    KeyCount7_Color = Color.LimeGreen;
                    KeyCount8_Color = Color.LimeGreen;
                    KeyCount9_Color = Color.Red;
                    break;
                case 9:
                    KeyCount1_Color = Color.LimeGreen;
                    KeyCount2_Color = Color.LimeGreen;
                    KeyCount3_Color = Color.LimeGreen;
                    KeyCount4_Color = Color.LimeGreen;
                    KeyCount5_Color = Color.LimeGreen;
                    KeyCount6_Color = Color.LimeGreen;
                    KeyCount7_Color = Color.LimeGreen;
                    KeyCount8_Color = Color.LimeGreen;
                    KeyCount9_Color = Color.LimeGreen;
                    break;
            }
        }
        public void UpdateKeyCounter()
        {
            CurrentKeys_Label.Text = CurrentKeys.ToString();
        }
        public event EventHandler KeyCountChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (KeyCountChanged != null)
                KeyCountChanged(this, e);
        }
    }
}
