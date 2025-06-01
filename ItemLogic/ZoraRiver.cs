using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_ZoraRiver(ItemPanel i)
        {           
            //Both PoH
            if (i.Bomb.State == 1 || Has(i.Scales) || Has(i.HoverBoots))
            {
                ZRNearGrottoPoH.color = Available;
                ZRPoHNearDomain.color = Available;
            }
            else if (Has(i.Bombchu))
            {
                ZRNearGrottoPoH.color = OoLwithBombchus;
                ZRPoHNearDomain.color = OoLwithBombchus;
            }
            else
            {
                ZRNearGrottoPoH.color = NotAvailable;
                ZRPoHNearDomain.color = NotAvailable;
            }
            //Frogs1
            if (Has(i.SongOfStorms) && (i.Bomb.State == 1 || Has(i.Scales)))
            {
                ZRFrogsStorms.color = Available;
            }
            else if (Has(i.SongOfStorms) && Has(i.Bombchu))
            {
                ZRFrogsStorms.color = OoLwithBombchus;
            }
            else
            {
                ZRFrogsStorms.color = NotAvailable;
            }
            //FrogGame
            if ((Has(i.ZeldasLullaby) && Has(i.EponasSong) && Has(i.SariasSong) && Has(i.SunSong) && Has(i.SongOfStorms) && Has(i.SongOfTime)) && (Has(i.Scales) || i.Bomb.State == 1))
            {
                ZRFrogsGame.color = Available;
            }
            else if ((Has(i.ZeldasLullaby) && Has(i.EponasSong) && Has(i.SariasSong) && Has(i.SunSong) && Has(i.SongOfStorms) && Has(i.SongOfTime)) && Has(i.Bombchu))
            {
                ZRFrogsGame.color = OoLwithBombchus;
            }
            else
            {
                ZRFrogsGame.color = NotAvailable;
            }
            //Skulls
            if (Has(i.Scales) || i.Bomb.State == 1)
            {
                tokensAvailable += 1;
            }
            if (Has(i.Hookshot))
            {
                tokensAvailable += 2;
            }
        }
    }
}
