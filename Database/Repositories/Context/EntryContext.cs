using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Shared.Models;

namespace Database.Repositories.Context;

public class EntryContext : DbContext
{
    public DbSet<Entry> Entries => Set<Entry>();
    public string _connectionString;

    public EntryContext(IConfiguration configuration)
    {
        _connectionString = configuration["ConnectionString"];
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite(_connectionString);
        }
    }
}