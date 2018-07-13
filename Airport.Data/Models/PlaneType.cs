using System;

namespace Airport.Data.Models
{
  public class PlaneType : Entity
  {
    public string Model { get; set; }
    public int Seats { get; set; }
    public double Carrying { get; set; }

    public override bool Equals(object obj)
    {
      if (obj == null || GetType() != obj.GetType())
      {
        return false;
      }

      var planeType = (PlaneType)obj;
      return planeType.Id == Id;
    }

    public override int GetHashCode()
    {
      return Id.GetHashCode();
    }
  }
}