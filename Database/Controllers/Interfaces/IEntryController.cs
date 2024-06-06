using Shared.Models;

namespace Database.Controllers.Interfaces;

internal interface IEntryController
{
    Entry GetEntry(int id);
    void PostEntry(Entry entry);
    void DeleteEntry(int id);
    void PutEntry(Entry entry);
}