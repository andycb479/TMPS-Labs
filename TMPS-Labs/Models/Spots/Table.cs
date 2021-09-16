using TMPS_Labs.Models.Reservation;

namespace TMPS_Labs.Models.Spots
{
     public class Table : ReservationEntity
     {
          public int TableNumber  { get; set; }
          public int NumberOfSeats { get; set; }

          public TableClass TableClass { get; set; }
     }
}