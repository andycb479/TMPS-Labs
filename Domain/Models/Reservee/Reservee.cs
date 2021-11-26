﻿using Domain.Models.Spots;

namespace Domain.Models.Reservee
{
     public class Reservee: BaseEntity
     {
          public string Id { get; set; }
          public int Age { get; set; }
          public string FirstName { get; set; }
          public string LastName { get; set; }
          public string Email { get; set; }
          public string Country { get; set; }
          public string City { get; set; }
          public string Phone { get; set; }
          public bool IsVerified { get; set; }

     }

     
}