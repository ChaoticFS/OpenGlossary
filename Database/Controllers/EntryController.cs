using Database.Controllers.Interfaces;
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
        return _repo.GetEntry(id);
    }

    public void PostEntry(Entry entry)
    {
        _repo.PostEntry(entry);
    }

    public void DeleteEntry(int id)
    {
        _repo.DeleteEntry(id);
    }

    public void PutEntry(Entry entry)
    {
        _repo.UpdateEntry(entry);
    }
}
