using System;

namespace SyperVoleyboll.Database;

public class Players
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Teams Team { get; set; }
    public DateTime BithDay { get; set; }
    public string Position { get; set; }
    public int Weight { get; set; }
    public int Heihgt { get; set; }
    
}