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
            services.AddSignalR();

            //Register AutoMapper
            services.AddAutoMapper(typeof(MappingEntites));

            
            //Register Repository here
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            //Register Service here
            services.AddScoped<IUserServices, UserServices>();
            services.AddScoped<IPostServices, JobPostServices>();
            services.AddScoped<IProfilesServices, ProfilesServices>();
            services.AddScoped<IEWallet, EWalletServices>();
            services.AddScoped<IApplication, ApplicationServices>();
            services.AddScoped<IAuthServices, AuthServices>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            services.AddScoped<ITransactionHistory, TransactionHistoryServices>();
            services.AddScoped<IDashBoardServices, DashBoardServices>();
            services.AddScoped<IReviewServices, ReviewServices>();

            return services;
        }
    }
}
