using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Lab_1.Singleton;
using TMPS_Labs.Models.Reservee;

namespace Lab_1.Factory
{
     public sealed class ReserveeFactory : Factory
     {
          // private readonly IIdGenerator _idGenerator;
          //
          // public ReserveeFactory(IIdGenerator generator)
          // {
          //      _idGenerator = generator;
          // }

          public Reservee CreateReservee(int age, string firstName, string lastName, string email, string country, string city, string phone = "")
          {
               var myTi = new CultureInfo("en-US", false).TextInfo;

               var isVerified = VerifyUser(phone);

               var id = new Random().Next();

               bool VerifyUser(string phoneArg)
               {
                    return !string.IsNullOrEmpty(phoneArg);
               }

               if (!IsEmailValid(email))
               {
                    throw new Exception("Provided email is not valid.");
               }

               _logger.Log(LogType.Create, $"Reservee {myTi.ToTitleCase(firstName)} {myTi.ToTitleCase(lastName)} with id:{id} was created.");

               return new Reservee
               {
                    Id = id,
                    Age = age,
                    FirstName = myTi.ToTitleCase(firstName),
                    LastName = myTi.ToTitleCase(lastName),
                    Email = email,
                    Country = myTi.ToTitleCase(country),
                    City = myTi.ToTitleCase(city),
                    Phone = phone,
                    IsVerified = isVerified,
               };

          }
          public bool IsEmailValid(string email)
          {
               try
               {
                    return Regex.IsMatch(email,
                         @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                         RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
               }
               catch (RegexMatchTimeoutException)
               {
                    return false;
               }
          }
     }
}