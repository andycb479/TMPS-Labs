using System;
using System.Collections.Generic;
using Domain.Models.Time;

namespace Domain.Models.Spots
{
     public class Spot : BaseEntity
     {
          public String Name { get; set; }
          public Location Location { get; set; }
          public WorkingProgram WorkingHoursAndDays { get; set; }
          public PriceLevel PriceLevel { get; set; }
          public float? Rating { get; set; }
          public List<Floor> Floors { get; set; }
          public List<string> TelephoneNumbers { get; set; }
          public bool ArePetsAllowed { get; set; }
          public string Description { get; set; }

          // public void Accept(IVisitor visitor)
          // {
          //      visitor.Visit(this);
          // }

     }
}