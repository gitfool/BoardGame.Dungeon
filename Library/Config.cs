namespace BoardGame.Dungeon;

public sealed record Config
{
    public string OAuthBearerToken { get; init; } = null!;
}
