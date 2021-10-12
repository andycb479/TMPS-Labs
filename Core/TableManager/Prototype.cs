using System;

namespace Core.TableManager
{
     public class Prototype
     {
          public static void Main(string[] args)
          {
               var colorManager = new TableManager
               {
                    ["economy"] = new Table(0, 0, 2),
                    ["average"] = new Table(1, 1, 4),
                    ["vip"] = new Table(2, 0, 6)
               };

               Table newEconomyTable = colorManager["economy"].Clone() as Table;
               Table newVipTable = colorManager["vip"].Clone() as Table;
               Table newAverageTable = colorManager["average"].Clone() as Table;

               Console.ReadKey();
          }
     }
}
