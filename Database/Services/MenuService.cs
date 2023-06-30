using Database.Context;
using Shared.Models;

namespace Database.Services;

public class MenuService : IMenuService
{
    private EntryContext db { get; }

    public MenuService(EntryContext db)
    {
        this.db = db;
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
