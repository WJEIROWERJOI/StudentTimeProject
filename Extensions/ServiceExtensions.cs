using Blazored.LocalStorage;
using Blazored.Modal;
using Blazored.SessionStorage;
using Blazored.Toast;
using StudentTimeProject.Data.Repositories;
using StudentTimeProject.Data.Services;

namespace StudentTimeProject.Extention;

public static class ServiceExtensions
{
    public static IServiceCollection AddAppServices(this IServiceCollection services)
    {

        services.AddBlazoredSessionStorage();
        services.AddBlazoredLocalStorage();

        services.AddScoped<LogService>();
        services.AddScoped<StudentService>();
        services.AddScoped<StudentRepository>();


        services.AddBlazoredModal();
        services.AddBlazoredToast();
        services.AddHttpContextAccessor();
        services.AddRazorComponents()
            .AddInteractiveServerComponents();
        services.AddCascadingAuthenticationState();

        return services;
    }
}

