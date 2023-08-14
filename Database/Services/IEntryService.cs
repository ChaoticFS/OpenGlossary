using Shared.Models;

namespace Database.Services;

internal interface IEntryService
{
    Entry GetEntry(int id);
    Entry PostEntry(Entry entry);
    bool DeleteEntry(int id);
    Entry PutEntry(Entry entry);
}