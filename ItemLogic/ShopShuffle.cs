using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeddyMapTracker
{
    partial class Maptracker
    {
        public void ItemLogic_ShopShuffle(ItemPanel i)
        {           
            if (ShopShuffle)
            {
                //Market Potion Shop
                ///TopLeft
                if (MarketPotionShop.TopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketPotionShop.TopLeft.ForeColor = Available;
                }
                else if (MarketPotionShop.TopLeft.Price.Value >= 201)
                {
                    MarketPotionShop.TopLeft.ForeColor = CanSee;
                }
                else if (MarketPotionShop.TopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketPotionShop.TopLeft.ForeColor = Available;
                }
                else if (MarketPotionShop.TopLeft.Price.Value >= 100)
                {
                    MarketPotionShop.TopLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketPotionShop.TopLeft.ForeColor = Available;
                }
                ///TopRight
                if (MarketPotionShop.TopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketPotionShop.TopRight.ForeColor = Available;
                }
                else if (MarketPotionShop.TopRight.Price.Value >= 201)
                {
                    MarketPotionShop.TopRight.ForeColor = CanSee;
                }
                else if (MarketPotionShop.TopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketPotionShop.TopRight.ForeColor = Available;
                }
                else if (MarketPotionShop.TopRight.Price.Value >= 100)
                {
                    MarketPotionShop.TopRight.ForeColor = CanSee;
                }
                else
                {
                    MarketPotionShop.TopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (MarketPotionShop.BottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketPotionShop.BottomLeft.ForeColor = Available;
                }
                else if (MarketPotionShop.BottomLeft.Price.Value >= 201)
                {
                    MarketPotionShop.BottomLeft.ForeColor = CanSee;
                }
                else if (MarketPotionShop.BottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketPotionShop.BottomLeft.ForeColor = Available;
                }
                else if (MarketPotionShop.BottomLeft.Price.Value >= 100)
                {
                    MarketPotionShop.BottomLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketPotionShop.BottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (MarketPotionShop.BottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketPotionShop.BottomRight.ForeColor = Available;
                }
                else if (MarketPotionShop.BottomRight.Price.Value >= 201)
                {
                    MarketPotionShop.BottomRight.ForeColor = CanSee;
                }
                else if (MarketPotionShop.BottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketPotionShop.BottomRight.ForeColor = Available;
                }
                else if (MarketPotionShop.BottomRight.Price.Value >= 100)
                {
                    MarketPotionShop.BottomRight.ForeColor = CanSee;
                }
                else
                {
                    MarketPotionShop.BottomRight.ForeColor = Available;
                }
                //Market Bazaar Shop
                ///TopLeft
                if (MarketBazaar.TopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBazaar.TopLeft.ForeColor = Available;
                }
                else if (MarketBazaar.TopLeft.Price.Value >= 201)
                {
                    MarketBazaar.TopLeft.ForeColor = CanSee;
                }
                else if (MarketBazaar.TopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBazaar.TopLeft.ForeColor = Available;
                }
                else if (MarketBazaar.TopLeft.Price.Value >= 100)
                {
                    MarketBazaar.TopLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketBazaar.TopLeft.ForeColor = Available;
                }
                ///TopRight
                if (MarketBazaar.TopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBazaar.TopRight.ForeColor = Available;
                }
                else if (MarketBazaar.TopRight.Price.Value >= 201)
                {
                    MarketBazaar.TopRight.ForeColor = CanSee;
                }
                else if (MarketBazaar.TopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBazaar.TopRight.ForeColor = Available;
                }
                else if (MarketBazaar.TopRight.Price.Value >= 100)
                {
                    MarketBazaar.TopRight.ForeColor = CanSee;
                }
                else
                {
                    MarketBazaar.TopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (MarketBazaar.BottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBazaar.BottomLeft.ForeColor = Available;
                }
                else if (MarketBazaar.BottomLeft.Price.Value >= 201)
                {
                    MarketBazaar.BottomLeft.ForeColor = CanSee;
                }
                else if (MarketBazaar.BottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBazaar.BottomLeft.ForeColor = Available;
                }
                else if (MarketBazaar.BottomLeft.Price.Value >= 100)
                {
                    MarketBazaar.BottomLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketBazaar.BottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (MarketBazaar.BottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBazaar.BottomRight.ForeColor = Available;
                }
                else if (MarketBazaar.BottomRight.Price.Value >= 201)
                {
                    MarketBazaar.BottomRight.ForeColor = CanSee;
                }
                else if (MarketBazaar.BottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBazaar.BottomRight.ForeColor = Available;
                }
                else if (MarketBazaar.BottomRight.Price.Value >= 100)
                {
                    MarketBazaar.BottomRight.ForeColor = CanSee;
                }
                else
                {
                    MarketBazaar.BottomRight.ForeColor = Available;
                }
                //Market Bombchu Shop
                ///TopLeft
                if (MarketBombchuShop.TopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBombchuShop.TopLeft.ForeColor = Available;
                }
                else if (MarketBombchuShop.TopLeft.Price.Value >= 201)
                {
                    MarketBombchuShop.TopLeft.ForeColor = CanSee;
                }
                else if (MarketBombchuShop.TopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBombchuShop.TopLeft.ForeColor = Available;
                }
                else if (MarketBombchuShop.TopLeft.Price.Value >= 100)
                {
                    MarketBombchuShop.TopLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketBombchuShop.TopLeft.ForeColor = Available;
                }
                ///TopRight
                if (MarketBombchuShop.TopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBombchuShop.TopRight.ForeColor = Available;
                }
                else if (MarketBombchuShop.TopRight.Price.Value >= 201)
                {
                    MarketBombchuShop.TopRight.ForeColor = CanSee;
                }
                else if (MarketBombchuShop.TopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBombchuShop.TopRight.ForeColor = Available;
                }
                else if (MarketBombchuShop.TopRight.Price.Value >= 100)
                {
                    MarketBombchuShop.TopRight.ForeColor = CanSee;
                }
                else
                {
                    MarketBombchuShop.TopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (MarketBombchuShop.BottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBombchuShop.BottomLeft.ForeColor = Available;
                }
                else if (MarketBombchuShop.BottomLeft.Price.Value >= 201)
                {
                    MarketBombchuShop.BottomLeft.ForeColor = CanSee;
                }
                else if (MarketBombchuShop.BottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBombchuShop.BottomLeft.ForeColor = Available;
                }
                else if (MarketBombchuShop.BottomLeft.Price.Value >= 100)
                {
                    MarketBombchuShop.BottomLeft.ForeColor = CanSee;
                }
                else
                {
                    MarketBombchuShop.BottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (MarketBombchuShop.BottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    MarketBombchuShop.BottomRight.ForeColor = Available;
                }
                else if (MarketBombchuShop.BottomRight.Price.Value >= 201)
                {
                    MarketBombchuShop.BottomRight.ForeColor = CanSee;
                }
                else if (MarketBombchuShop.BottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    MarketBombchuShop.BottomRight.ForeColor = Available;
                }
                else if (MarketBombchuShop.BottomRight.Price.Value >= 100)
                {
                    MarketBombchuShop.BottomRight.ForeColor = CanSee;
                }
                else
                {
                    MarketBombchuShop.BottomRight.ForeColor = Available;
                }
                //Kakariko Bazaar
                ///TopLeft
                if (KakBazaarTopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakBazaarTopLeft.ForeColor = Available;
                }
                else if (KakBazaarTopLeft.Price.Value >= 201)
                {
                    KakBazaarTopLeft.ForeColor = CanSee;
                }
                else if (KakBazaarTopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakBazaarTopLeft.ForeColor = Available;
                }
                else if (KakBazaarTopLeft.Price.Value >= 100)
                {
                    KakBazaarTopLeft.ForeColor = CanSee;
                }
                else
                {
                    KakBazaarTopLeft.ForeColor = Available;
                }
                ///TopRight
                if (KakBazaarTopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakBazaarTopRight.ForeColor = Available;
                }
                else if (KakBazaarTopRight.Price.Value >= 201)
                {
                    KakBazaarTopRight.ForeColor = CanSee;
                }
                else if (KakBazaarTopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakBazaarTopRight.ForeColor = Available;
                }
                else if (KakBazaarTopRight.Price.Value >= 100)
                {
                    KakBazaarTopRight.ForeColor = CanSee;
                }
                else
                {
                    KakBazaarTopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (KakBazaarBottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakBazaarBottomLeft.ForeColor = Available;
                }
                else if (KakBazaarBottomLeft.Price.Value >= 201)
                {
                    KakBazaarBottomLeft.ForeColor = CanSee;
                }
                else if (KakBazaarBottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakBazaarBottomLeft.ForeColor = Available;
                }
                else if (KakBazaarBottomLeft.Price.Value >= 100)
                {
                    KakBazaarBottomLeft.ForeColor = CanSee;
                }
                else
                {
                    KakBazaarBottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (KakBazaarBottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakBazaarBottomRight.ForeColor = Available;
                }
                else if (KakBazaarBottomRight.Price.Value >= 201)
                {
                    KakBazaarBottomRight.ForeColor = CanSee;
                }
                else if (KakBazaarBottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakBazaarBottomRight.ForeColor = Available;
                }
                else if (KakBazaarBottomRight.Price.Value >= 100)
                {
                    KakBazaarBottomRight.ForeColor = CanSee;
                }
                else
                {
                    KakBazaarBottomRight.ForeColor = Available;
                }
                //Kakariko Bazaar
                ///TopLeft
                if (KakPotionShopTopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakPotionShopTopLeft.ForeColor = Available;
                }
                else if (KakPotionShopTopLeft.Price.Value >= 201)
                {
                    KakPotionShopTopLeft.ForeColor = CanSee;
                }
                else if (KakPotionShopTopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakPotionShopTopLeft.ForeColor = Available;
                }
                else if (KakPotionShopTopLeft.Price.Value >= 100)
                {
                    KakPotionShopTopLeft.ForeColor = CanSee;
                }
                else
                {
                    KakPotionShopTopLeft.ForeColor = Available;
                }
                ///TopRight
                if (KakPotionShopTopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakPotionShopTopRight.ForeColor = Available;
                }
                else if (KakPotionShopTopRight.Price.Value >= 201)
                {
                    KakPotionShopTopRight.ForeColor = CanSee;
                }
                else if (KakPotionShopTopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakPotionShopTopRight.ForeColor = Available;
                }
                else if (KakPotionShopTopRight.Price.Value >= 100)
                {
                    KakPotionShopTopRight.ForeColor = CanSee;
                }
                else
                {
                    KakPotionShopTopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (KakPotionShopBottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakPotionShopBottomLeft.ForeColor = Available;
                }
                else if (KakPotionShopBottomLeft.Price.Value >= 201)
                {
                    KakPotionShopBottomLeft.ForeColor = CanSee;
                }
                else if (KakPotionShopBottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakPotionShopBottomLeft.ForeColor = Available;
                }
                else if (KakPotionShopBottomLeft.Price.Value >= 100)
                {
                    KakPotionShopBottomLeft.ForeColor = CanSee;
                }
                else
                {
                    KakPotionShopBottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (KakPotionShopBottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KakPotionShopBottomRight.ForeColor = Available;
                }
                else if (KakPotionShopBottomRight.Price.Value >= 201)
                {
                    KakPotionShopBottomRight.ForeColor = CanSee;
                }
                else if (KakPotionShopBottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KakPotionShopBottomRight.ForeColor = Available;
                }
                else if (KakPotionShopBottomRight.Price.Value >= 100)
                {
                    KakPotionShopBottomRight.ForeColor = CanSee;
                }
                else
                {
                    KakPotionShopBottomRight.ForeColor = Available;
                }
                //Kokiri Forest Shop
                ///TopLeft
                if (KFShop.TopLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KFShop.TopLeft.ForeColor = Available;
                }
                else if (KFShop.TopLeft.Price.Value >= 201)
                {
                    KFShop.TopLeft.ForeColor = CanSee;
                }
                else if (KFShop.TopLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KFShop.TopLeft.ForeColor = Available;
                }
                else if (KFShop.TopLeft.Price.Value >= 100)
                {
                    KFShop.TopLeft.ForeColor = CanSee;
                }
                else
                {
                    KFShop.TopLeft.ForeColor = Available;
                }
                ///TopRight
                if (KFShop.TopRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KFShop.TopRight.ForeColor = Available;
                }
                else if (KFShop.TopRight.Price.Value >= 201)
                {
                    KFShop.TopRight.ForeColor = CanSee;
                }
                else if (KFShop.TopRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KFShop.TopRight.ForeColor = Available;
                }
                else if (KFShop.TopRight.Price.Value >= 100)
                {
                    KFShop.TopRight.ForeColor = CanSee;
                }
                else
                {
                    KFShop.TopRight.ForeColor = Available;
                }
                ///BottomLeft
                if (KFShop.BottomLeft.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KFShop.BottomLeft.ForeColor = Available;
                }
                else if (KFShop.BottomLeft.Price.Value >= 201)
                {
                    KFShop.BottomLeft.ForeColor = CanSee;
                }
                else if (KFShop.BottomLeft.Price.Value >= 100 && Has(i.Wallet))
                {
                    KFShop.BottomLeft.ForeColor = Available;
                }
                else if (KFShop.BottomLeft.Price.Value >= 100)
                {
                    KFShop.BottomLeft.ForeColor = CanSee;
                }
                else
                {
                    KFShop.BottomLeft.ForeColor = Available;
                }
                ///BottomRight
                if (KFShop.BottomRight.Price.Value >= 201 && i.Wallet.State == 2)
                {
                    KFShop.BottomRight.ForeColor = Available;
                }
                else if (KFShop.BottomRight.Price.Value >= 201)
                {
                    KFShop.BottomRight.ForeColor = CanSee;
                }
                else if (KFShop.BottomRight.Price.Value >= 100 && Has(i.Wallet))
                {
                    KFShop.BottomRight.ForeColor = Available;
                }
                else if (KFShop.BottomRight.Price.Value >= 100)
                {
                    KFShop.BottomRight.ForeColor = CanSee;
                }
                else
                {
                    KFShop.BottomRight.ForeColor = Available;
                }
                //Goron City Shop
                ///TopLeft
                
                if (GoronShopTopLeft.Price.Value >= 201 && i.Wallet.State == 2 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopLeft.ForeColor = Available;
                }
                else if (GoronShopTopLeft.Price.Value >= 201 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopLeft.ForeColor = CanSee;
                }
                else if (GoronShopTopLeft.Price.Value >= 100 && Has(i.Wallet) && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopLeft.ForeColor = Available;
                }
                else if (GoronShopTopLeft.Price.Value >= 100 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopLeft.ForeColor = CanSee;
                }
                else if (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins)))
                {
                    GoronShopTopLeft.ForeColor = Available;
                }
                else
                {
                    GoronShopTopLeft.ForeColor = NotAvailable;
                }
                
                ///TopRight
                if (GoronShopTopRight.Price.Value >= 201 && i.Wallet.State == 2 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopRight.ForeColor = Available;
                }
                else if (GoronShopTopRight.Price.Value >= 201 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopRight.ForeColor = CanSee;
                }
                else if (GoronShopTopRight.Price.Value >= 100 && Has(i.Wallet) && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopRight.ForeColor = Available;
                }
                else if (GoronShopTopRight.Price.Value >= 100 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopTopRight.ForeColor = CanSee;
                }
                else if (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins)))
                {
                    GoronShopTopRight.ForeColor = Available;
                }
                else
                {
                    GoronShopTopRight.ForeColor = NotAvailable;
                }
                ///BottomLeft
                if (GoronShopBottomLeft.Price.Value >= 201 && i.Wallet.State == 2 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomLeft.ForeColor = Available;
                }
                else if (GoronShopBottomLeft.Price.Value >= 201 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomLeft.ForeColor = CanSee;
                }
                else if (GoronShopBottomLeft.Price.Value >= 100 && Has(i.Wallet) && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomLeft.ForeColor = Available;
                }
                else if (GoronShopBottomLeft.Price.Value >= 100 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomLeft.ForeColor = CanSee;
                }
                else if (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins)))
                {
                    GoronShopBottomLeft.ForeColor = Available;
                }
                else
                {
                    GoronShopBottomLeft.ForeColor = NotAvailable;
                }
                ///BottomRight
                if (GoronShopBottomRight.Price.Value >= 201 && i.Wallet.State == 2 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomRight.ForeColor = Available;
                }
                else if (GoronShopBottomRight.Price.Value >= 201 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomRight.ForeColor = CanSee;
                }
                else if (GoronShopBottomRight.Price.Value >= 100 && Has(i.Wallet) && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomRight.ForeColor = Available;
                }
                else if (GoronShopBottomRight.Price.Value >= 100 && (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins))))
                {
                    GoronShopBottomRight.ForeColor = CanSee;
                }
                else if (Has(i.Strength) || Has(i.Bomb) || Has(i.Bow) || Has(i.ZeldasLullaby) || (Has(i.Magic) && Has(i.Dins)))
                {
                    GoronShopBottomRight.ForeColor = Available;
                }
                else
                {
                    GoronShopBottomRight.ForeColor = NotAvailable;
                }
                //Zora's Domain Shop
                ///TopLeft
                if (ZDShop.TopLeft.Price.Value >= 201 && i.Wallet.State == 2 && ((Has(i.Scales) || (Has(i.ZeldasLullaby) && Has(i.Bomb))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle && Has(i.ZeldasLullaby))))
                {
                    ZDShop.TopLeft.ForeColor = Available;
                }
                else if (ZDShop.TopLeft.Price.Value >= 201 && ((Has(i.Scales) || (Has(i.ZeldasLullaby) && Has(i.Bomb))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle && Has(i.ZeldasLullaby))))
                {
                    ZDShop.TopLeft.ForeColor = CanSee;
                }
                else if (ZDShop.TopLeft.Price.Value >= 100 && Has(i.Wallet) && ((Has(i.Scales) || (Has(i.ZeldasLullaby) && Has(i.Bomb))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle && Has(i.ZeldasLullaby))))
                {
                    ZDShop.TopLeft.ForeColor = Available;
                }
                else if (ZDShop.TopLeft.Price.Value >= 100 && ((Has(i.Scales) || (Has(i.ZeldasLullaby) && Has(i.Bomb))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle && Has(i.ZeldasLullaby))))
                {
                    ZDShop.TopLeft.ForeColor = CanSee;
                }
                else if ((Has(i.Scales) || (Has(i.ZeldasLullaby) && Has(i.Bomb))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle && Has(i.ZeldasLullaby)))
                {
                    ZDShop.TopLeft.ForeColor = Available;
                }
                else
                {
                    ZDShop.TopLeft.ForeColor = NotAvailable;
                }
                ///TopRight
                if (ZDShop.TopRight.Price.Value >= 201 && i.Wallet.State == 2 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle)))))
                {
                    ZDShop.TopRight.ForeColor = Available;
                }
                else if (ZDShop.TopRight.Price.Value >= 201 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.TopRight.ForeColor = CanSee;
                }
                else if (ZDShop.TopRight.Price.Value >= 100 && Has(i.Wallet) && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.TopRight.ForeColor = Available;
                }
                else if (ZDShop.TopRight.Price.Value >= 100 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.TopRight.ForeColor = CanSee;
                }
                else if ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby))))
                {
                    ZDShop.TopRight.ForeColor = Available;
                }
                else
                {
                    ZDShop.TopRight.ForeColor = NotAvailable;
                }
                ///BottomLeft
                if (ZDShop.BottomLeft.Price.Value >= 201 && i.Wallet.State == 2 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle)))))
                {
                    ZDShop.BottomLeft.ForeColor = Available;
                }
                else if (ZDShop.BottomLeft.Price.Value >= 201 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomLeft.ForeColor = CanSee;
                }
                else if (ZDShop.BottomLeft.Price.Value >= 100 && Has(i.Wallet) && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomLeft.ForeColor = Available;
                }
                else if (ZDShop.BottomLeft.Price.Value >= 100 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomLeft.ForeColor = CanSee;
                }
                else if ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby))))
                {
                    ZDShop.BottomLeft.ForeColor = Available;
                }
                else
                {
                    ZDShop.BottomLeft.ForeColor = NotAvailable;
                }
                ///BottomRight
                if (ZDShop.BottomRight.Price.Value >= 201 && i.Wallet.State == 2 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle)))))
                {
                    ZDShop.BottomRight.ForeColor = Available;
                }
                else if (ZDShop.BottomRight.Price.Value >= 201 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomRight.ForeColor = CanSee;
                }
                else if (ZDShop.BottomRight.Price.Value >= 100 && Has(i.Wallet) && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomRight.ForeColor = Available;
                }
                else if (ZDShop.BottomRight.Price.Value >= 100 && ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby)))))
                {
                    ZDShop.BottomRight.ForeColor = CanSee;
                }
                else if ((Has(i.ZeldasLullaby) && ((Has(i.RutoLetter) && (Has(i.Bomb) || Has(i.Scales))) || ((i.Wallet.State == 2 || rainbowbridge) && has_bottle))) || (Has(i.Scales) || (Has(i.Bomb) && Has(i.ZeldasLullaby))))
                {
                    ZDShop.BottomRight.ForeColor = Available;
                }
                else
                {
                    ZDShop.BottomRight.ForeColor = NotAvailable;
                }              
            }                     
        }
    }
}
