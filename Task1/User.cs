using System.ComponentModel.DataAnnotations;

namespace Task1;
/*
 * 2. Користувач – User
   1) + ProductId: Guid
   2) + Name: string
   3) + LastName: string
   4) + Login: string
   5) + Password: string
   6) + Email: string
   
 */
public class User
{
    public Guid UserId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}