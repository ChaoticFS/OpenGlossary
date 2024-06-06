using Shared.Models;

namespace Database.Repositories.Interfaces;
public interface IMenuRepository
{
    List<MenuEntry> GetRootNodes();
    List<MenuEntry> GetChildren(int id);
}
