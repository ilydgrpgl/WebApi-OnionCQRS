using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Persistance.Context;

namespace WebApi.Persistance
{
    public static class Registration
    {
        public static void AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
           services.AddDbContext<AppDbContext>(opt=>
                opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
