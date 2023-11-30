using System;


namespace SalesAPP.Entities;

public class Product
{
    public int ProductID { get; set; } 
    public string? ProductName { get; set; } 
    public decimal UnitPrice { get; set; }

    public override string ToString()
    {
        return $"{ProductID}:{ProductName}:{UnitPrice}";
    }
}
