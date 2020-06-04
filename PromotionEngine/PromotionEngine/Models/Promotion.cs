using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
  public class Promotion
  {
    public int PromotionId { get; set; }
    public bool IsActive { get; set; }
    public List<Item> ItemsInPromo { get; set; }
    public int QuantityForPromo { get; set; }
    public decimal PromoPrice { get; set; }

  }
}
