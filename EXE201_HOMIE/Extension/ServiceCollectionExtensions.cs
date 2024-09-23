using Repository.Repository.Interface;
using Repository.Repository;
using Services.Services.Interface;
using Services.Services;
using Services.Mapping;

namespace EXE201_HOMIE.Extension
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection Register(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();

            //Register AutoMapper
            services.AddAutoMapper(typeof(MappingEntites));


            //Register Repository here
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //Register Service here
            services.AddScoped<IUserServices, UserServices>();


            return services;
        }
    }
}
