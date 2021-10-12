using Domain.Models.Reservation;

namespace Domain.Models.Spots
{
     public class Floor
     {
          public int FloorNumber { get; set; }
          public ReservationEntity[] ReservationEntities { get; set; }
     }
}