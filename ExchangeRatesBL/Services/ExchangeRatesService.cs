using ExchangeRatesBL.Models;
using Newtonsoft.Json;
using System.Xml;

namespace ExchangeRatesBL.Services
{
    public class ExchangeRatesService: IExchangeRatesService
    {
        #region Variables
        private AppSettings _appSettings;
        private IApiService _apiService { get; set; }

        #endregion
        #region Constructor
        public ExchangeRatesService(AppSettings appSettings,IApiService apiService)
        {
            _appSettings = appSettings;
            _apiService = apiService;
        }
        #endregion

        public async Task<List<ExchangeRateResponseDTO>> GetExchangeRates()
        {
            ApiRequest request = new ApiRequest();
            request.EndPoint = _appSettings.ExchangeRates.EndPoint;
            string response = await _apiService.GetHttpRequest(request);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);

            string jsonText = JsonConvert.SerializeXmlNode(xmlDoc);
            var result = JsonConvert.DeserializeObject<ExchangeRatesRes>(jsonText);
            var ratesList = result.ExchangeRatesResponseCollectioDTO.ExchangeRates.ExchangeRateResponseDTO;
            return ratesList;
        }

    }
}
