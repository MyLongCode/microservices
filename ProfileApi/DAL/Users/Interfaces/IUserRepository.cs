using ProfileDal.Users.Models;

namespace ProfileDal.Users.Interfaces;

/// <summary>
/// Хранение пользователя
/// </summary>
public interface IUserRepository
{
    /// <summary>
    /// получить по имени 
    /// </summary>
    Task<string> GetUserNameAsync(Guid userId);
    
    /// <summary>
    /// Создать пользователя
    /// </summary>
    Task<Guid> CreateUserAsync(UserDal user);
    /// <summary>
    /// Удалить пользователя по id
    /// </summary>
    /// <param name="userId"></param>
    /// <returns>Сообщение об удалении или ошибку,
    /// если не получилось найти пользователя с userId</returns>
    Task<string> DeleteUserAsync(Guid userId);
}


