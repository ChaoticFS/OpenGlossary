using Database.Context;
using Database.Repositories;
using Shared.Models;

namespace Database.Controllers;

public class MenuController : IMenuController
{
    private readonly MenuRepository _repo;

    public MenuController(MenuRepository repo)
    {
        _repo = repo;
    }

    public List<MenuEntry> GetParentlessMenuEntries()
    {
        throw new NotImplementedException();
    }

    public List<MenuEntry> GetChildren(int id)
    {
        throw new NotImplementedException();
    }

    public List<MenuEntry> GetMenuEntries(int id)
    {
        throw new NotImplementedException();
    }

    public List<MenuEntry> GetMenuEntriesByFilter(List<string> filters)
    {
        throw new NotImplementedException();
    }
}
