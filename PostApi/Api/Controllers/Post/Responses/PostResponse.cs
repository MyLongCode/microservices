using System;

public record PostResponse
{
    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("id")]
    public required Guid Id { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("userId")]
    public required Guid UserId { get; init; }

    public required UserInfoResponse UserInfo { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("title")]
    public required string Title { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [JsonProperty("content")]
    public required string Content { get; init; }
}