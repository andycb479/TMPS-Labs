using System;
using TMPS_Labs.Models.Spots;

namespace TMPS_Labs.Models.Reservation
{
     public class Reservation : BaseEntity
     {
          public int SpotId { get; set; }
          public int ReserveeId { get; set; }
          public id ReservationEntityId { get; set; }
          public DateTime DateMade { get; set; }
          public DateTime ReservationDate { get; set; }
          public DateTime LimitCancelationDay { get; set; }
          public float ReservationTax { get; set; }
          public float CancelationTax { get; set; }
     }
     
}
