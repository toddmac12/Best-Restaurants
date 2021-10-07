namespace BestRestaurants.Models
{
  public class Restaurant
  {
    public int RestaurantId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int CuisinesId { get; set; }
    public virtual Cuisines Cuisines { get; set; }
  }
}