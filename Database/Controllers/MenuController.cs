using Database.Context;
using Database.Controllers.Interfaces;
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
        return _repo.GetRootNodes();
    }

    public List<MenuEntry> GetChildren(int id)
    {
        return _repo.GetChildren(id);
    }

    public List<MenuEntry> GetTree(int id)
    {
        throw new NotImplementedException();
    }

    public List<MenuEntry> GetMenuEntriesByFilter(List<string> filters)
    {
        throw new NotImplementedException();
    }
}
