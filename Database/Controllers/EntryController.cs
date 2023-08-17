using Database.Context;
using Database.Repositories;
using Shared.Models;

namespace Database.Controllers;

public class EntryController : IEntryController
{
    private readonly EntryRepository _repo;

    public EntryController(EntryRepository repo)
    {
        _repo = repo;
    }

    public Entry GetEntry(int id)
    {
        throw new NotImplementedException();
    }

    public Entry PostEntry(Entry entry)
    {
        throw new NotImplementedException();
    }

    public bool DeleteEntry(int id)
    {
        throw new NotImplementedException();
    }

    public Entry PutEntry(Entry entry)
    {
        throw new NotImplementedException();
    }
}
