using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PromotionEngine.Models;
using PromotionEngine.Services;

namespace PromotionEngine.Controllers
{
  public class HomeController : Controller
  {
    private IPromoEngineService promoEngineService = new PromoEngineService();
    public IActionResult Index()
    {
      List<Promotion> promotions = promoEngineService.GetPromotions();

      ViewData["ScenarioA"] = promoEngineService.GetFinalBillWithPromoApplied(PrepareCart("A"), promotions);
      ViewData["ScenarioB"] = promoEngineService.GetFinalBillWithPromoApplied(PrepareCart("B"), promotions);
      ViewData["ScenarioC"] = promoEngineService.GetFinalBillWithPromoApplied(PrepareCart("C"), promotions);
      return View();
    }

    public IActionResult About()
    {
      ViewData["Message"] = "Your application description page.";

      return View();
    }

    public IActionResult Contact()
    {
      ViewData["Message"] = "Your contact page.";

      return View();
    }

    //public IActionResult Privacy()
    //{
    //  return View();
    //}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    #region Helpers
    /// <summary>
    /// Static Data for cart
    /// </summary>
    /// <param name="Scenario"></param>
    /// <returns></returns>
    private List<CartItem> PrepareCart(string Scenario)
    {
      List<CartItem> cartItems = new List<CartItem>();
      List<Item> Items = promoEngineService.GetItems();
      if (Scenario=="A")
      {
        CartItem c1 = new CartItem
        {
          item = Items.Where(i => i.SKUId == "A").FirstOrDefault(),
          quantity = 1
        };
        cartItems.Add(c1);
        CartItem c2 = new CartItem
        {
          item = Items.Where(i => i.SKUId == "B").FirstOrDefault(),
          quantity = 1
        };
        cartItems.Add(c2);
        CartItem c3 = new CartItem
        {
          item = Items.Where(i => i.SKUId == "C").FirstOrDefault(),
          quantity = 1
        };
        cartItems.Add(c3);
      }
      else if(Scenario=="B")
      {
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
      }
      else
      {
        CartItem c1 = new CartItem
        {
          item = Items.Where(i => i.SKUId == "A").FirstOrDefault(),
          quantity = 3
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
        CartItem c4 = new CartItem
        {
          item = Items.Where(i => i.SKUId == "D").FirstOrDefault(),
          quantity = 1
        };
        cartItems.Add(c4);
      }
      return cartItems;
    }
    #endregion
  }
}
