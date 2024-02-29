using System.ComponentModel.DataAnnotations;

namespace ProfileLogic.Users.Models;

/// <summary>
/// Модель пользователя для слоя Logic 
/// </summary>
public class UserLogic
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