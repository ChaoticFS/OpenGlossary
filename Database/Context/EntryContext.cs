using Microsoft.EntityFrameworkCore;
using Shared.Models;

namespace Database.Context;

public class EntryContext : DbContext
{
    public DbSet<Entry> Entries => Set<Entry>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            string connectionString = "database.db";

            optionsBuilder.UseSqlite(connectionString);
        }
    }
}