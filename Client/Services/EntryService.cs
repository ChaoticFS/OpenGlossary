using Shared.Models;
using Database.Controllers;

namespace Client.Services;

public class EntryService : IEntryService
{
    private readonly EntryController _controller;

    public EntryService(EntryController controller)
    {
        _controller = controller;
    }
}