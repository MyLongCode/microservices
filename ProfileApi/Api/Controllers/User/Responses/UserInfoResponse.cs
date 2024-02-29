using System.ComponentModel.DataAnnotations;

namespace ProfileApi.Controllers.User.Responses;

public record UserInfoResponse
{
    [Required]
    public Guid Id { get; init; }

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