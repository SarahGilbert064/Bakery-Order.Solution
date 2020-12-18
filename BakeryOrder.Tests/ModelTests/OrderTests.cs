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
        Order newOrder = new Order("test", "test");
        Assert.AreEqual(typeof(Order), newOrder.GetType());
      }
    }
}

