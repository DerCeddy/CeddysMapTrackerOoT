using CeddyMapTracker.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class Keys : PictureBox
    {
        public int maxKeys;
        public int currentKeys;
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
        public Keys()
        {
            Size = new Size(32, 32);
            SizeMode = PictureBoxSizeMode.StretchImage;
            MouseDown += (sender,e) => KeyClick(e, this);
        }
        public static void KeyClick(MouseEventArgs e, Keys key)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    if (key.maxKeys == key.currentKeys)
                    {

                    }
                    else
                    {
                        key.currentKeys++;                       
                    }
                    break;
                case MouseButtons.Right:
                    if (key.currentKeys == 0)
                    {

                    }
                    else
                    {
                        key.currentKeys--;                      
                    }
                    break;
            }
            switch(key.currentKeys)
            {
                case 0:
                    key.KeyCount1_Color = Color.Red;
                    key.KeyCount2_Color = Color.Red;
                    key.KeyCount3_Color = Color.Red;
                    key.KeyCount4_Color = Color.Red;
                    key.KeyCount5_Color = Color.Red;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 1:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.Red;
                    key.KeyCount3_Color = Color.Red;
                    key.KeyCount4_Color = Color.Red;
                    key.KeyCount5_Color = Color.Red;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 2:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.Red;
                    key.KeyCount4_Color = Color.Red;
                    key.KeyCount5_Color = Color.Red;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 3:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.Red;
                    key.KeyCount5_Color = Color.Red;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 4:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.Red;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 5:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.LimeGreen;
                    key.KeyCount6_Color = Color.Red;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 6:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.LimeGreen;
                    key.KeyCount6_Color = Color.LimeGreen;
                    key.KeyCount7_Color = Color.Red;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 7:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.LimeGreen;
                    key.KeyCount6_Color = Color.LimeGreen;
                    key.KeyCount7_Color = Color.LimeGreen;
                    key.KeyCount8_Color = Color.Red;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 8:
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.LimeGreen;
                    key.KeyCount6_Color = Color.LimeGreen;
                    key.KeyCount7_Color = Color.LimeGreen;
                    key.KeyCount8_Color = Color.LimeGreen;
                    key.KeyCount9_Color = Color.Red;
                    break;
                case 9:               
                    key.KeyCount1_Color = Color.LimeGreen;
                    key.KeyCount2_Color = Color.LimeGreen;
                    key.KeyCount3_Color = Color.LimeGreen;
                    key.KeyCount4_Color = Color.LimeGreen;
                    key.KeyCount5_Color = Color.LimeGreen;
                    key.KeyCount6_Color = Color.LimeGreen;
                    key.KeyCount7_Color = Color.LimeGreen;
                    key.KeyCount8_Color = Color.LimeGreen;
                    key.KeyCount9_Color = Color.LimeGreen;
                    break;

            }
        }      
    }   
}
