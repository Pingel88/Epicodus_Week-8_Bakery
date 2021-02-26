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

    public static int GetPrice()
    {
      return Bread._price;
    }
  }
}