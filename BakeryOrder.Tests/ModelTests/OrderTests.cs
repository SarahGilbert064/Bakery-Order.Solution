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
    public void SetDate_SetDate_String()
    {
      string date = "June 4th";
      Order newOrder = new Order(date);

      string updatedDate = "July 5th";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;

      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> {};

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      string date01 = "June 4th";
      string date02 = "July 5th";
      Order newOrder1 = new Order(date01);
      Order newOrder2 = new Order(date02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      List<Order> result = Order.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      string date = "June 4th";
      Order newOrder = new Order(date);

      int result = newOrder.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      string description01 = "1 loaf of bread";
      string description02 = "1 pastry";
      Order newOrder1 = new Order(description01);
      Order newOrder2 = new Order(description02);

      Order result = Order.Find(2);

      Assert.AreEqual(newOrder2, result);
    }
  }
}


