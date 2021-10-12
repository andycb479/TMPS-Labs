using Domain.Models.Reservation;

namespace Domain.Models.Spots
{
     public class CinemaSeat : ReservationEntity
     {
          public int SeatNumber { get; set; }
          public int RowNumber { get; set; }
          public PriceLevel SeatPrice { get; set; }
     }
}