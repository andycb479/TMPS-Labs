using TMPS_Labs.Models.Reservation;

namespace TMPS_Labs.Models.Spots
{
     public class CinemaSeat : ReservationEntity
     {
          public int SeatNumber { get; set; }
          public int RowNumber { get; set; }
          public PriceLevel SeatPrice { get; set; }
     }
}