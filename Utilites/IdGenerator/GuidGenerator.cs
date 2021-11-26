using System;

namespace Utility.IdGenerator
{
     public class GuidGenerator : IIdGenerator
     {
          public string GenerateId(string firstName, string lastName)
          {
               return Guid.NewGuid().ToString();
          }
     }
}