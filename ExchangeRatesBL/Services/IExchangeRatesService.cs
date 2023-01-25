

namespace ExchangeRatesBL.Services
{
    public interface IExchangeRatesService
    {
        Task<string> GetExchangeRates();
    }
}
