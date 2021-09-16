using System;

namespace Lab_1.Singleton
{
     public sealed class ReservationSystemLogger
     {
          private static readonly Lazy<ReservationSystemLogger> lazy = new(() => new ReservationSystemLogger());

          public static ReservationSystemLogger GetLogger
          {
               get { return lazy.Value; }
          }

          private ReservationSystemLogger()
          {
               
          }

          public void Log(LogType type, string message)
          {
               Console.ForegroundColor = type switch
               {
                    LogType.Alert => ConsoleColor.DarkRed,
                    LogType.Info => ConsoleColor.Yellow,
                    LogType.Create => ConsoleColor.Green,
                    LogType.Update => ConsoleColor.DarkGreen,
                    LogType.Delete => ConsoleColor.DarkMagenta,
                    _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
               };

               Console.WriteLine($"[{DateTime.Now}] {message}");
          }
     }
}
