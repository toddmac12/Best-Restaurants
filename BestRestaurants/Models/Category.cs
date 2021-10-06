
using System.Collections.Generic;

namespace BestRestaurants.Models
{
  public class Category
  {
    public Category()
    {
      this.Items = new HashSet<Item>();
    }

    public int CategoryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Item> Items { get; set; }
  }
}