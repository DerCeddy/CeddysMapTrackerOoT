using OoTItemTrackerNew.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OoTItemTrackerNew
{
    public class Keys : PictureBox
    {
        public int maxKeys;
        public int currentKeys;  
        public Keys()
        {
            Size = new Size(32, 32);
            SizeMode = PictureBoxSizeMode.StretchImage;
            MouseDown += (sender,e) => KeyClick(sender,e, this);
        }
        public static void KeyClick(object sender, MouseEventArgs e, Keys key)
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
        }      
    }   
}
