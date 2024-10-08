using System.ComponentModel.DataAnnotations;

namespace Task1;

/*
 3. Замовлення – Order
   1) + ProductId: Guid
   2) + Name: string
   3) + Create: datetime
   4) + Update: datetime
   5) + Description: string
 */

public class Order
{
    public Guid OrderId { get; set; } 
    public string Name { get; set; }
    public DateTime Create { get; set; }
    public DateTime Update { get; set; }
    public string Description { get; set; }
}