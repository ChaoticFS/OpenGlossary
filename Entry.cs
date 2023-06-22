namespace Shared.Models;

public class Entry
{
	public Entry(string title)
	{
		Title = title;
	}

	public int Id { get; set; }
	public string Title { get; set; }
	public string Content? { get; set; }
	public string ImagePath? { get; set; }
	public int ParentId? { get; set; }
}
