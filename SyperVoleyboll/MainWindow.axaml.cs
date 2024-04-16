using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;
using SyperVoleyboll.Database;

namespace SyperVoleyboll;

public partial class MainWindow : Window
{
    private DB _db;
    public MainWindow()
    {
        InitializeComponent();
        _db = DB.GetDb();
    }

    private void Log(object? sender, RoutedEventArgs e)
    {
        Users logUser =_db.UsersList.FirstOrDefault(u => u.Login == Login.Text && u.Password == Password.Text);
        if (logUser == null)
        {
            return;
        }

        switch (logUser.Role.Name)
        {
            case "Администратор":
                new ProfileAdmin(logUser).Show();
                break;
            case "Менеджер":
                new ProfileManadger(logUser).Show();
                break;
        }
        Close();
        
    }
}