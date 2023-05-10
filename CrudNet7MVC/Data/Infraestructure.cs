using Microsoft.EntityFrameworkCore;

namespace CrudNet7MVC.Data
{
    public static class Infraestructure
    {
        public static void AddDbContext(this IServiceCollection services,
                                             IConfiguration configuration)
        {
            var conectionString = configuration.GetConnectionString("ConexionSql");
            services.AddDbContext<ApplicationsDbContext>(builder =>
            {
                builder.UseSqlServer(conectionString);
            });

            services.AddHttpContextAccessor();
        }
    }
}
