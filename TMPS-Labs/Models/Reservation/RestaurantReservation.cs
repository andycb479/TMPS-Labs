using System;

namespace TMPS_Labs.Models.Reservation
{
     public class RestaurantReservation: TableReservation
     {
          public TimeSpan ReservationHoursInterval { get; set; }
     }
}