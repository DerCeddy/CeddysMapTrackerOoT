using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void AssignDungeonToEntrances(ItemPanel i)
        {       
            Deku_Tree_Access = DungeonER1(Deku_Tree_Access, i, Deku_RegionPanel.DungeonAccess);
            DC_Access = DungeonER1(DC_Access, i, DC_RegionPanel.DungeonAccess);
            Jabu_Access = DungeonER1(Jabu_Access, i, Jabu_RegionPanel.DungeonAccess);
            BotW_Access = DungeonER1(BotW_Access, i, BotW_RegionPanel.DungeonAccess);
            Forest_Temple_Access = DungeonER1(Forest_Temple_Access, i, Forest_RegionPanel.DungeonAccess);
            Fire_Temple_Access = DungeonER1(Fire_Temple_Access, i, Fire_RegionPanel.DungeonAccess);
            Water_Temple_Access = DungeonER1(Water_Temple_Access, i, Water_RegionPanel.DungeonAccess);
            Shadow_Temple_Access = DungeonER1(Shadow_Temple_Access, i, Shadow_RegionPanel.DungeonAccess);
            Spirit_Temple_Access = DungeonER1(Spirit_Temple_Access, i, Spirit_RegionPanel.DungeonAccess);
            GTG_Access = DungeonER1(GTG_Access,i, GTG_RegionPanel.DungeonAccess);
            Ice_Access = DungeonER1(Ice_Access, i, Ice_RegionPanel.DungeonAccess);
        }
        public bool DungeonER1(bool Dungeon, ItemPanel i, int DungeonAccess)
        {
            //Dungeon Access
            switch (DungeonAccess)
            {
                case 0:
                    if(Has(i.KokiriSword))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 1:
                    Dungeon = true;
                    return Dungeon;
                case 2:
                    if(Has(i.RutoLetter) && (Has(i.Scales) || (i.Bomb.State == 1 && Has(i.ZeldasLullaby)))) 
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 3:
                    if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 4:
                    if(craterplatformaccess == 1)
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 5:
                    if((Has(i.Hookshot) && Has(i.IronBoots)) || (has_longshot && i.Scales.State == 2))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 6:
                    if(Has(i.Dins) && Has(i.Magic) && Has(i.Nocturne))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 7:
                    if(desertaccess == 1)
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 8:
                    if(Has(i.SongOfStorms))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 9:
                    if ((Has(i.EponasSong) || has_longshot) && Has(i.GerudoCard))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                case 10:
                    if(Has(i.RutoLetter) && Has(i.ZeldasLullaby) && (Has(i.Bomb) || Has(i.Scales)))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    return Dungeon;
                default:
                    return Dungeon;
            }
        }
        public void DungeonER2(bool Dungeon, ItemPanel i, int DungeonAccess)
        {
            //Dungeon Access
            switch (DungeonAccess)
            {
                case 0:
                    if (Has(i.KokiriSword))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 1:
                    Dungeon = true;
                    break;
                case 2:
                    if (Has(i.RutoLetter) && (Has(i.Scales) || (i.Bomb.State == 1 && Has(i.ZeldasLullaby))))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 3:
                    if ((Has(i.SariasSong) || Has(i.Minuet)) && Has(i.Hookshot))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 4:
                    if (craterplatformaccess == 1)
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 5:
                    if ((Has(i.Hookshot) && Has(i.IronBoots)) || (has_longshot && i.Scales.State == 2))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 6:
                    if (Has(i.Dins) && Has(i.Magic) && Has(i.Nocturne))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 7:
                    if (desertaccess == 1)
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 8:
                    if (Has(i.SongOfStorms))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 9:
                    if (Has(i.EponasSong) || has_longshot)
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                case 10:
                    if (Has(i.RutoLetter) && Has(i.ZeldasLullaby) && (Has(i.Bomb) || Has(i.Scales)))
                    {
                        Dungeon = true;
                    }
                    else
                    {
                        Dungeon = false;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
