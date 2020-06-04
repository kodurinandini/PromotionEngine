using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine.Models;
using System.Collections.Generic;
using PromotionEngine.Services;

namespace PromotionEngine.UnitTest
{
  [TestClass]
  public class PromoEngineServiceTest
  {
    IPromoEngineService promoEngineService = new PromoEngineService();
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetItems()
    {
      List<Item> expected = new List<Item>();
      List<Item> actual=promoEngineService.GetItems();
      Assert.AreEqual(expected.Count, actual.Count, "TestGetItems failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestInsertItemInCart()
    {
      bool actual = promoEngineService.InsertItemInCart("",2);
      Assert.AreEqual(true, actual, "TestInsertItemInCart failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetItemsInCart()
    {
      List<CartItem> expected = new List<CartItem>();
      List<CartItem> actual = promoEngineService.GetItemsInCart();
      Assert.AreEqual(expected.Count, actual.Count, "TestInsertItemInCart failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetPromotions()
    {
      List<Promotion> expected = new List<Promotion>();
      List<Promotion> actual = promoEngineService.GetPromotions();
      Assert.AreEqual(expected.Count, actual.Count, "TestGetPromotions failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioA()
    {
      List<CartItem> expected = new List<CartItem>();
      List<CartItem> actual = promoEngineService.GetFinalBillWithPromoApplied();
      Assert.AreEqual(expected.Count, actual.Count, "TestGetFinalBillWithPromoApplied_ScenarioA failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioB()
    {
      List<CartItem> expected = new List<CartItem>();
      List<CartItem> actual = promoEngineService.GetFinalBillWithPromoApplied();
      Assert.AreEqual(expected.Count, actual.Count, "TestGetFinalBillWithPromoApplied_ScenarioB failed");
    }
    /// <summary>
    /// 
    /// </summary>
    [TestMethod]
    public void TestGetFinalBillWithPromoApplied_ScenarioC()
    {
      List<CartItem> expected = new List<CartItem>();
      List<CartItem> actual = promoEngineService.GetFinalBillWithPromoApplied();
      Assert.AreEqual(expected.Count, actual.Count, "TestGetFinalBillWithPromoApplied_ScenarioC failed");
    }
  }
}
