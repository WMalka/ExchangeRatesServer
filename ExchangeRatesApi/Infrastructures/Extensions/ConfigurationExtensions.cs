using ExchangeRatesBL.Models;

namespace ExchangeRatesApi.Infrastructures.Extensions
{
    public static class ConfigurationExtensions
    {
        
        public static AppSettings GetApplicationSettings(IServiceCollection services, IConfiguration configuration)
        {
            var appSettingsConfig = configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsConfig);
            return appSettingsConfig.Get<AppSettings>();
        }
        
    }
}
