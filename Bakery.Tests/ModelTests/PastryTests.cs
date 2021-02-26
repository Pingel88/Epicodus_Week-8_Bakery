using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry pastryOrder = new Pastry(0);
      Assert.AreEqual(typeof(Pastry), pastryOrder.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPastryIndividualPrice_Int()
    {
      int result = Pastry.GetIndividualPrice();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsPastryQuantity_Int()
    {
      int pastryQuantity = 3;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      int result = pastryOrder.Quantity;
      Assert.AreEqual(pastryQuantity, result);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnsPastryOrderTotalPrice_Int()
    {
      int pastryQuantity = 2;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      int result = pastryOrder.GetTotalPrice();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void GetTotalPrice_ReturnsPastryOrderTotalSpecialPrice_Int()
    {
      int pastryQuantity = 10;
      Pastry pastryOrder = new Pastry(pastryQuantity);
      int result = pastryOrder.GetTotalPrice();
      Assert.AreEqual(17, result);
    }
  }
}