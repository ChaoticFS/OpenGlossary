using Database.Context;
using Shared.Models;

namespace Database.Services;

public class EntryService : IEntryService
{
    public EntryContext db { get; }

    public EntryService(EntryContext db)
    {
        this.db = db;
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
