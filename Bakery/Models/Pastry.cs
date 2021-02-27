namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    private static int _price = 2;
    private static int _specialPrice = 5;

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public int GetTotalPrice()
    {
      int pastrySpecialOrders = Quantity / 3;
      int pastryRegularOrders = Quantity % 3;
      return pastrySpecialOrders * _specialPrice + pastryRegularOrders * _price;
    }

    //these only exist to get the private field for testing

    public static int GetIndividualPrice()
    {
      return Pastry._price;
    }

    public static int GetSpecialPrice()
    {
      return Pastry._specialPrice;
    }
  }
}