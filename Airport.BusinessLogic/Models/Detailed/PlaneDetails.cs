using System;

namespace Airport.BusinessLogic.Models
{
  public class PlaneDetails
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime ReleaseDate { get; set; }
    public TimeSpan ServiceLife { get; set; }

    public PlaneTypeModel PlaneType { get; set; }

    public static PlaneDetails Create(PlaneModel plane, PlaneTypeModel planeType)
    {
      return new PlaneDetails
      {
        Id = plane.Id,
        Name = plane.Name,
        ReleaseDate = plane.ReleaseDate,
        ServiceLife = plane.ServiceLife,
        PlaneType = planeType
      };
    }
  }
}