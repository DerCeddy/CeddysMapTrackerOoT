using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CeddyMapTracker
{
    public class DungeonInfoPanel : UserControl
    {
        public Item ForestBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Forest Temple Boss Key" };
        public Item FireBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Fire Temple Boss Key" };
        public Item WaterBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Water Temple Boss Key" };
        public Item ShadowBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Shadow Temple Boss Key" };
        public Item SpiritBossKey = new() { ItemPicture = Resources.OoT3D_Boss_Key_Icon, State = 0, MaxCount = 1, MinCount = 0, ItemPicture_bw = Resources.OoT3D_Boss_Key_Icon_bw, Item_Name = "Spirit Temple Boss Key" };
        public DungeonInfoElement ForestTemple = new(Resources.pg_32x32, 5) { KeyCount1 = "Forest Temple Small Keys 1x", KeyCount2 = "Forest Temple Small Keys 2x", KeyCount3 = "Forest Temple Small Keys 3x", KeyCount4 = "Forest Temple Small Keys 4x", KeyCount5 = "Forest Temple Small Keys 5x" };
        public DungeonInfoElement FireTemple = new(Resources.volvagia_32x32, 8) { KeyCount1 = "Fire Temple Small Keys 1x", KeyCount2 = "Fire Temple Small Keys 2x", KeyCount3 = "Fire Temple Small Keys 3x", KeyCount4 = "Fire Temple Small Keys 4x", KeyCount5 = "Fire Temple Small Keys 5x", KeyCount6 = "Fire Temple Small Keys 6x", KeyCount7 = "Fire Temple Small Keys 7x", KeyCount8 = "Fire Temple Small Keys 8x" };
        public DungeonInfoElement WaterTemple = new(Resources.morpha_32x32, 6) { KeyCount1 = "Water Temple Small Keys 1x", KeyCount2 = "Water Temple Small Keys 2x", KeyCount3 = "Water Temple Small Keys 3x", KeyCount4 = "Water Temple Small Keys 4x", KeyCount5 = "Water Temple Small Keys 5x", KeyCount6 = "Water Temple Small Keys 6x" };
        public DungeonInfoElement ShadowTemple = new(Resources.bongo_32x32, 5) { KeyCount1 = "Shadow Temple Small Keys 1x", KeyCount2 = "Shadow Temple Small Keys 2x", KeyCount3 = "Shadow Temple Small Keys 3x", KeyCount4 = "Shadow Temple Small Keys 4x", KeyCount5 = "Shadow Temple Small Keys 5x" };
        public DungeonInfoElement SpiritTemple = new(Resources.twinrova_32x32, 5) { KeyCount1 = "Spirit Temple Small Keys 1x", KeyCount2 = "Spirit Temple Small Keys 2x", KeyCount3 = "Spirit Temple Small Keys 3x", KeyCount4 = "Spirit Temple Small Keys 4x", KeyCount5 = "Spirit Temple Small Keys 5x" };       
        public DungeonInfoElement BotW = new(Resources.pg_32x32, 3) { KeyCount1 = "Bottom of the Well Small Keys 1x", KeyCount2 = "Bottom of the Well Small Keys 2x", KeyCount3 = "Bottom of the Well Small Keys 3x" };
        public DungeonInfoElement GTG = new(Resources.pg_32x32, 9) { KeyCount1 = "Gerudo Training Ground Small Keys 1x", KeyCount2 = "Gerudo Training Ground Small Keys 2x", KeyCount3 = "Gerudo Training Ground Small Keys 3x", KeyCount4 = "Gerudo Training Ground Small Keys 4x", KeyCount5 = "Gerudo Training Ground Small Keys 5x", KeyCount6 = "Gerudo Training Ground Small Keys 6x", KeyCount7 = "Fire Temple Small Keys 7x", KeyCount8 = "Gerudo Training Ground Small Keys 8x", KeyCount9 = "Gerudo Training Ground Small Keys 9x" };
        public List<DungeonInfoElement> DungeonInfoElements = [];

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
        public DungeonInfoPanel()
        {
            Size = new Size(336,200);           
            BackColor = Color.Black;
            ForestTemple.Location = new Point(0, 0);
            ForestTemple.BossKey = ForestBossKey;
            FireTemple.BossKey = FireBossKey;
            WaterTemple.BossKey = WaterBossKey;
            ShadowTemple.BossKey = ShadowBossKey;
            SpiritTemple.BossKey = SpiritBossKey;
            DungeonInfoElements = [ForestTemple, FireTemple, WaterTemple, ShadowTemple, SpiritTemple, BotW, GTG];
            AddElements();
        }
        public event EventHandler ValueChanged;
        protected virtual void OnValueChanged(EventArgs e)
        {
            if (ValueChanged != null)
                ValueChanged(this, e);
        }
        public void AddElements()
        {
            for(int i = 0; i < DungeonInfoElements.Count; i++)
            {
                Controls.Add(DungeonInfoElements[i]);
                if(i >= 5)
                {
                    DungeonInfoElements[i].Location = new Point(48 * i, 0);
                    DungeonInfoElements[i].Controls.Add(DungeonInfoElements[i].BossKey);
                }
                else
                {
                    DungeonInfoElements[i].Location = new Point(48 * i, 0);
                    DungeonInfoElements[i].Controls.Add(DungeonInfoElements[i].BossKey);
                    DungeonInfoElements[i].BossKey.Location = new Point(0, 154);
                    DungeonInfoElements[i].BossKey.ValueChanged += (sender,e) => State = 1;
                    DungeonInfoElements[i].BossKey.Image = DungeonInfoElements[i].BossKey.ItemPicture_bw;

                }                    
            }          
        }
    }
}
