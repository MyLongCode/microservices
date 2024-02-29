using ProfileDal.Users.Models;
using ProfileLogic.Users.Models;

namespace ProfileLogic.Users.Interfaces;

/// <summary>
/// Работа с пользователем
/// </summary>
public interface IUserLogicManager
{
    /// <summary>
    /// получить по имени 
    /// </summary>
    Task<string> GetUserNameAsync(Guid userId);

    /// <summary>
    /// Создать пользователя
    /// </summary>
    Task<Guid> CreateUserAsync(UserLogic user);
    /// <summary>
    /// Удалить пользователя по id
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Сообщение об удалении или ошибку,
    /// если не получилось найти пользователя с userId</returns>
    Task<string> DeleteUserAsync(Guid userId);
}
