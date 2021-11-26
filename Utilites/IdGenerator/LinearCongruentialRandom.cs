using System;

namespace Utility.IdGenerator
{
     public class LinearCongruentialRandom
     {
          private const long m = 4294967296; // aka 2^32
          private const long a = 1664525;
          private const long c = 1013904223;
          private long _last;

          public LinearCongruentialRandom()
          {
               _last = DateTime.Now.Ticks % m;
          }

          public LinearCongruentialRandom(long seed)
          {
               _last = seed;
          }

          public long Next()
          {
               _last = ((a * _last) + c) % m;

               return _last;
          }

          public long Next(long maxValue)
          {
               return Next() % maxValue;
          }
     }
}