using System;
public record PostRequest
{
    public Guid UserId { get; init; }

    public string Title { get; init; }

    public string Content { get; init; }
}