
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Cuisines
  {
    public Cuisines()
    {
      this.Restaurants = new HashSet<Restaurant>();
    }

    public int CuisinesId { get; set; }
    public string Name { get; set; }
    public string Description{get;set;}
    public virtual ICollection<Restaurant> Restaurants { get; set; }
  }
}