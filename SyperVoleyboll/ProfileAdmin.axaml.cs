using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using SyperVoleyboll.Database;

namespace SyperVoleyboll;

public partial class ProfileAdmin : Window
{
    private Users _user;
    private DB _db;
    public ProfileAdmin(Users user)
    {
        _user = user;
        InitializeComponent();
        Update();
    }

    public void Update()
    {
        _db = DB.GetDb();
        ListBoxGames.ItemsSource = _db.GamePlayerList;
        List<string> listPosition = new List<string>()
        {
            "либеро",
            "нападающий",
            "защитник"
        };
        Filter.ItemsSource = listPosition;
    }

    private void Delete(object? sender, RoutedEventArgs e)
    {
        //удаление в класс DB смотрите список PlayerList
        Button btn = (Button)sender;
        var game = (GamePlayer)btn.DataContext;
        _db.PlayersList.Remove(game.Player);
    }

    private void SearchPlayer(object? sender, TextChangedEventArgs e)
    {
        Sort();
    }

    private void FilterPosition(object? sender, SelectionChangedEventArgs e)
    {
        Sort();
    }

    void Sort()
    {
        List<GamePlayer> searchList = _db.GamePlayerList;
        if (Search.Text != null)
        {
            searchList = searchList.Where(g=>g.Player.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            ListBoxGames.ItemsSource = searchList;
        }
        var filterText = (string)Filter.SelectedItem;
        if(filterText == null) return;
        searchList = searchList.Where(g=>g.Player.Position.ToLower().Contains(filterText)).ToList();
        ListBoxGames.ItemsSource = searchList;
    }

    private void CreateUser(object? sender, RoutedEventArgs e)
    {
        new AddPlayer(this).Show();
    }
}