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
      Pastry userPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), userPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsPastryPrice_Int()
    {
      int result = Pastry.GetPrice();
      Assert.AreEqual(2, result);
    }
  }
}