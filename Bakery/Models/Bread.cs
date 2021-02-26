namespace Bakery.Models
{
  public class Bread
  {
    public int Quantity { get; set; }
    private static int _price = 5;

    public Bread(int quantity)
    {
      Quantity = quantity;
    }

    public static int GetIndividualPrice()
    {
      return Bread._price;
    }

    public int GetTotalPrice()
    {
      int breadSpecialOrders = Quantity / 3;
      int breadRegularOrders = Quantity % 3;
      return breadSpecialOrders * _price * 2 + breadRegularOrders * _price;
    }
  }
}