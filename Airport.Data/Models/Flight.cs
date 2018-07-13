using System;

namespace Airport.Data.Models
{
  public class Flight : Entity
  {
    public string Number { get; set; }
    public string DeparturePlace { get; set; }
    public DateTime DepartureTime { get; set; }
    public string ArrivalPlace { get; set; }
    public DateTime ArrivalTime { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var flight = (Flight)obj;
      return flight.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}