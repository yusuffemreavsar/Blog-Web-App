using Microsoft.Extensions.DependencyInjection;
using Service.Services.Abstract;
using Service.Services.Concrete;

namespace Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            services.AddScoped<IArticleService, ArticleService>();
            return services;
        }
    }
}
