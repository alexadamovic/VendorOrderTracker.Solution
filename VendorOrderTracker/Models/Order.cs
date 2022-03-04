using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; }
    public string Description { get; }
    public string Price { get; }
    public string Date { get; }
    public int Id { get; }

    public Order(string title, string description, string price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}