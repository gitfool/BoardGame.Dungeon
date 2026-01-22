namespace BoardGame.Dungeon;

public sealed class ConfigValidator : AbstractValidator<Config>
{
    public ConfigValidator()
    {
        RuleFor(config => config.OAuthBearerToken).NotEmpty();
    }
}
