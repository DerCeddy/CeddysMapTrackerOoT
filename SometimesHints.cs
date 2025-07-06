using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SometimesHints : Panel
    {
        public string[] SingleHints = [];
        public string[] DualHints = [];
        public decimal Hint_Count = 3;
        public decimal Dual_Hint_Count = 7;
        private List<ComboBox> comboBoxes = [];
        private List<Gossipstone> gossipStones = [];
        public SometimesHints(Point _location)
        {
            Width = 300;
            AutoSize = true;
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Sometimes Hints" , Location = new Point(0,0), ForeColor = Color.White }; 
            Controls.Add(label);
            SingleHints = ["","20 Skulls", "Big Poes", "Chickens", "Composer Torches", "Darunia's Joy" , "Frogs 1", "Goron Pot", "King Zora", "Lab Dive", "Shoot the Sun", "Skull Kid", "Sun's Song Grave", "Target in the Woods", "Treasure Chest Game", "Wasteland Torches", "ZF Icy Waters", "Fire Temple Hammer Chest", "Fire Temple Scarecrow", "Ganon's Castle Shadow Trial 2", "GTG Toilet", "Ice Cavern Final Chest", "Jabu Stingers", "Shadow Temple Skull Pot", "Water Temple BK Chest", "Water Temple Central Pillar"];
            DualHints = ["", "Adult Lake Bean Checks", "Bombchu Bowling", "Castle Great Fairies", "Child Domain", "Gerudo Valley PoH Ledges", "Horseback Archery", "BotW Dead Hand", "Fire Temple Lower Hammer Loop", "Ganon's Castle Spirit Trial", "Shadow Temple Invisible Blades", "Shadow Temple Spiked Walls", "Spirit Temple Child Loop", "Spirit Temple Colossus Hands", "Spirit Temple Early Adult", "Water Temple Dark Link Loop"];
                     
        }
        public void GenerateHintsAndStones()
        {
            for (int i = 0; i < Hint_Count; i++)
            {
                //Comboboxes
                ComboBox comboBox = new() { Size = new Size(200, 20), Location = new Point(10, i * 28 + 24) };
                Controls.Add(comboBox);
                comboBoxes.Add(comboBox);
                //Gossipstones
                if (Dual_Hint_Count > i)
                {
                    comboBox.Items.AddRange(DualHints);
                    for (int j = 0; j < 2; j++)
                    {
                        Gossipstone gossipstone = new(new Point(220 + (24 * j), i * 28 + 24));
                        Controls.Add(gossipstone);
                        gossipStones.Add(gossipstone);
                    }
                }
                else
                {
                    comboBox.Items.AddRange(SingleHints);
                    Gossipstone gossipstone = new(new Point(220, i * 28 + 24));
                    Controls.Add(gossipstone);
                    gossipStones.Add(gossipstone);
                }
            }
        }
        public void DeleteHintsAndStones()
        {
            foreach (ComboBox cb in comboBoxes)
            {
                cb?.Dispose();
            }        
            foreach (Gossipstone gs in gossipStones)
            {
                gs?.Dispose();
            }           
        }
    }
}
