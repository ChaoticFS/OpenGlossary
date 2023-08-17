using Database.Context;
using Shared.Models;

namespace Database.Repositories;

public class EntryRepository : IEntryRepository
{
    private readonly EntryContext db;

    public EntryRepository(EntryContext db)
    {
        this.db = db;
    }
}
