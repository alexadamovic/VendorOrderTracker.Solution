using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("Title", "Description", "Price", "Date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Test Title";
      Order newOrder = new Order(title, "Description", "Price", "Date");
      string result = newOrder.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "Test Description";
      Order newOrder = new Order("Title", description, "Price", "Date");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_String()
    {
      string price = "Test Price";
      Order newOrder = new Order("Title", "Description", price, "Date");
      string result = newOrder.Price;
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      string date = "Test Date";
      Order newOrder = new Order("Title", "Description", "Price", date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetId_ReturnsOrderId_Int()
    {
      Order newOrder = new Order("Title", "Description", "Price", "Date");
      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }
    
  }
}