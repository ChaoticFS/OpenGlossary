namespace Shared.Models;

public class MenuEntry
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public List<MenuEntry>? Entries { get; set; }
    public bool IsOpened { get; set; }
}