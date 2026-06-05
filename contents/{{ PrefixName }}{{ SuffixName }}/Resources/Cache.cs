using StackExchange.Redis;

namespace {{ PrefixName }}{{ SuffixName }}.Resources;

public static class CacheExtensions
{
    public static IServiceCollection AddCache(this IServiceCollection services, Settings settings)
    {
        services.AddSingleton<IConnectionMultiplexer>(
            ConnectionMultiplexer.Connect(settings.RedisUrl));
        return services;
    }
}
