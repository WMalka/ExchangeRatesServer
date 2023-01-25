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
        public async Task<string> Get()
{
            string exchangeRatesList = await _exchangeRateService.GetExchangeRates();
            return exchangeRatesList;
        }
        #endregion

        
    }
}