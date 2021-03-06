using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread breadOrder = new Bread(0);
      Assert.AreEqual(typeof(Bread), breadOrder.GetType());
    }

    [TestMethod]
    public void GetIndividualPrice_ReturnsBreadIndividualPrice_Int()
    {
      int result = Bread.GetIndividualPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetSpecialPrice_ReturnsBreadSpecialPrice_Int()
    {
      int result = Bread.GetSpecialPrice();
      Assert.AreEqual(10, result);
    }


    [TestMethod]
    public void GetQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 2;
      Bread breadOrder = new Bread(breadQuantity);
      int result = breadOrder.Quantity;
      Assert.AreEqual(breadQuantity, result);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnsBreadOrderTotalPrice_Int()
    {
      int breadQuantity = 2;
      Bread breadOrder = new Bread(breadQuantity);
      int result = breadOrder.GetTotalPrice();
      Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnsBreadOrderTotalSpecialPrice_Int()
    {
      int breadQuantity = 6;
      Bread breadOrder = new Bread(breadQuantity);
      int result = breadOrder.GetTotalPrice();
      Assert.AreEqual(20, result);
    }
  }
}