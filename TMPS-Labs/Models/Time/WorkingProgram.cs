using System;
using System.Collections.Generic;

namespace TMPS_Labs.Models.Time
{
     public class WorkingProgram
     {
          public Dictionary<DayOfWeek, DayRange> ActiveDaysDict;
          public DayRange Monday { get; set; }
          public DayRange Tuesday { get; set; }
          public DayRange Wednesday { get; set; }
          public DayRange Thursday { get; set; }
          public DayRange Friday { get; set; }
          public DayRange Saturday { get; set; }
          public DayRange Sunday { get; set; }

          public bool isActive247;
     }
}