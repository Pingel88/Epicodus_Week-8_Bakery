using System;
using Bakery.Models;

namespace Bakery
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine("                         .I$$$$7                                                ");
      Console.WriteLine("                       .Z+OZO$$7Z$~.                                            ");
      Console.WriteLine("                      .Z=~Z=ZZZZ$7$7          .,7$$II. .                        ");
      Console.WriteLine("                     .ZOOZ$Z$$OZZ$I$$.      7Z8ZOZZZ+$$7.                       ");
      Console.WriteLine("                    .$OZZ$$7Z..OZZ$777.  .$ZZZZZZZZZZ77$$$                      ");
      Console.WriteLine("                    .OZZ7$$$.  .Z=Z?I=I.$O7OOZZZ7Z7ZZZZ77ZZ.                    ");
      Console.WriteLine("                    ZZZZZ77.    .ZO=Z$$7:ZOZZZZZZ..ZZZOZ$$$.                    ");
      Console.WriteLine("                    ZZZ$$77.     $OOZ$7$ZZZZZZ.     .ZZ$$$$.                    ");
      Console.WriteLine("                    ZZ=77$.      .=Z=ZZ77$$$,       OZOO=ZZI                    ");
      Console.WriteLine("                    Z~ZI+7.       $OZ$ZZ7$7.        ZZZOZ~$.                    ");
      Console.WriteLine("                    $~8$77I.     .$ZZZZ=$$..       .ZZZZ$$Z.                    ");
      Console.WriteLine("                    7ZZOI7I.     $77=ZZ$7$.        O~OZO$Z$.                    ");
      Console.WriteLine("                    7ZZ$777.    .ZZI7$Z$$$.       .ZZZ$Z$$.                     ");
      Console.WriteLine("                    I,Z$7I7I    .ZO$??777$.      .Z=ZZZZ$.                      ");
      Console.WriteLine("                    .Z~7$77I..  .OOZZ7II7,       ZZOZZ$$Z                       ");
      Console.WriteLine("                     $ZZ$7ZZ$77778ZOOZ?77.     .ZZZOZ$$$                        ");
      Console.WriteLine("                     .$ZZ$ZZZZ$777OIOZ$ZI$I.  IZ=ZZZ~Z$.                        ");
      Console.WriteLine("                     .ZOZZZZZ$$=7$Z..ZZZ$7I$77+ZZOOZZ7.                         ");
      Console.WriteLine("                     OZ~OO8$$O777...  .ZZZ:ZO77ZZZ$$I                           ");
      Console.WriteLine("                    $ZOZZZ7I77+I7I7II?$ZOZZZZZ$$77$.                            ");
      Console.WriteLine("                    ZZZZ$.7ZZZZZZZII7~II7$OOZ7$Z$$.                             ");
      Console.WriteLine("                     .$.. ..ZOZOOZZ7Z$$ZZ7ZZZZ=OO$Z.                            ");
      Console.WriteLine("                            ..$ZZOZOZZZZZZZZ7+=ZZ7Z.                            ");
      Console.WriteLine("                                .7$$$$$,....  .ZOZ..                            ");
      Console.WriteLine("                                               ..                               ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("________________________________________________________________________________");
      Console.WriteLine("________________________________________________________________________________");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("     _____ _                    _           ____        _                       ");
      Console.WriteLine(@"    |  __ (_)                  ( )         |  _ \      | |                      ");
      Console.WriteLine("    | |__) |  ___ _ __ _ __ ___|/ ___      | |_) | __ _| | _____ _ __ _   _     ");
      Console.WriteLine(@"    |  ___/ |/ _ \ '__| '__/ _ \ / __|     |  _ < / _` | |/ / _ \ '__| | | |    ");
      Console.WriteLine(@"    | |   | |  __/ |  | | |  __/ \__ \     | |_) | (_| |   <  __/ |  | |_| |    ");
      Console.WriteLine(@"    |_|   |_|\___|_|  |_|  \___| |___/     |____/ \__,_|_|\_\___|_|   \__, |    ");
      Console.WriteLine("                                                                       __/ |    ");
      Console.WriteLine("                                                                      |___/     ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("________________________________________________________________________________");
      Console.WriteLine("________________________________________________________________________________");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("                                                                                ");
      Console.WriteLine("Welcome to Pierre's Bakery! I know the logo above is a pretzel but we're fresh out! <press enter>");
      Console.ReadLine();
      Console.WriteLine("In fact, haven't had any since 1992. <press enter>");
      Console.ReadLine();
      Console.WriteLine("We do have anything else you'd like as long as it's loaves of bread or pastries! <press enter>");
      Console.ReadLine();
      Console.WriteLine("Our bread is $5 a loaf and our pastries are $2 each. However, we're currently running a special on bread and pasties! <press enter>");
      Console.ReadLine();
      Console.WriteLine("For every 2 loaves of bread you buy, you can have 1 free! buy 4 loaves, 2 free! buy 5 loaves, still 2 free! <press enter>");
      Console.ReadLine();
      Console.WriteLine("The pastries are a little more simple, they're 3 for $5 but you're not limited to just 3 at that price! as long as it's a set of 3 anyway... Anything outside of a set of 3 will still be $2 each. <press enter>");
      Console.ReadLine();
      Console.WriteLine("How many total loaves of bread would you like? (whole integers only)");
      int breadQuantity = Int32.Parse(Console.ReadLine());
      Bread breadOrder = new Bread(breadQuantity);
      int breadTotal = breadOrder.GetTotalPrice();
      Console.WriteLine("How many total pastries would you like? (whole integers only)");
      int pastryQuantity = Int32.Parse(Console.ReadLine());
      Pastry pastryOrder = new Pastry(pastryQuantity);
      int pastryTotal = pastryOrder.GetTotalPrice();
      Console.WriteLine($"Your {breadOrder.Quantity} loaves of bread comes to a total of ${breadTotal}.");
      Console.WriteLine($"Your {pastryOrder.Quantity} pastries comes to a total of ${pastryTotal}.");
      Console.WriteLine($"Your total today is ${breadTotal + pastryTotal}.");
    }
  }
}