using ProfileDal.Roles.Models;
using ProfileLogic.Roles.Models;

namespace ProfileLogic.Roles.Interfaces;

/// <summary>
/// Работа с пользователем
/// </summary>
public interface IRoleLogicManager
{
    /// <summary>
    /// получить по имени 
    /// </summary>
    Task<string> GetRoleNameAsync(Guid roleId);

    /// <summary>
    /// Создать роль
    /// </summary>
    Task<Guid> CreateRoleAsync(RoleDal role);
    /// <summary>
    /// Удалить роль по id
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Сообщение об удалении или ошибку,
    /// если не получилось найти роль с roleId</returns>
    Task<string> DeleteRoleAsync(Guid roleId);
}

