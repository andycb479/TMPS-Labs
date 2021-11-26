using System;
using System.Text;

namespace Utility.IdGenerator
{
     public class EncodedCodeIdGenerator: IIdGenerator
     {
          public string GenerateId(string firstName, string lastName)
          {
               var plainTextBytes = Encoding.UTF8.GetBytes(firstName+lastName);
               return Convert.ToBase64String(plainTextBytes);
          }
     }
}
