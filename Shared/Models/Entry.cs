namespace Shared.Models;

public class Entry
{
    
	public Entry(int id, string title)
	{
		Id = id;
		Title = title;
	}

    public Entry(int id, string title, string content)
    {
        Id = id;
        Title = title;
        Content = content;
    }

    public int Id { get; set; }
	public string Title { get; set; }
	public string? Content { get; set; }
    public DateTime TimeCreated { get; set; }
    public int ParentId { get; set; }
}
