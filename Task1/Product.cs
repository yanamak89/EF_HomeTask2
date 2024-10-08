using System.ComponentModel.DataAnnotations;

namespace Task1;

/*
 * Розробіть консольну програму з використанням списку з типом (List< ваш вибір >).
   
   1. Магазин – Product
   1) + ProductId: Guid
   2) + Name: string
   3) + Cost: double
   4) + Description: string
   5) + Quantity: int
 */
public class Product
{
    public Guid ProductId { get; set; }
    public string Name { get; set; }
    public double Cost { get; set; }
    public string Description { get; set; }
    public int Quantity { get; set; }
}