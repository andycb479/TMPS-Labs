using System;

namespace Domain.Models.Time
{
     public class DayRange
     {
          public TimeSpan StartHour { get;}
          public TimeSpan EndHour { get; }

          public DayRange(TimeSpan startHour, TimeSpan endHour)
          {
               if (startHour >= endHour)
               {
                    throw new Exception("Opening hour is no early than Closing Date.");
               }

               if (endHour > new TimeSpan(24, 0, 0))
               {
                    throw new Exception("Invalid time");
               }
               StartHour = startHour;
               EndHour = endHour;
          }
     }
}