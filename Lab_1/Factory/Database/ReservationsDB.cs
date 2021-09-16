﻿using System;
using System.Collections.Generic;
using TMPS_Labs.Models.Reservation;
using TMPS_Labs.Models.Reservee;
using TMPS_Labs.Models.Spots;

namespace Lab_1.Factory.Database
{
     public class ReservationsDb
     {
          public List<Reservation> Reservations { get; set; }

          public ReservationsDb(List<Restaurant> restaurants, List<Reservee> reservees)
          {
               Reservations = new List<Reservation>()
               {
                    ReservationFactory.MakeReservation(restaurants, reservees, 0, 1, 1, 3, DateTime.Today,
                         DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 1, 2, 1, 2,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 2, 1, 1, 1,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 3, 1, 1, 1,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 4, 3, 1, 2,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 5, 1, 1, 1,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
                    ReservationFactory.MakeReservation(restaurants, reservees, 6, 0, 2, 1,
                         DateTime.Today, DateTime.Now + new TimeSpan(10, 5, 0), 100),
               };
          }
     }
}