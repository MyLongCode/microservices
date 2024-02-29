using ProfileDal.Roles.Models;
using ProfileDal.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfileDal.Roles.Interfaces;
public interface IRoleRepository
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
