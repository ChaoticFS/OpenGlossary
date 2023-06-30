using Shared.Models;

namespace Database.Services;

internal interface IMenuService
{
    List<MenuEntry> GetParentlessMenuEntries();
    List<MenuEntry> GetChildren(int id);
    List<MenuEntry> GetMenuEntries(int id); // If using id 0 it should return all entries, if specific id return whole tree
    List<MenuEntry> GetMenuEntriesByFilter(List<string> filters);
}