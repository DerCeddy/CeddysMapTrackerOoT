using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public string Goalrequirement = "SGL";
        public decimal Medallions = 0;
        public decimal Stones = 0;
        public decimal DungeonRewards = 0;
        public void ItemLogic_Helper(ItemPanel i)
        {                           
            //Explosives
            if (Has(i.Bomb))
            {
                has_explosives = true;
            }
            else
            {
                has_explosives = false;
            }
            if (Has(i.Bomb) || Has(i.Hammer))
            {
                can_blast_or_smash = true;
            }
            else
            {
                can_blast_or_smash = false;
            }
            //Longshot
            if (i.Hookshot.State == 2)
            {
                has_longshot = true;
            }
            else
            {
                has_longshot = false;
            }
            //Has Fire Source
            if (Has(i.Magic) && (Has(i.Dins) || (Has(i.Bow) && Has(i.FireArrow))))
            {
                has_firesource = true;
            }
            else
            {
                has_firesource = false;
            }
            //Can buy Goron Tunic or has it
            if (Has(i.GoronTunic) || (Has(i.Wallet) && (Has(i.ZeldasLullaby) || (Has(i.Bomb) || Has(i.Strength) || Has(i.Bow)))))
            {
                has_or_can_red_tunic = 1;
            }
            else
            {
                has_or_can_red_tunic = 0;
            }
            if (Has(i.GerudoCard) || Has(i.EponasSong) || has_longshot)
            {
                has_or_can_get_gerudocard = true;
            }
            else
            {
                has_or_can_get_gerudocard = false;
            }
            //Has Bottle
            if ((Has(i.RutoLetter) && (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))) || Has(i.Bottle2) || Has(i.Bottle3) || Has(i.Bottle4))
            {
                has_bottle = true;
            }
            else
            {
                has_bottle = false;
            }
            //Can get Beans
            if (Has(i.Bomb) || Has(i.Scales))
            {
                can_get_beans = true;
            }
            else
            {
                can_get_beans = false;
            }
            if (has_or_can_get_gerudocard && Has(i.Lens) && Has(i.Magic) && (Has(i.HoverBoots) || has_longshot))
            {
                wastelandcrossing = 1;
            }
            else
            {
                wastelandcrossing = 0;
            }
            if (Has(i.Reqiuem) || wastelandcrossing == 1)
            {
                desertaccess = 1;
            }
            else
            {
                desertaccess = 0;
            }
            if (Has(i.Bolero) || ((Has(i.Hookshot) || Has(i.HoverBoots)) && (Has(i.Bomb) || Has(i.Bow) || Has(i.Strength))))
            {
                craterplatformaccess = 1;
            }
            else
            {
                craterplatformaccess = 0;
            }
            //Rainbowbridge
            switch (Goalrequirement)
            {
                case "Spiritual Stones":
                    {                    
                        int StonesGotten = 0;
                        List<int> stones = new() { i.KokiriStone.State, i.GoronStone.State, i.ZoraStone.State };
                        for (int j = 0; j < stones.Count; j++)
                        {
                            if (stones[j] == 1)
                            {
                                StonesGotten++;
                            }
                        }
                        if (StonesGotten >= Stones)
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;                                              
                    }                   
                case "Medallions":
                    {
                        int MedsGotten = 0;
                        List<int> meds = new() { i.ForestMedallion.State, i.FireMedallion.State, i.WaterMedallion.State, i.SpiritMedallion.State, i.ShadowMedallion.State, i.LightMedallion.State };
                        for (int j = 0; j < meds.Count; j++)
                        {
                            if (meds[j] == 1)
                            {
                                MedsGotten++;
                            }
                        }
                        if (MedsGotten >= Medallions)
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
                case "Dungeon Rewards":
                    {
                        int DungeonRewardsGotten = 0;
                        List<int> dungeonrewards = new() { i.KokiriStone.State, i.GoronStone.State, i.ZoraStone.State, i.ForestMedallion.State, i.FireMedallion.State, i.WaterMedallion.State, i.SpiritMedallion.State, i.ShadowMedallion.State, i.LightMedallion.State };
                        for (int j = 0; j < dungeonrewards.Count; j++)
                        {
                            if (dungeonrewards[j] == 1)
                            {
                                DungeonRewardsGotten++;
                            }
                        }
                        if (DungeonRewardsGotten >= DungeonRewards)
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }      
                case "Vanilla Requirements":
                    {
                        if (Has(i.SpiritMedallion) && Has(i.ShadowMedallion) && Has(i.LightArrow))
                        {
                            rainbowbridge = true;
                        }
                        else
                        {
                            rainbowbridge = false;
                        }
                        break;
                    }
            }
        }
    }
}
