using Database.Context;
using Shared.Models;

namespace Database.Repositories;

public class MenuRepository : IMenuRepository
{
    private readonly EntryContext db;

    public MenuRepository(EntryContext db)
    {
        this.db = db;
    }
}
