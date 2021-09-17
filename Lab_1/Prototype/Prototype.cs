using System;

namespace Prototype.RealWorld
{
     public class Prototype
     {
          public static void Main(string[] args)
          {
               TableManager colormanager = new TableManager();


               colormanager["economy"] = new Table(0, 0, 2);
               colormanager["average"] = new Table(1, 1, 4);
               colormanager["vip"] = new Table(2, 0, 6);


               Table newEconomyTable = colormanager["economy"].Clone() as Table;
               Table newVipTable = colormanager["vip"].Clone() as Table;
               Table newAverageTable = colormanager["average"].Clone() as Table;

               Console.ReadKey();
          }
     }
}
