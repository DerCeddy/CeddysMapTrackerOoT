using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class DungeonInfoElement : UserControl
    {
        public PictureBox DungeonImage = new() { Size = new Size(48, 48), SizeMode = PictureBoxSizeMode.StretchImage};
        public DungeonInfoItemsCounter ItemCounter = new();
        public Label CurrentKeys = new() { Size = new Size(16,20), Font = new Font("Arial",16,GraphicsUnit.Pixel)};
        public Label MaxKeys = new() { Size = new Size(28, 20), Font = new Font("Arial", 16, GraphicsUnit.Pixel) };
        public List<Region_Panel_Check> Checks = new();
        public DungeonInfoElement(Bitmap Image, int MaxKeys_Int)
        {
            {
                Size = new Size(48,160);
                DungeonImage.Image = Image;
                DungeonImage.Location = new Point(0,35);
                ItemCounter.Location = new Point(0,83);
                CurrentKeys.Text = "0";
                MaxKeys.Text = $"/ {MaxKeys_Int}";
                CurrentKeys.Location = new Point(5,134);
                MaxKeys.Location = new Point(19, 134);
                Controls.Add(DungeonImage);
                Controls.Add(ItemCounter);
                Controls.Add(CurrentKeys);
                Controls.Add(MaxKeys);
            }
        }
        public void UpdateItemCounterText(Keys Key)
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
            Checks_Display = Checks_Max - (Key.maxKeys - Key.currentKeys) - Checks_Done; 
            ItemCounter.Text = Checks_Display.ToString();
            ItemCounter.ItemAmount = Checks_Display;
        }
    }
}
