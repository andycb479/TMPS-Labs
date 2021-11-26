namespace Utility.IdGenerator
{
     public class LinearCongruentialRandomIdGenerator : RandomIdGenerator
     {
          protected override string RandomNumber()
          {
               var algo = new LinearCongruentialRandom();
               return algo.Next().ToString();
          }
     }
}