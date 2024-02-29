using ExampleCore.Dal.Base;
using System.ComponentModel.DataAnnotations;

namespace ProfileDal.Users.Models;

/// <summary>
/// Отражение модели пользователя из хранилища данных
/// </summary>
public record UserDal : BaseEntityDal<Guid>
{

    [Required]
    public string Name { get; init; }

    [Required]
    public string Login { get; init; }
    [Required]
    public string Password { get; init; }

    [Required]
    public string Status { get; init; }
    [Required]
    public string Phone { get; init; }

}