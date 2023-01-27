using ExchangeRatesBL.Models;
using ExchangeRatesBL.Services;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeRatesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExchangeRatesController : ControllerBase
    {
        #region Variables
        private readonly ILogger<ExchangeRatesController> _logger;
        private IExchangeRatesService _exchangeRateService;
        #endregion
        #region Constructor
        public ExchangeRatesController(ILogger<ExchangeRatesController> logger, IExchangeRatesService exchangeRatesService)
        {
            _logger = logger;
            _exchangeRateService = exchangeRatesService;
        }
        #endregion

        #region Http Methods
        [HttpGet]
        public async Task<List<ExchangeRateResponseDTO>> Get()
{
            var exchangeRatesList = await _exchangeRateService.GetExchangeRates();
            exchangeRatesList.RemoveAll(rate => rate.CurrentChange < rate.CurrentExchangeRate);//removes all positive exchange rates
            return exchangeRatesList;//returns only exchange rates which are less then the current rate
        }
        #endregion

        
    }
}