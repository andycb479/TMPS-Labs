using System.Collections.Generic;
using Domain.Models.Spots;
using Domain.Models.Time;

namespace Domain.Factories
{
     public sealed class RestaurantFactory : Factory
     {
          public static Restaurant CreateRestaurant(int id, string name, Location location, List<Floor> floors, List<string> telephoneNumbers, string kitchenType, WorkingProgram workingHoursAndDays, string description, PriceLevel priceLevel = PriceLevel.Economy, float? rating = null, bool arePetsAllowed = true, bool hasLiveMusic = false)
          {
               var kitchenTypes = new List<string>() { "Asian", "Italian", "Mexican", "French", "Turkish" };

               if (!kitchenTypes.Contains(kitchenType))
               {
                    kitchenType = "Other";
               }

               var spot = SpotFactory.CreateSpot(id, name, location, floors, telephoneNumbers, workingHoursAndDays,
                    description, priceLevel, rating, arePetsAllowed);

               _logger.Log(LogType.Create, $"Restaurant {name} with id:{id}was successfully created.");

               return new Restaurant
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
                    KitchenType = kitchenType,
                    HasLiveMusic = hasLiveMusic,
                    Description = spot.Description ?? "No description available."

               };
          }
     }

}
