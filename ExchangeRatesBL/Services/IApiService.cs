using ExchangeRatesBL.Models;

namespace ExchangeRatesBL.Services
{
    public interface IApiService
    {
        Task<string> GetHttpRequest(ApiRequest req);
    }
}
