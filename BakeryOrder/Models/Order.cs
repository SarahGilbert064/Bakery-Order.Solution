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

    public Order(string orderDate, string orderDescription, string orderPrice)
    {
      Date = orderDate;
      Description = orderDescription;
      Price = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Order> GetAll()
    {
      return null;
    }
  }
}