namespace Bakery.Models
{
  public class Bread
  {
    private static int _price = 5;

    public Bread()
    {
      
    }

    public static int GetPrice()
    {
      return Bread._price;
    }
  }
}