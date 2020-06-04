using PromotionEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Services
{
  public interface IPromoEngineService
  {
    List<Item> GetItems();
    List<CartItem> GetItemsInCart();
    bool InsertItemInCart(string ItemName, int quantity);
    List<Promotion> GetPromotions();
    List<CartItem> GetFinalBillWithPromoApplied();
  }
}
