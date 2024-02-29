using System.ComponentModel.DataAnnotations;

namespace ProfileApi.Controllers.User.Responses;

public record CreateUserResponse
{
    [Required]
    public Guid Id { get; init; }
}