using System;
using System.Collections.Generic;
using System.Linq;

namespace SyperVoleyboll.Database;

public class DB
{
    private static DB _db;
    public List<Users> UsersList { get; set; }
    public List<Players> PlayersList { get; set; }
    public List<Games> GamesList { get; set; }
    public List<Teams> TeamsList { get; set; }
    public List<Roles> RolesList { get; set; }
    public List<GamePlayer> GamePlayerList { get; set; }

    public static DB GetDb()
    {
        if (_db == null) 
        {
            _db = new DB();
            return _db;
        }

        return _db;
    }

    public DB()
    {
        RolesList = new List<Roles>()
        {
            new Roles()
            {
                Id = 1,
                Name = "Администратор"
            },
            new Roles()
            {
                Id = 2,
                Name = "Менеджер"
            },
        };
        UsersList = new List<Users>()
            {
                new Users()
                {
                    Id = 1,
                    Name = "Витя",
                    Login = "Vity",
                    Password = "Vity",
                    LastName = "Диесперов",
                    Role = RolesList.FirstOrDefault(o=>o.Id==1)
                    
                },
                new Users()
                {
                    Id = 2,
                    Name = "Костя",
                    Login = "loli",
                    Password = "loli",
                    LastName = "Демаков",
                    Role = RolesList.FirstOrDefault(o=>o.Id==2)
                }
            };
        TeamsList = new List<Teams>()
        {
            new Teams()
            {
                Id = 1,
                Name = "КАВКАЗ TEAM"
            }
        };
        PlayersList = new List<Players>()
        {
            new Players()
            {
                Id=1,
                Name = "Дима",
                Heihgt = 190,
                BithDay = DateTime.Today,
                Position = "либеро",
                Team = TeamsList.FirstOrDefault(o=>o.Id == 1)
            },
            new Players()
            {
                Id=2,
                Name = "Витя",
                Heihgt = 190,
                BithDay = DateTime.Today,
                Position = "либеро",
                Team = TeamsList.FirstOrDefault(o=>o.Id == 1)
            },
            new Players()
            {
                Id=3,
                Name = "Дима",
                Heihgt = 190,
                BithDay = DateTime.Today,
                Position = "либеро",
                Team = TeamsList.FirstOrDefault(o=>o.Id == 1)
            }
            ,
            new Players()
            {
                Id=4,
                Name = "Дима",
                Heihgt = 190,
                BithDay = DateTime.Today,
                Position = "нападающий",
                Team = TeamsList.FirstOrDefault(o=>o.Id == 1)
            }
        };
        GamesList = new List<Games>()
        {
            new Games()
            {
                Id = 1,
                BeginDate = DateTime.Today
            }
        };
        GamePlayerList = new List<GamePlayer>()
        {
            new GamePlayer()
            {
                Id = 1,
                Game = GamesList.FirstOrDefault(),
                Player = PlayersList.FirstOrDefault(p => p.Id == 1)
            },
            new GamePlayer()
            {
                Id = 2,
                Game = GamesList.FirstOrDefault(),
                Player = PlayersList.FirstOrDefault(p => p.Id == 2)
            },
            new GamePlayer()
            {
                Id = 3,
                Game = GamesList.FirstOrDefault(),
                Player = PlayersList.FirstOrDefault(p => p.Id == 3)
            },
            new GamePlayer()
            {
            Id = 3,
            Game = GamesList.FirstOrDefault(),
            Player = PlayersList.FirstOrDefault(p => p.Id == 4)
        }
        };
    }
}