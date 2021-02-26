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
      Bread userBread = new Bread();
      Assert.AreEqual(typeof(Bread), userBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnsBreadPrice_Int()
    {
      int result = Bread.GetPrice();
      Assert.AreEqual(5, result);
    }
  }
}