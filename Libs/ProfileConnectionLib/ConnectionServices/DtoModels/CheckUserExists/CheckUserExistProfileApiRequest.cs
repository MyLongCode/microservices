namespace ProfileConnectionLib.ConnectionServices.DtoModels.CheckUserExists;

public record CheckUserExistProfileApiRequest
{
    public Guid UserId { get; init; }
}
