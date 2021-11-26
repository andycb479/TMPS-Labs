using System;

namespace Utility.IdGenerator
{
     public class LaggedFibRandomIdGenerator: RandomIdGenerator
     {
          protected override string RandomNumber()
          {
               var algo = new LaggedFibRandom(new Random().Next());
               return algo.Next().ToString();
          }
     }
}
