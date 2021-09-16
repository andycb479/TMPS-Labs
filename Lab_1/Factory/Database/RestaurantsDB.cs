using System.Collections.Generic;
using TMPS_Labs.Models.Spots;
using TMPS_Labs.Models.Time;

namespace Lab_1.Factory.Database
{
     public class RestaurantsDb
     {
          public List<Restaurant> Restaurants { get; set; }
          public RestaurantsDb()
          {
               Restaurants = new List<Restaurant>()
               {
                    RestaurantFactory.CreateRestaurant(0, "Vasabi", new Location(), new List<Floor>(),
                         new List<string>() {"078189212"}, "Greek", null, null),
                    RestaurantFactory.CreateRestaurant(1, "Andy's", new Location(), new List<Floor>(),
                         new List<string>() {"078559212"}, "Italian", new WorkingProgram(),
                         "Restaurant in center of the city."),
                    RestaurantFactory.CreateRestaurant(2, "Mc.Donalds", new Location(), new List<Floor>(),
                         new List<string>() {"0688189212"}, "Turkish", null, null),
                    RestaurantFactory.CreateRestaurant(3, "KFC", new Location(), new List<Floor>(),
                         new List<string>() {"060868921", "060563421"}, "American", new WorkingProgram(),
                         "The original of America."),
               };
          }
     }
}