using ExchangeRatesBL.Models;
using ExchangeRatesBL.Services;

namespace ExchangeRatesApi.Infrastructures.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, AppSettings appSettings)
        {
                services.AddSingleton(appSettings)
                .AddTransient<IApiService, ApiService>()
                .AddTransient<IExchangeRatesService, ExchangeRatesService>();
            
            return services;
        }

    }
}
