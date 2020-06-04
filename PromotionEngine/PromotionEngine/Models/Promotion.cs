using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromotionEngine.Models
{
  public class Promotion
  {
    public string PromotionId { get; set; }
    public bool IsActive { get; set; }
    public List<Item> ItemsInPromo { get; set; }
    public char Operator { get; set; }
    public decimal PromoPrice { get; set; }
  }
}
