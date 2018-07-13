using System;

namespace Airport.Data.Models
{
  public class Departure : Entity
  {
    public int FlightId { get; set; }
    public DateTime Date { get; set; }
    public int CrewId { get; set; }
    public int PlaneId { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var depature = (Departure)obj;
      return depature.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}