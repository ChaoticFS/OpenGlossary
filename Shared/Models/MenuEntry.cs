namespace Shared.Models;

public class MenuEntry
{
    MenuEntry(int id, string name, List<MenuEntry>? entries)
    {
        Id = id;
        Name = name;
        Entries = entries;
        IsOpened = false;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<MenuEntry>? Entries { get; set; }
    public bool IsOpened { get; set; }
}