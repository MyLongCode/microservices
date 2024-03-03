using System.ComponentModel.DataAnnotations;

namespace ProfileApi.Controllers.Role.Requests;

public record CreateRoleRequest
{
    [Required]
    public string Name { get; init; }

}