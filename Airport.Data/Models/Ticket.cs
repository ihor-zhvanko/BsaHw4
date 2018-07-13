using System;

namespace Airport.Data.Models
{
  public class Ticket : Entity
  {
    public double Price { get; set; }
    public int FlightId { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var ticket = (Ticket)obj;
      return ticket.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}