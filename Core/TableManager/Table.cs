using System;

namespace Core.TableManager
{
     public class Table : TablePrototype
     {
          private readonly int _number;
          private readonly int _floorNumber;
          private readonly int _capacity;

          public Table(int number, int floorNumber, int capacity)
          {
               _number = number;
               _floorNumber = floorNumber;
               _capacity = capacity;
          }

          public override TablePrototype Clone()
          {
               Console.WriteLine(
                    "Cloning the table: {0,3},{1,3},{2,3}",
                    _number, _floorNumber, _capacity);

               return MemberwiseClone() as TablePrototype;
          }
     }
}