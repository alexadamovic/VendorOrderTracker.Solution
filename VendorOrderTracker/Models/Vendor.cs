using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public string Description { get; }
    public int Id { get; }

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}