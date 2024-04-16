namespace SyperVoleyboll.Database;

public class Users
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string LastName { get; set; }
    public Roles Role { get; set; }
}