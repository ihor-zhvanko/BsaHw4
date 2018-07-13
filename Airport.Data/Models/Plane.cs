using System;

namespace Airport.Data.Models
{
  public class Plane : Entity
  {
    public string Name { get; set; }
    public int PlaneTypeId { get; set; }
    public DateTime ReleaseDate { get; set; }
    public TimeSpan ServiceLife { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var plane = (Plane)obj;
      return plane.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}