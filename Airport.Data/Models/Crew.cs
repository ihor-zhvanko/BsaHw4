using System;

namespace Airport.Data.Models
{
  public class Crew : Entity
  {
    public int PilotId { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var crew = (Crew)obj;
      return crew.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}