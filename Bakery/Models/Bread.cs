namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    private static int _price = 5;
    // Buy 2 get 1 free is exactly the same as 3 for twice the _price
    private static int _specialPrice = _price * 2;

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public int GetTotalPrice()
    {
      int breadSpecialOrders = Quantity / 3;
      int breadRegularOrders = Quantity % 3;
      return breadSpecialOrders * _specialPrice + breadRegularOrders * _price;
    }

    //these only exist to get the private field for testing

    public static int GetIndividualPrice()
    {
      return Bread._price;
    }
  }
}