using System.Collections.Generic;
using TMPS_Labs.Models.Spots;
using TMPS_Labs.Models.Time;

namespace Lab_1.Factory.Database
{
     public class NightClubsDb
     {
          public List<NightClub> NightClubs { get; set; }

          public NightClubsDb()
          {
               NightClubs = new List<NightClub>()
               {
                    NightClubFactory.CreateNightClub(1, "Fanconi", new Location(), new List<Floor>(),
                         new List<string>() {"067154512"}, new WorkingProgram(),
                         new List<string>() {"Tiesto", "ARTBAT", "TaleOfUS",}, null),
                    NightClubFactory.CreateNightClub(1, "Ibiza", new Location(), new List<Floor>(),
                         new List<string>() {"078189212"}, new WorkingProgram(),
                         new List<string>() {"Tiesto", "ARTBAT", "TaleOfUS", "Don Diablo"}, null),
               };
          }
     }
}