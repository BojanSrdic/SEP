using Data_Access_Layer.DbConnection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Data_Access_Layer
{
	public static class DependencyInjection
	{
		public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<DatabaseContext>(option => option.UseInMemoryDatabase("InMemory"));

			return services;
		}
	}
}
