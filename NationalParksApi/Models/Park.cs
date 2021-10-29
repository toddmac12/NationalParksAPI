using System.ComponentModel.DataAnnotations;

namespace NationalParksApi.Models
{
  public class Park
  {
    public int ParkId {get; set;}
public string Name {get; set;}
  public string Location {get; set;}
  public float AreaKmSquared {get; set;}
  public string Description {get; set;}
  }
}