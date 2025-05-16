using Microsoft.EntityFrameworkCore;
using Payroll.Repositories;
using Payroll.Services;
using Payroll.Services.Implementation;
using Payroll.Repositories.DbInitializer;

namespace PayRollWebsite.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection ApplicationService(this IServiceCollection services,
            IConfiguration configuration)
        {
            var connectionString =configuration.GetConnectionString("ApplicationDbContextConnection") ?? throw new InvalidOperationException("Connection string 'ApplicationDbContextConnection' not found."); ;

            services.AddDbContext<ApplicationDbContext>
                (options => options.UseSqlServer(connectionString));

            services.AddScoped<IDbInitializer, DbInitializer>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            return services;
        }
    }
}
