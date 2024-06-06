using Database.Repositories.Context;
using Database.Repositories.Interfaces;
using Shared.Models;

namespace Database.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly EntryContext db;

    public MenuRepository(EntryContext db)
    {
        this.db = db;
    }

    public List<MenuEntry> GetRootNodes()
    {
        List<Entry> entries = db.Entries
                                .Where(e => e.ParentId == 0)
                                .ToList();

        List<MenuEntry> menuEntries = ConvertEntryListToMenuEntryList(entries);

        return menuEntries;
    }

    public List<MenuEntry> GetChildren(int id)
    {
        List<Entry> entries = db.Entries
                                .Where(e => e.ParentId == id)
                                .ToList();

        List<MenuEntry> menuEntries = ConvertEntryListToMenuEntryList(entries);

        return menuEntries;
    }

    private List<MenuEntry> ConvertEntryListToMenuEntryList(List<Entry> entries)
    {
        List<MenuEntry> menuEntries = new List<MenuEntry>();

        foreach (var entry in entries)
        {
            var menuEntry = ConvertEntryToMenuEntry(entry);

            menuEntries.Add(menuEntry);
        }

        return menuEntries;
    }

    private MenuEntry ConvertEntryToMenuEntry(Entry entry)
    {
        MenuEntry menuEntry = new MenuEntry()
        {
            Id = entry.Id,
            Title = entry.Title,
            IsOpened = false
        };

        return menuEntry;
    }
}
