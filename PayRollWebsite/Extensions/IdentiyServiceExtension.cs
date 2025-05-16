using Microsoft.AspNetCore.Identity;
using Payroll.Repositories;

namespace PayRollWebsite.Extensions
{
    public  static class IdentiyServiceExtension
    {
        public static IServiceCollection IdentityService(this IServiceCollection services,
          IConfiguration configuration)
        {

            services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

            return services;
        }
    }
}
