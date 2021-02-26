namespace Bakery.Models
{
  public class Pastry
  {
    private static int _price = 2;

    public Pastry()
    {
      
    }

    public static int GetPrice()
    {
      return Pastry._price;
    }
  }
}