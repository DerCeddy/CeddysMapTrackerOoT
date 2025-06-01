using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OoTItemTrackerNew
{
    partial class Maptracker
    {
        public void ItemLogic_GoronCity(ItemPanel i)
        {
            //Darunia Joy
            if (Has(i.ZeldasLullaby) && Has(i.SariasSong))
            {
                GCDaruniasJoy.ForeColor = Available;
            }
            else
            {
                GCDaruniasJoy.ForeColor = NotAvailable;
            }
            //Pot PoH
            if (has_explosives && (Has(i.ZeldasLullaby) || Has(i.Dins) && Has(i.Magic)))
            {
                GCPotFreestandingPoH.ForeColor = Available;
            }
            else if (Has(i.Bombchu) && (Has(i.ZeldasLullaby) || Has(i.Dins) && Has(i.Magic)))
            {
                GCPotFreestandingPoH.ForeColor = OoLwithBombchus;
            }
            else
            {
                GCPotFreestandingPoH.ForeColor = NotAvailable;
            }
            //Rolling Goron Child
            if (has_explosives)
            {
                GCRollingGoronasChild.ForeColor = Available;
            }
            else if (Has(i.Bombchu))
            {
                GCRollingGoronasChild.ForeColor = OoLwithBombchus;
            }
            else
            {
                GCRollingGoronasChild.ForeColor = NotAvailable;
            }
            //Rolling Goron Adult
            if (has_explosives || Has(i.Strength) || Has(i.Bow))
            {
                GCRollingGoronasAdult.ForeColor = Available;
            }
            else if (Has(i.Bombchu))
            {
                GCRollingGoronasAdult.ForeColor = OoLwithBombchus;
            }
            else
            {
                GCRollingGoronasAdult.ForeColor = NotAvailable;
            }
            //Maze Center and Right
            if (can_blast_or_smash || i.Strength.State > 1)
            {
                GCMazeRightChest.ForeColor = Available;
                GCMazeCenterChest.ForeColor = Available;
            }
            else if (Has(i.Bombchu))
            {
                GCMazeRightChest.ForeColor = OoLwithBombchus;
                GCMazeCenterChest.ForeColor = OoLwithBombchus;
            }
            else
            {
                GCMazeRightChest.ForeColor = NotAvailable;
                GCMazeCenterChest.ForeColor = NotAvailable;
            }
            //Maze Left
            if (Has(i.Hammer) || i.Strength.State > 1)
            {
                GCMazeLeftChest.ForeColor = Available;
            }
            else
            {
                GCMazeLeftChest.ForeColor = NotAvailable;
            }
            //Skulls
            if (has_explosives)
            {
                tokensAvailable += 1;
            }
        }
    }
}
