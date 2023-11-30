using System;

namespace SalesAPP.Entities;

public class Customer
{
    public int CustomerID { get; set; } 
    public string? FirstName { get; set; } 
    public string? LastName { get; set; } 
    public string? Country { get; set; }


    public override string ToString()
    {
        return $"{CustomerID}:{FirstName} {LastName}:{Country}\n";
    }

}