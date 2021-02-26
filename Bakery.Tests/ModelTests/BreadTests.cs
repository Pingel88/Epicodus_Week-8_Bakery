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
      Bread userBread = new Bread(0);
      Assert.AreEqual(typeof(Bread), userBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsBreadPrice_Int()
    {
      int result = Bread.GetPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetQuantity_ReturnsBreadQuantity_Int()
    {
      int breadQuantity = 2;
      Bread userBread = new Bread(breadQuantity);
      int result = userBread.Quantity;
      Assert.AreEqual(breadQuantity, result);
    }
  }
}