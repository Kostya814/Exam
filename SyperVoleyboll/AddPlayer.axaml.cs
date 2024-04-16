using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using MsBox.Avalonia.Enums;
using SyperVoleyboll.Database;

namespace SyperVoleyboll;

public partial class AddPlayer : Window
{
    private DB _db;
    private ProfileAdmin _admin;
    private ProfileManadger _manage;
    
    public AddPlayer(ProfileAdmin main)
    {
        InitializeComponent();
        _db = DB.GetDb();
        _admin = main;
    }
    public AddPlayer(ProfileManadger main)
    {
        InitializeComponent();
        _db = DB.GetDb();
        _manage = main;
    }

    private void Create(object? sender, RoutedEventArgs e)
    {
        try
        {
            _db.PlayersList.Add(new Players()
            {
                Id = _db.PlayersList.Count+1,
                BithDay = dp.SelectedDate.Value.DateTime,
                Position = tbPosition.Text,
                Name = tbName.Text,
                Team = new Teams()
                {
                    Id = _db.TeamsList.Count+1,
                    Name = tbPosition.Text
                },
                Weight = Convert.ToInt16(tbWeight.Text),
                Heihgt = Convert.ToInt16(tbHeihgt.Text)
            
            });
            //добавление в класс DB смотрите список PlayerList
            if(_admin!=null) _admin.Update();
            if(_manage!=null) _manage.Update();
            var box = MessageBoxManager.GetMessageBoxStandard("Успех", "Данные успешно добавленны", ButtonEnum.Ok);
                        box.ShowAsync();
        }
        catch (Exception exception)
        {
            var box = MessageBoxManager.GetMessageBoxStandard("Ошибка", "Неправильно введены данные /n", ButtonEnum.Ok);
            box.ShowAsync();
        }
       
    }
}