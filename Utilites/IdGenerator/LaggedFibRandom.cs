using System;
using System.Collections.Generic;

namespace Utility.IdGenerator
{
     public class LaggedFibRandom
     {
          // X(n) = X(n-10) + X(n-7)  mod m
          // init first 10 Xi using Lehmer algorithm

          private const int k = 10; // largest "-index"
          private const int j = 7; // other "-index"
          private const int m = 2147483647;

          // Lehmer initialization constants
          private const int a = 48271;  // 
          private const int q = 44488;  // m / a
          private const int r = 3399;  // m % a

          private List<int> vals = null;
          private int curr;

          public LaggedFibRandom(int seed)
          {
               vals = new List<int>();
               if (seed == 0) seed = 1;
               int lCurr = seed;  // Lehmer current

               // init using Lehmer algorithm
               for (int i = 0; i < k + 1; ++i)  // [0 .. 10]
               {
                    int hi = lCurr / q;  // prevent overflow
                    int lo = lCurr % q;
                    int t = (a * lo) - (r * hi);

                    if (t > 0)
                         lCurr = t;
                    else
                         lCurr = t + m;

                    vals.Add(lCurr);
               } // init

               // burn 1000 values away
               for (int ct = 0; ct < 1000; ++ct)
               {
                    double dummy = this.Next();
               }
          }  // ctor

          public double Next()
          {
               // (a + b) mod n =
               // [(a mod n) + (b mod n)] mod n
               int left = vals[0] % m;    // [x-big]
               int right = vals[k - j] % m; // [x-other]
               long sum = (long)left + (long)right;

               curr = (int)(sum % m);
               vals.Insert(k + 1, curr);  // anew val at end
               vals.RemoveAt(0);  // [0] val irrelevant now
               return Convert.ToInt32((1.0 * curr)/m * 100000000);
          }
     }
}