using Database.Controllers;
using Shared.Models;

namespace Client.Services;

public class MenuService : IMenuService
{
    private readonly MenuController _controller;

    public MenuService(MenuController controller)
    {
        _controller = controller;
    }
}
