using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    public class SometimesHints : Panel
    {
        public SometimesHints(Point _location)
        {
            Size = new Size(300,250);
            BackColor = Color.Black;
            Location = _location;
            Label label = new() { Text = "Sometimes Hints" , Location = new Point(0,0), ForeColor = Color.White }; 
            Controls.Add(label);
            string[] SingleHints = ["","20 Skulls", "Big Poes", "Chickens", "Composer Torches", "Darunia's Joy" , "Frogs 1", "Goron Pot", "King Zora", "Lab Dive", "Shoot the Sun", "Skull Kid", "Sun's Song Grave", "Target in the Woods", "Treasure Chest Game", "Wasteland Torches", "ZF Icy Waters", "Fire Temple Hammer Chest", "Fire Temple Scarecrow", "Ganon's Castle Shadow Trial 2", "GTG Toilet", "Ice Cavern Final Chest", "Jabu Stingers", "Shadow Temple Skull Pot", "Water Temple BK Chest", "Water Temple Central Pillar"];
            string[] DualHints = ["", "Adult Lake Bean Checks", "Bombchu Bowling", "Castle Great Fairies", "Child Domain", "Gerudo Valley PoH Ledges", "Horseback Archery", "BotW Dead Hand", "Fire Temple Lower Hammer Loop", "Ganon's Castle Spirit Trial", "Shadow Temple Invisible Blades", "Shadow Temple Spiked Walls", "Spirit Temple Child Loop", "Spirit Temple Colossus Hands", "Spirit Temple Early Adult", "Water Temple Dark Link Loop"];
            for(int i = 0; i < 8; i++)
            {
                //Comboboxes
                ComboBox comboBox = new() { Size = new Size(200,20), Location = new Point(10,i*28 + 24)};
                
                Controls.Add(comboBox);
                //Gossipstones
                if (2 > i)
                {
                    comboBox.Items.AddRange(DualHints);
                    for (int j = 0; j < 2; j++)
                    {
                        Gossipstone gossipstone = new(new Point(220 + (24 * j), i * 28 + 24));
                        Controls.Add(gossipstone);
                    }
                }
                else
                {
                    comboBox.Items.AddRange(SingleHints);
                    Gossipstone gossipstone = new(new Point(220, i * 28 + 24));
                    Controls.Add(gossipstone);
                }
            }          
        }
    }
}
