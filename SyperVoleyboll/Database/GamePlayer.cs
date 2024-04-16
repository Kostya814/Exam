namespace SyperVoleyboll.Database;

public class GamePlayer
{
    public int Id { get; set; }
    public Players Player { get; set; }
    public Games Game { get; set; }
}