using Microsoft.Extensions.DependencyInjection;
using BuffetDinner.Application.Common.Interfaces.Authentication;
using BuffetDinner.Infrastructure.Authentication;
using BuffetDinner.Application.Common.Interfaces.Services;
using BuffetDinner.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using BuffetDinner.Application.Common.Interfaces.Persistence;
using BuffetDinner.Infrastructure.Persistence;

namespace BuffetDinner.Infrastructure;
public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddSingleton<IDateTimeProvider, DatetimeProvider>();
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
