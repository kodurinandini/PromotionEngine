using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
  public class Item
  {
    public string SKUId { get; set; } 
    public string ItemName { get; set; }
    public decimal UnitPrice { get; set; }
  }
}
