using Domain.Models.Spots;

namespace Domain.Models.Reservation
{
     public class ReservationEntity
     {
          public string EntityId { get; set; }
          public Schedule ReservationSchedule { get; set; }

     }
}