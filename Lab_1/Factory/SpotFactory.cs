using System;
using System.Collections.Generic;
using System.Linq;
using TMPS_Labs.Models.Spots;
using TMPS_Labs.Models.Time;

namespace Lab_1.Factory
{
     public sealed class SpotFactory : Factory
     {
          public static Spot CreateSpot(int id, string name, Location location, List<Floor> floors,
               List<string> telephoneNumbers, WorkingProgram workingHoursAndDays, string description,
               PriceLevel priceLevel = PriceLevel.Economy, float? rating = null, bool arePetsAllowed = true)
          {
               if (rating > 10.0)
               {
                    throw new Exception($"Rating of the restaurant with id={id} is not valid.");
               }

               if (!telephoneNumbers.All(numbers => numbers.StartsWith("0")))
               {
                    throw new Exception("Not valid telephone numbers provided.");
               }

               return new Spot
               {
                    Id = id,
                    Name = name,
                    Location = location,
                    WorkingHoursAndDays =
                         workingHoursAndDays ?? new WorkingProgram() {isActive247 = true, ActiveDaysDict = null},
                    PriceLevel = priceLevel,
                    Rating = rating,
                    Floors = floors,
                    TelephoneNumbers = telephoneNumbers,
                    ArePetsAllowed = arePetsAllowed,
                    Description = description ?? "No description available."
               };
          }
     }
}