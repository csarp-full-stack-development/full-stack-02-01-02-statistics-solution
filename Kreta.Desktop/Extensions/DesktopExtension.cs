using Kreta.HttpService;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Assemblers;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Kreta.Desktop.Extensions
{
    public static class DesktopExtensions
    {
        public static void AddDesktop(this IServiceCollection services)
        {
            services.ConfigureHttpClient();
            services.ConfigureHttpServices();
            services.ConfigureAssamblers();
        }

        private static void ConfigureHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", configureClient => { configureClient.BaseAddress = new Uri("https://localhost:7090/"); });
        }

        private static void ConfigureHttpServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentHttpService, StudentHttpService>();
            services.AddScoped<ISubjectHttpService, SubjectHttpService>();
        }

        private static void ConfigureAssamblers(this IServiceCollection services)
        {
            {
                services.AddScoped<StudentAssembler>();
                services.AddScoped<SubjectAssambler>();
            }
        }
    }
}