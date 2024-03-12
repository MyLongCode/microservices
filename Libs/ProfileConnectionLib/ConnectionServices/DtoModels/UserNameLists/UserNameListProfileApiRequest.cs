namespace ProfileConnectionLib.ConnectionServices.DtoModels.UserNameLists;

// "{name}{servicename}{request/response}"
public record UserNameListProfileApiRequest
{
    public Guid[] UserIdList { get; init; }
}
