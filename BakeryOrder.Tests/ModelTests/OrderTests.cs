using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryOrder.Models;
using System;

namespace BakeryOrder.Tests
{
  [TestClass]
    public class OrderTests
    {
      [TestMethod]
      public void OrderConstructor_CreatesInstanceOfOrder_Order()
      {
        Order newOrder = new Order("test", "test", "test");
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }

      [TestMethod]
      public void GetDateDescriptionAndPrice_ReturnDateDescriptionAndPrice_String()
      {
        string date = "June 4th";
        string description = "1 loaf of bread";
        string price = "$8.00";

        Order newOrder = new Order(date, description, price);
        string result = newOrder.Description;

        Assert.AreEqual(1, result);
      }
    }
}

