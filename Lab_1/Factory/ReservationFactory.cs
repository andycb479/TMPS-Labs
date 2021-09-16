using System;
using System.Collections.Generic;
using System.Linq;
using Lab_1.Singleton;
using TMPS_Labs.Models.Reservation;
using TMPS_Labs.Models.Reservee;
using TMPS_Labs.Models.Spots;

namespace Lab_1.Factory
{
     public sealed class ReservationFactory : Factory
     {
          public static event EventHandler<Reservation> ReservationMade;
          public static Reservation MakeReservation<T>(List<T> spots, List<Reservee> reservees, int id, int spotId, int reserveeId, int reservationEntityId,
               DateTime dateMade, DateTime reservationDate, float reservationTax, DateTime? limitCancelationDay = null,
               float cancelationTax = 0) where T: Spot
          {
               if (!spots.Select(spot => spot.Id).Contains(spotId))
               {
                    throw new Exception($"Can't create reservation at unknown {typeof(T).Name}");
               }

               if (!reservees.Select(reserv=>reserv.Id).Contains(reserveeId))
               {
                    throw new Exception($"Unknown user.");
               }

               if (dateMade > DateTime.Now)
               {
                    throw new Exception("Invalid creation date.");
               }

               cancelationTax = cancelationTax == 0 ? reservationTax * 0.1f: cancelationTax;

               _logger.Log(LogType.Create,$"Reservation with id:{id} was successfully created.");


               var product = new Reservation
               {
                    Id = id,
                    SpotId = spotId,
                    ReserveeId = reserveeId,
                    ReservationEntityId = reservationEntityId,
                    DateMade = dateMade,
                    ReservationDate = reservationDate,
                    LimitCancelationDay = limitCancelationDay ?? reservationDate,
                    ReservationTax = reservationTax,
                    CancelationTax = cancelationTax
               };

               // Event trigger.
               OnReservationMade(product);

               return product;
          }

          private static void OnReservationMade(Reservation reservation)
          {
               ReservationMade?.Invoke(null, reservation);
          }
     }
}