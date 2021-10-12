using Domain.Models.Reservation;

namespace Domain.Models.Spots
{
     public class Table : ReservationEntity
     {
          public int TableNumber  { get; set; }
          public int NumberOfSeats { get; set; }

          public TableClass TableClass { get; set; }
     }
}