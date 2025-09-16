using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class RichToolTip : RichTextBox
    {
        public string CheckName;
        public string CheckLogic;
        public RichToolTip()
        {          
            Size = new Size(200,200);                      
            BackColor = Color.Black;
            ForeColor = Color.White;
            ContentsResized += rtb_ContentsResized;
            Font = new Font("Arial", 12, GraphicsUnit.Pixel);
        } 
        private void DrawText()
        {
            AppendText(CheckName);
            AppendText(CheckLogic);           
        }
        public void DrawToolTip(Control Control)
        {
            Control.Controls.Add(this);          
            DrawText();
            BringToFront();
        }       
        public void DeleteToolTip(Control Control)
        {
            Control.Controls.Remove(this);
            Text = null;
        }
        public void SetLocation(Control c, Point CheckLocation)
        {
            int LocationX = Location.X;
            int LocationY = Location.Y;
            if (Location.X + Size.Width >= c.Size.Width)
            {
                LocationX = c.Size.Width - Size.Width;
            }
            if (Location.Y + Size.Height >= c.Size.Height)
            {
                LocationY = CheckLocation.Y - Size.Height;
            }
            Location = new Point(LocationX, LocationY);
        }       
        public void RichToolTipTextChanged(ItemPanel i, KeyPanel KeyPanel, Maptracker MapTracker)
        {
            CheckKeyWord("Nothing", Color.LimeGreen, 0);
            CheckKeyWord("•", Color.White, 0);
            CheckKeyWord("Ganon's Castle Access", MapTracker.RainBowBridge_Color, 0);
            foreach (Control c in i.Controls)
            {
               if(c is Item Item && c!= null)
               {
                    CheckKeyWord(Item.Item_Name, Item.NameColor, 0);
                    if(Item.Item_Name1 != null)
                    {
                        CheckKeyWord(Item.Item_Name1, Item.NameColor1, 0);
                    }
                    if (Item.Item_Name2 != null)
                    {
                        CheckKeyWord(Item.Item_Name2, Item.NameColor2, 0);
                    }
                    if (Item.Item_Name3 != null)
                    {
                        CheckKeyWord(Item.Item_Name3, Item.NameColor3, 0);
                    }
               }               
            }
            foreach (Control c in KeyPanel.Controls)
            {
                if (c is Keys Key && c != null)
                {
                    CheckKeyWord(Key.KeyCount1, Key.KeyCount1_Color, 0);
                    if (Key.KeyCount1 != null)
                    {
                        CheckKeyWord(Key.KeyCount1, Key.KeyCount1_Color, 0);
                    }
                    if (Key.KeyCount2 != null)
                    {
                        CheckKeyWord(Key.KeyCount2, Key.KeyCount2_Color, 0);
                    }
                    if (Key.KeyCount3 != null)
                    {
                        CheckKeyWord(Key.KeyCount3, Key.KeyCount3_Color, 0);
                    }
                    if (Key.KeyCount4 != null)
                    {
                        CheckKeyWord(Key.KeyCount4, Key.KeyCount4_Color, 0);
                    }
                    if (Key.KeyCount5 != null)
                    {
                        CheckKeyWord(Key.KeyCount5, Key.KeyCount5_Color, 0);
                    }
                    if (Key.KeyCount6 != null)
                    {
                        CheckKeyWord(Key.KeyCount6, Key.KeyCount6_Color, 0);
                    }
                    if (Key.KeyCount7 != null)
                    {
                        CheckKeyWord(Key.KeyCount7, Key.KeyCount7_Color, 0);
                    }
                    if (Key.KeyCount8 != null)
                    {
                        CheckKeyWord(Key.KeyCount8, Key.KeyCount8_Color, 0);
                    }
                    if (Key.KeyCount9 != null)
                    {
                        CheckKeyWord(Key.KeyCount9, Key.KeyCount9_Color, 0);
                    }
                }
                if(c is Item Bosskey && c != null)
                {
                    CheckKeyWord(Bosskey.Item_Name, Bosskey.NameColor, 0);
                }
            }
        }
        public void CheckKeyWord(string Word, Color Color, int StartIndex)
        {
            if(CheckLogic.Contains(Word))
            {
                int index = -1;
                int selectStart = SelectionStart;
                while((index = Text.IndexOf(Word, index + 1)) != -1)
                {
                    Select(index + StartIndex, Word.Length);                   
                    SelectionColor = Color; 
                    if(CheckName != null)
                    {
                        Select(0, CheckName.Length);
                        SelectionColor = Color.White;
                        SelectionFont = new Font(Font, FontStyle.Bold);
                    }                                     
                }
            }

        }
        private void rtb_ContentsResized(object sender, ContentsResizedEventArgs e)
        {
            ((RichToolTip)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
