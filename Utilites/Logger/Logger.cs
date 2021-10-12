using System;

namespace Utility.Logger
{
     class Logger : ILogger
     {
          public bool Log(string message)
          {
               if (string.IsNullOrEmpty(message)) return false;
               Console.WriteLine($"Logging: {message}");
               return true;
          }
     }
}