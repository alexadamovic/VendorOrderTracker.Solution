using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public string Price { get; }

    public Order(string title, string description, string price)
    {
      Title = title;
      Description = description;
    }
  }
}