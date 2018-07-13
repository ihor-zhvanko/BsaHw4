using System;

namespace Airport.Data.Models
{
  public class Pilot : Entity
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public double Experience { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var pilot = (Pilot)obj;
      return pilot.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}