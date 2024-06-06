using Avalonia.Controls;
using Client.Factories;
using Client.Services;

namespace Client;

public partial class MainWindow : Window
{
    private EntryService _entryService;
    private MenuService _menuService;

    public MainWindow()
    {
        InitializeComponent();
        _entryService = EntryServiceFactory.GetService();
        _menuService = MenuServiceFactory.GetService();
    }
}