using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
  public class CartItem
  {
    public Item item { get; set; }
    public int quantity { get; set; }
    public decimal unitPrice { get; set; }
    public decimal totalPrice { get; set; }
  }
}
