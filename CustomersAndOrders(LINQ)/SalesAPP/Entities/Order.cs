using System;


namespace SalesAPP.Entities;

public class Order
{
    public int OrderID { get; set; } 
    public int CustomerID { get; set; } 
    public DateTime OrderDate { get; set; }
    public DateTime? ShippedDate { get; set; }


    public override string ToString()
    {
        return $"{OrderID}:{CustomerID}:{OrderDate}:{ShippedDate}";
    }
}
