using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_Market(ItemPanel i)
        {
            //Bowling 
            if (Has(i.Bomb))
            {
                MarketBombchuBowling.color = Available;
            }
            else
            {
                MarketBombchuBowling.color = NotAvailable;
            }
            //Treasure Chest Game
            if (Has(i.Magic) && Has(i.Lens))
            {
                MarketTreasureChestGame.color = Available;
            }
            else
            {
                MarketTreasureChestGame.color = NotAvailable;
            }
            //Big Poes
            if (has_bottle && Has(i.Bow) && Has(i.EponasSong))
            {
                MarketBigPoes.color = Available;
            }
            else
            {
                MarketBigPoes.color = NotAvailable;
            }
        }
    }
}
