using Microsoft.Extensions.DependencyInjection;

namespace BuffetDinner.Application;
using Services.Authentication;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddTransient<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
