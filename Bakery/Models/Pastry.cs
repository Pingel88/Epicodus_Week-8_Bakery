namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    private static int _price = 2;

    public Pastry(int quantity)
    {
      Quantity = quantity;
    }

    public static int GetIndividualPrice()
    {
      return Pastry._price;
    }

    public int GetTotalPrice()
    {
      return _price * Quantity;
    }
  }
}