using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_GanonsCastle(ItemPanel i)
        {
            if (rainbowbridge)
            {
                GanonsCastleForestTrialChest.ForeColor = Available;
                GanonsCastleWaterTrialLeftChest.ForeColor = Available;
                GanonsCastleWaterTrialRightChest.ForeColor = Available;
                GanonsTowerBossKeyChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleForestTrialChest.ForeColor = NotAvailable;
                GanonsCastleWaterTrialLeftChest.ForeColor = NotAvailable;
                GanonsCastleWaterTrialRightChest.ForeColor = NotAvailable;
                GanonsTowerBossKeyChest.ForeColor = NotAvailable;
            }
            //Shadow Trial 1
            if (rainbowbridge && ((Has(i.Magic) && Has(i.Bow) && Has(i.FireArrow)) || Has(i.Hookshot) || Has(i.HoverBoots) || Has(i.SongOfTime)))
            {
                GanonsCastleShadowTrialFrontChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleShadowTrialFrontChest.ForeColor = NotAvailable;
            }
            //Shadow Trial 2
            if (rainbowbridge && ((has_longshot && (Has(i.HoverBoots) || has_firesource)) || (Has(i.Magic) && Has(i.Bow) && Has(i.FireArrow))))
            {
                GanonsCastleShadowTrialGoldenGauntletsChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleShadowTrialGoldenGauntletsChest.ForeColor = NotAvailable;
            }
            //Light Trial
            if (rainbowbridge && i.Strength.State == 3)
            {
                GanonsCastleLightTrialFirstLeftChest.ForeColor = Available;
                GanonsCastleLightTrialSecondLeftChest.ForeColor = Available;
                GanonsCastleLightTrialThirdLeftChest.ForeColor = Available;
                GanonsCastleLightTrialFirstRightChest.ForeColor = Available;
                GanonsCastleLightTrialSecondRightChest.ForeColor = Available;
                GanonsCastleLightTrialThirdRightChest.ForeColor = Available;
                GanonsCastleLightTrialInvisibleEnemiesChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleLightTrialFirstLeftChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialSecondLeftChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialThirdLeftChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialFirstRightChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialSecondRightChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialThirdRightChest.ForeColor = NotAvailable;
                GanonsCastleLightTrialInvisibleEnemiesChest.ForeColor = NotAvailable;
            }
            //Light Trial Last Chest
            if (rainbowbridge && i.Strength.State == 3 && Has(i.ZeldasLullaby))
            {
                GanonsCastleLightTrialLullabyChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleLightTrialLullabyChest.ForeColor = NotAvailable;
            }
            //Spirit Trial 1
            if (rainbowbridge && Has(i.Hookshot))
            {
                GanonsCastleSpiritTrialCrystalSwitchChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleSpiritTrialCrystalSwitchChest.ForeColor = NotAvailable;
            }
            //Spirit Trial 2
            if (rainbowbridge && Has(i.Hookshot) && Has(i.Bomb))
            {
                GanonsCastleSpiritTrialInvisibleChest.ForeColor = Available;
            }
            else
            {
                GanonsCastleSpiritTrialInvisibleChest.ForeColor = NotAvailable;
            }
        }
    }
}
