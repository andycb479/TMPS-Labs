namespace Utility.IdGenerator
{
     public abstract class RandomIdGenerator: IIdGenerator
     {
          public string GenerateId(string firstName, string lastName)
          {
               var code = firstName[0]+lastName[0]; 
               return code + RandomNumber();
          }
          protected abstract string RandomNumber();
     }
}