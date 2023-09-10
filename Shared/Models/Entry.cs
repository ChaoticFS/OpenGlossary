namespace Shared.Models;

public class Entry
{
    public int Id { get; set; }
	public string? Title { get; set; }
	public string? Content { get; set; }
    public DateTime TimeCreated { get; set; }
    public int ParentId { get; set; }
}