using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Models;
using System.Collections.Generic;
using PromotionEngine.Services;
using System.Linq;

namespace PromotionEngine.UnitTest
{
  [TestClass]
  public class PromoEngineServiceTest
  {
    IPromoEngineService promoEngineService;
    public List<Item> Items = new List<Item>();
    [TestInitialize]
    public void TestIntialize()
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
      this.promoEngineService = new PromoEngineService(Items);
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioA()
    {
      decimal expected = 100;
      List<CartItem> cartItems = new List<CartItem>();
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
      decimal actual = this.promoEngineService.GetFinalBillWithPromoApplied(cartItems, this.promoEngineService.GetPromotions());
      Assert.AreEqual(expected, actual, "TestGetFinalBillWithPromoApplied_ScenarioA failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioB()
    {
      decimal expected = 370;
      decimal actual = this.promoEngineService.GetFinalBillWithPromoApplied(this.promoEngineService.GetItemsInCart(),this.promoEngineService.GetPromotions());
      Assert.AreEqual(expected, actual, "TestGetFinalBillWithPromoApplied_ScenarioB failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioC()
    {
      decimal expected = 280;
      List<CartItem> cartItems = new List<CartItem>();
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
      decimal actual = this.promoEngineService.GetFinalBillWithPromoApplied(cartItems, this.promoEngineService.GetPromotions());
      Assert.AreEqual(expected, actual, "TestGetFinalBillWithPromoApplied_ScenarioC failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetItems()
    {
      List<Item> actual = this.promoEngineService.GetItems();
      Assert.AreEqual(Items.Count, actual.Count, "TestGetItems failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestInsertItemInCart()
    {
      bool actual = this.promoEngineService.InsertItemInCart("", 2);
      Assert.AreEqual(true, actual, "TestInsertItemInCart failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetItemsInCart()
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
      List<CartItem> actual = this.promoEngineService.GetItemsInCart();
      Assert.AreEqual(cartItems.Count, actual.Count, "TestInsertItemInCart failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetPromotions()
    {
      List<Promotion> promotions = new List<Promotion>();

      Promotion promo1 = new Promotion
      {
        PromotionId = 1,
        IsActive = true,
        ItemsInPromo = new List<Item> { Items.Where(i => i.SKUId == "A").FirstOrDefault() },
        QuantityForPromo = 3,
        PromoPrice = 130
      };
      promotions.Add(promo1);
      Promotion promo2 = new Promotion
      {
        PromotionId = 2,
        IsActive = true,
        ItemsInPromo = new List<Item> { Items.Where(i => i.SKUId == "B").FirstOrDefault() },
        QuantityForPromo = 2,
        PromoPrice = 45
      };
      promotions.Add(promo2);
      Promotion promo3 = new Promotion
      {
        PromotionId = 1,
        IsActive = true,
        ItemsInPromo = new List<Item> { Items.Where(i => i.SKUId == "C").FirstOrDefault(), Items.Where(i => i.SKUId == "D").FirstOrDefault() },
        QuantityForPromo = 1,
        PromoPrice = 30
      };
      promotions.Add(promo3);
      List<Promotion> actual = this.promoEngineService.GetPromotions();
      Assert.AreEqual(promotions.Count, actual.Count, "TestGetPromotions failed");
    }
  }
}
