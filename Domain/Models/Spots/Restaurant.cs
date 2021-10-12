using System;

namespace Domain.Models.Spots
{
     public class Restaurant : Spot
     {
          public String KitchenType { get; set; }
          public bool HasLiveMusic { get; set; }

     }
}