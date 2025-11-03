using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CeddyMapTracker.Maptracker;

namespace CeddyMapTracker
{
    public class SometimesHint : UserControl
    {
        public ComboBox ComboBox = new() { Size = new Size(200, 20), Location = new Point(0,0)};
        public Gossipstone Gossipstone = new() { Location = new Point(200,0)};
        public Gossipstone Gossipstone2 = new() { Location = new Point(224, 0) };
        public int SometimesHintIndex;
        public int SometimesHintIndex2;

        public SometimesHint(string Type)
        {
            Size = new Size(270, 24);
            BackColor = Color.Black;
            Controls.Add(ComboBox);
            if (Type == "Single")
            {
                Controls.Add(Gossipstone);
                //Size = new Size(56, 32);
            }
            else if (Type == "Dual")
            {               
                Controls.Add(Gossipstone);
                Controls.Add(Gossipstone2);               
                //Size = new Size(88, 32);
            }
        }
        public void CheckCheckOnMaptracker(Maptracker Maptracker, string Checkname)
        {
            AssignIndexFromText(Checkname);
            //Gossipstone 1
            if (Gossipstone.State == 1)
            {
                foreach (Control control in Maptracker.Controls)
                {
                    if (control != null && control is Check Check)
                    {
                        if (Check.CheckIndex == SometimesHintIndex && Check.CheckIndex != 0)
                        {
                            Check.Done = true;
                        }
                    }
                }
                foreach (Region_Panel_Check RegionCheck in Maptracker.SometimesHintChecks)
                {
                    if (RegionCheck.CheckIndex == SometimesHintIndex && RegionCheck.CheckIndex != 0)
                    {
                        RegionCheck.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control control in Maptracker.Controls)
                {
                    if (control != null && control is Check Check)
                    {
                        if (Check.CheckIndex == SometimesHintIndex)
                        {
                            if (Check.PressedCheck == false)
                            {
                                Check.Done = false;
                            }
                        }
                    }
                }
                foreach (Region_Panel_Check RegionCheck in Maptracker.SometimesHintChecks)
                {
                    if (RegionCheck.CheckIndex == SometimesHintIndex)
                    {
                        if (RegionCheck.UserClickedCheck == false)
                        {
                            RegionCheck.Checked = false;
                        }
                    }
                }
            }
            //Gossipstone 2
            if (Gossipstone2.State == 1)
            {
                foreach (Control control in Maptracker.Controls)
                {
                    if (control != null && control is Check Check)
                    {
                        if (Check.CheckIndex == SometimesHintIndex2 && Check.CheckIndex != 0)
                        {
                            Check.Done = true;
                        }
                    }
                }
                foreach (Region_Panel_Check RegionCheck in Maptracker.SometimesHintChecks)
                {
                    if (RegionCheck.CheckIndex == SometimesHintIndex2 && RegionCheck.CheckIndex != 0)
                    {
                        RegionCheck.Checked = true;
                    }
                }
            }
            else
            {
                foreach (Control control in Maptracker.Controls)
                {
                    if (control != null && control is Check Check)
                    {
                        if (Check.CheckIndex == SometimesHintIndex2)
                        {
                            if (Check.PressedCheck == false)
                            {
                                Check.Done = false;
                            }
                        }
                    }
                }
                foreach (Region_Panel_Check RegionCheck in Maptracker.SometimesHintChecks)
                {
                    if (RegionCheck.CheckIndex == SometimesHintIndex2)
                    {
                        if (RegionCheck.UserClickedCheck == false)
                        {
                            RegionCheck.Checked = false;
                        }
                    }
                }
            }
        }
        public void AssignIndexFromText(string CheckName)
        {
            switch (CheckName)
            {
                case "Lost Woods Target in the Woods":
                    SometimesHintIndex = 50;
                    break;
                case "Lost Woods Skull Kid":
                    SometimesHintIndex = 51;
                    break;
                case "Market 10 Big Poes":
                    SometimesHintIndex = 52;
                    break;
                case "Market Treasure Chest Game":
                    SometimesHintIndex = 53;
                    break;
                case "Kakariko Child Anjus Chickens":
                    SometimesHintIndex = 54;
                    break;
                case "Graveyard Sun Song Chest":
                    SometimesHintIndex = 55;
                    break;
                case "Goron City Darunia’s Joy":
                    SometimesHintIndex = 56;
                    break;
                case "Lake Hylia Lab Dive":
                    SometimesHintIndex = 57;
                    break;
                case "Zora’s River Frogs in the Rain":
                    SometimesHintIndex = 10;
                    break;
                case "Domain King Zora Thawed":
                    SometimesHintIndex = 59;
                    break;
                case "Fountain Bottom of the Lake":
                    SometimesHintIndex = 60;
                    break;
                case "Haunted Wasteland Chest":
                    SometimesHintIndex = 61;
                    break;
                case "Jabu Boomerang Chest":
                    SometimesHintIndex = 62;
                    break;
                case "Fire Temple Hammer Chest":
                    SometimesHintIndex = 63;
                    break;
                case "Fire Temple Pierre Chest":
                    SometimesHintIndex = 64;
                    break;
                case "Water Temple Central Pillar":
                    SometimesHintIndex = 65;
                    break;
                case "GTG Silver Rupees Chest":
                    SometimesHintIndex = 66;
                    break;
                case "Gerudo Fortress Horseback Archery 1000 and 1500":
                    SometimesHintIndex = 120;
                    SometimesHintIndex2 = 120;
                    break;
                case "Graveyard Royal Tomb Song and Chest":
                    SometimesHintIndex = 121;
                    SometimesHintIndex2 = 122;
                    break;
                case "Lake Hylia Adult Bean Destinations":
                    SometimesHintIndex = 123;
                    SometimesHintIndex2 = 124;
                    break;
                case "Market Bombchu Bowling Rewards":
                    SometimesHintIndex = 125;
                    SometimesHintIndex2 = 125;
                    break;
                case "Water Temple Dark Link and River Chest":
                    SometimesHintIndex = 127;
                    SometimesHintIndex2 = 128;
                    break;
                case "Spirit Temple Colossus Hands":
                    SometimesHintIndex = 129;
                    SometimesHintIndex2 = 130;
                    break;
                case "Ice Cavern Final Chest and Song":
                    SometimesHintIndex = 6;
                    SometimesHintIndex2 = 7;
                    break;
                case "Zora Domain Child Checks":
                    SometimesHintIndex = 131;
                    SometimesHintIndex2 = 132;
                    break;
                case "Hyrule Castle and Outside Ganon’s Castle":
                    SometimesHintIndex = 8;
                    SometimesHintIndex2 = 9;
                    break;
                default:
                    SometimesHintIndex = 0;
                    SometimesHintIndex2 = 0;
                    break;
            }
        }
    }
}
