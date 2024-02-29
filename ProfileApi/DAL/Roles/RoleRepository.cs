using ProfileDal.Roles.Interfaces;
using ProfileDal.Roles.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileDal.Roles;
public class RoleRepository : IRoleRepository
{

    private static readonly ConcurrentDictionary<Guid, RoleDal> Store = new();

    public async Task<Guid> CreateRoleAsync(RoleDal role)
    {
        if (role.Id == Guid.Empty)
        {
            role = role with { Id = Guid.NewGuid() };
        }

        if (Store.TryAdd(role.Id, role))
        {
            return role.Id;
        }

        throw new Exception("Ошибка добавления роли");
    }

    public async Task<string> DeleteRoleAsync(Guid roleId)
    {
        if (Store.TryGetValue(roleId, out var role))
        {
            Store.Remove(roleId, out var roleItem);
            return "Роль удалёна";
        }

        throw new Exception("Роль не найдена");
    }

    public async Task<string> GetRoleNameAsync(Guid roleId)
    {
        if (Store.TryGetValue(roleId, out var role))
        {
            return role.Name;
        }

        throw new Exception("Пользователь не найден");
    }
}