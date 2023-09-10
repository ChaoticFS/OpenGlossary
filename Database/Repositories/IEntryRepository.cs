using Shared.Models;

namespace Database.Repositories;
public interface IEntryRepository
{
    Entry GetEntry(int id);
    void PostEntry(Entry entry);
    void DeleteEntry(int id);
    void UpdateEntry(Entry entry);
}
