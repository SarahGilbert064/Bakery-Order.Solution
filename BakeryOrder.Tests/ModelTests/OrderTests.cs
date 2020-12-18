using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryOrder.Models;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDate_ReturnDate_String()
    {
      string date = "June 4th";

      Order newOrder = new Order(date);
      string result = newOrder.Date;

      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }
  }
}



    // [TestMethod]
    // public void SetDateDescriptionAndPrice_ReturnDateDescriptionAndPrice_String()
    // {
    //   string date = "June 4th";
    //   string description = "1 loaf of bread";
    //   string price = "$8.00";
    //   Order newOrder = new Order(date, description, price);

    //   string updatedDate = "July 5th";
    //   string updatedDescription = "1 pastry";
    //   string updatedPrice = "$2.00";
    //   newOrder.Date = updatedDate;
    //   newOrder.Description = updatedDescription;
    //   newOrder.Price = updatedPrice;
    //   string resultDate = newOrder.Date;
    //   string resultDescription = newOrder.Description;
    //   string resultPrice = newOrder.Price;

    //   Assert.AreEqual(updatedDate, updatedDescription, updatedPrice, resultDate, resultDescription, resultPrice);
