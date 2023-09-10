using Database.Context;
using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Database.Repositories;

public class EntryRepository : IEntryRepository
{
    private readonly EntryContext db;

    public EntryRepository(EntryContext db)
    {
        this.db = db;
    }

    public Entry GetEntry(int id)
    {
        return db.Entries.SingleOrDefault(e => e.Id == id);
    }

    public void PostEntry(Entry entry)
    {
        db.Entries.Add(entry);
        db.SaveChanges();
    }

    public void DeleteEntry(int id)
    {
        //Update children's parentid back to default value
        var children = db.Entries.Where(e => e.ParentId == id);
        foreach (var entry in children)
        {
            entry.ParentId = 0;
        }

        var parent = db.Entries.Find(id);
        db.Entries.Remove(parent);
        db.SaveChanges();
    }

    public void UpdateEntry(Entry entry)
    {
        db.Entries.Update(entry);
        db.SaveChanges();
    }
}
