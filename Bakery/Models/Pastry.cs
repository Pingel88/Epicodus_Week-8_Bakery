namespace Bakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    private static int _price = 2;

    public Pastry(int quantity)
    {
      
    }

    public static int GetPrice()
    {
      return Pastry._price;
    }
  }
}