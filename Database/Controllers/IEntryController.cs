using Shared.Models;

namespace Database.Controllers;

internal interface IEntryController
{
    Entry GetEntry(int id);
    Entry PostEntry(Entry entry);
    bool DeleteEntry(int id);
    Entry PutEntry(Entry entry);
}