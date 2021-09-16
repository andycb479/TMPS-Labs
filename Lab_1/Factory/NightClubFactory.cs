using System.Collections.Generic;
using Lab_1.Singleton;
using TMPS_Labs.Models.Spots;
using TMPS_Labs.Models.Time;

namespace Lab_1.Factory
{
     public sealed class NightClubFactory : Factory
     {
          public static NightClub CreateNightClub(int id, string name, Location location, List<Floor> floors,
               List<string> telephoneNumbers, WorkingProgram workingHoursAndDays, List<string> weeklyLineUp,
               string description, PriceLevel priceLevel = PriceLevel.Economy, float? rating = null,
               bool arePetsAllowed = true)
          {
               var spot = SpotFactory.CreateSpot(id, name, location, floors, telephoneNumbers, workingHoursAndDays,
                    description, priceLevel, rating, arePetsAllowed);

               _logger.Log(LogType.Create, $"NightClub {name} with id:{id}was successfully created.");

               return new NightClub
               {
                    Id = spot.Id,
                    Name = spot.Name,
                    Location = spot.Location,
                    WorkingHoursAndDays = spot.WorkingHoursAndDays ?? new WorkingProgram() { isActive247 = true, ActiveDaysDict = null },
                    PriceLevel = spot.PriceLevel,
                    Rating = spot.Rating,
                    Floors = spot.Floors,
                    TelephoneNumbers = spot.TelephoneNumbers,
                    ArePetsAllowed = spot.ArePetsAllowed,
                    Description = spot.Description ?? "No description available.",
                    WeeklyLineUp = weeklyLineUp ?? new List<string>(){$"{spot.Name} dj"},

               };
          }

          
     }
}