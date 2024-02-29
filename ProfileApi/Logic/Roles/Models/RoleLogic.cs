using System.ComponentModel.DataAnnotations;

namespace ProfileLogic.Roles.Models;

/// <summary>
/// Модель роли для слоя Logic 
/// </summary>
public class RoleLogic
{
    [Required]
    public string Name { get; init; }
}