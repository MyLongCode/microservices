using System.ComponentModel.DataAnnotations;

namespace ProfileApi.Controllers.User.Requests;

public record CreateUserRequest
{
    [Required]
    public string Name { get; init; }

    [Required]
    public string Login { get; init; }
    [Required]
    public string Password { get; init; }

    [Required]
    public string Status{ get; init; }
    [Required]
    public string Phone { get; init; }
}