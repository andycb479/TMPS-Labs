using System;

namespace Domain.Models.Reservation
{
     public class RestaurantReservation: TableReservation
     {
          public TimeSpan ReservationHoursInterval { get; set; }
     }
}