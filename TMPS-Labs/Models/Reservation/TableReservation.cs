namespace TMPS_Labs.Models.Reservation
{
     public class TableReservation : Reservation
     {
          public int TableNumber { get; set; }
          public int PersonsCount { get; set; }
          public int TableFloorNumber { get; set; }
     }
}