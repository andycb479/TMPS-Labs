using TMPS_Labs.Models.Reservation;

namespace TMPS_Labs.Models.Spots
{
     public class Floor
     {
          public int FloorNumber { get; set; }
          public ReservationEntity[] ReservationEntities { get; set; }
     }
}