using Shared.Models;

namespace Database.Repositories;
public interface IMenuRepository
{
    List<MenuEntry> GetRootNodes();
    List<MenuEntry> GetChildren(int id);
}
