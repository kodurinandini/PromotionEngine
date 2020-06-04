using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine
{
  public class PromoEngineService
  {
    /// <summary>
    /// Get Items available 
    /// </summary>
    /// <returns></returns>
    public List<Item> GetItems()
    {
      List<Item> items = new List<Item>();
      return items;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<CartItem> GetItemsInCart()
    {
      List<CartItem> items = new List<CartItem>();
      return items;
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
      return promotions;
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public List<CartItem> GetFinalBillWithPromoApplied()
    {
      List<CartItem> items = new List<CartItem>();
      return items;
    }
  }
}
