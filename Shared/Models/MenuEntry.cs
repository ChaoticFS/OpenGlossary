namespace Client.Models;
internal class MenuEntry
{
    MenuEntry(int id, string name, List<MenuEntry>? entries)
    {
        Id = id;
        Name = name;
        Entries = entries;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<MenuEntry>? Entries { get; set; }
}