using System.Collections.Generic;


namespace BakeryOrder.Models
{
  public class Order
  {
    public string Date { get; set; }
    public string Description { get; set; }

    public string Price { get; set; }

    public int Id { get; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string orderDate)
    {
      Date = orderDate;
      // Description = orderDescription;
      // Price = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public Order(string orderDate, string orderDescription)
      : this(orderDate)
    {
      Description = orderDescription;
    }

    public Order(string orderDate, string orderDescription, string orderPrice)
      : this(orderDate, orderDescription)
    {
      Price = orderPrice;
    }  

    public static List<Order> GetAll()
    {
      return null;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}