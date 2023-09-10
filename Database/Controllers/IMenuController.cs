using Shared.Models;

namespace Database.Controllers;

internal interface IMenuController
{
    List<MenuEntry> GetParentlessMenuEntries();
    List<MenuEntry> GetChildren(int id);
    List<MenuEntry> GetTree(int id); // If using id 0 it should return all entries, if specific id return whole tree
    List<MenuEntry> GetMenuEntriesByFilter(List<string> filters);
}