using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace SocialSync.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}
