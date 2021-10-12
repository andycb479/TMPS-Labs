using System.Collections.Generic;
using Domain.Factories;
using Domain.Models.Reservee;

namespace Data.Database
{
     public class ReserveesDb
     {
          public List<Reservee> Reservees { get; set; }
          private ReserveeFactory _factory;
          public ReserveesDb()
          {
               _factory = new ReserveeFactory();

               Reservees = new List<Reservee>()
               {
                    _factory.CreateReservee(34,"John","SMITH","test@gmail.com","U.S.A","New York","+216382121312"),
                    _factory.CreateReservee(19,"Alfred","York","test@gmail.com","U.S.A,","Texas","+616382321312"),
                    _factory.CreateReservee(20,"Tom","fred","test@gmail.com","U.S.A","Dallas","+316382121312"),
                    _factory.CreateReservee(18,"Michael","musk","test@gmail.com","U.S.A","Washington","+216382421312"),
                    _factory.CreateReservee(24,"Emma","gates","test@gmail.com","U.S.A","California","+116382121312"),
               };
          }
          
     }
}
