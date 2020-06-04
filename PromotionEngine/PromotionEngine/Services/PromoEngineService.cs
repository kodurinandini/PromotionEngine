using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Services
{
  public class PromoEngineService:IPromoEngineService
  {
    public static List<Item> Items = new List<Item>();
    public PromoEngineService()
    {
      Item i1 = new Item
      {
        ItemName = "Apple",
        SKUId = "A",
        UnitPrice = 50,
      };
      Items.Add(i1);
      Item i2 = new Item
      {
        ItemName = "Apple",
        SKUId = "B",
        UnitPrice = 30,
      };
      Items.Add(i2);
      Item i3 = new Item
      {
        ItemName = "Apple",
        SKUId = "C",
        UnitPrice = 20,
      };
      Items.Add(i3);
      Item i4 = new Item
      {
        ItemName = "Apple",
        SKUId = "D",
        UnitPrice = 15,
      };
      Items.Add(i4);
    }
    public PromoEngineService(List<Item> items)
    {
        Items = items;
    }
    /// <summary>
    /// Get Items available 
    /// </summary>
    /// <returns></returns>
    public List<Item> GetItems()
    {
      return Items;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<CartItem> GetItemsInCart()
    {
      List<CartItem> cartItems = new List<CartItem>();
      CartItem c1 = new CartItem
      {
        item = Items.Where(i => i.SKUId == "A").FirstOrDefault(),
        quantity = 5
      };
      cartItems.Add(c1);
      CartItem c2 = new CartItem
      {
        item = Items.Where(i => i.SKUId == "B").FirstOrDefault(),
        quantity = 5
      };
      cartItems.Add(c2);
      CartItem c3 = new CartItem
      {
        item = Items.Where(i => i.SKUId == "C").FirstOrDefault(),
        quantity = 1
      };
      cartItems.Add(c3);
      return cartItems.ToList();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool InsertItemInCart(string ItemName,int quantity)
    {
      return true;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<Promotion> GetPromotions()
    {
     List<Promotion> promotions = new List<Promotion>();

      Promotion promo1 = new Promotion {
        PromotionId=1,
        IsActive=true,
        ItemsInPromo=new List<Item> {Items.Where(i=>i.SKUId=="A").FirstOrDefault() },
        QuantityForPromo = 3,
        PromoPrice=130
      };
      promotions.Add(promo1);
      Promotion promo2 = new Promotion
      {
        PromotionId = 2,
        IsActive = true,
        ItemsInPromo = new List<Item> { Items.Where(i => i.SKUId == "B").FirstOrDefault() },
        QuantityForPromo = 2,
        PromoPrice=45
      };
      promotions.Add(promo2);
      Promotion promo3 = new Promotion
      {
        PromotionId = 1,
        IsActive = true,
        ItemsInPromo = new List<Item> { Items.Where(i => i.SKUId == "C").FirstOrDefault(), Items.Where(i => i.SKUId == "D").FirstOrDefault() },
        QuantityForPromo = 1,
        PromoPrice=30
      };
      promotions.Add(promo3);
      return promotions.ToList();
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public decimal GetFinalBillWithPromoApplied(List<CartItem> cartItems, List<Promotion> promotions)
    {
      decimal Total=0;
      foreach (Promotion promo in promotions)
      {
        //When the promotion is on a single item in our case for SKU A's and B's
        if (promo.ItemsInPromo.Count == 1)
        {
          var itemsCount = cartItems.Where(c => promo.ItemsInPromo.Any(i => i.SKUId == c.item.SKUId)).Sum(i=>i.quantity);
          Total = Total + ((itemsCount % promo.QuantityForPromo) * promo.ItemsInPromo.FirstOrDefault().UnitPrice) + (itemsCount / promo.QuantityForPromo) * promo.PromoPrice;
        }
        //When the promotion is based on a combination of items taken c&D case
        else if(promo.ItemsInPromo.Count > 1)
        {
          var promoApplicableItems= cartItems.Where(c => promo.ItemsInPromo.Any(i => i.SKUId == c.item.SKUId)).ToList();
          var itemsCount = promoApplicableItems.Sum(i=>i.quantity);
          if (itemsCount == 1)
            Total = Total + (itemsCount / promo.ItemsInPromo.Count) * promo.PromoPrice + promo.ItemsInPromo.FirstOrDefault().UnitPrice;
          else
            Total = Total + (itemsCount / promo.ItemsInPromo.Count) * promo.PromoPrice;
        }
      }
      //Total for items which are not with any promos
      var itemsNotOnPromo = cartItems.Where(c => !promotions.Exists(p => p.ItemsInPromo.Any(i => i.SKUId == c.item.SKUId)));
      Total = Total + (itemsNotOnPromo.Sum(i => i.quantity)) * (itemsNotOnPromo.Sum(i => i.item.UnitPrice));
      return Total;
    }
  }
}
