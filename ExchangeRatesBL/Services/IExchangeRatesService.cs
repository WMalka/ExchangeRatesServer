

using ExchangeRatesBL.Models;

namespace ExchangeRatesBL.Services
{
    public interface IExchangeRatesService
    {
        Task<List<ExchangeRateResponseDTO>> GetExchangeRates();
    }
}
