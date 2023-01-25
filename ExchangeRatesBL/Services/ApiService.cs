using ExchangeRatesBL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesBL.Services
{
    public class ApiService : IApiService
    {
        #region Variables
        private static readonly HttpClient client = new HttpClient();
        #endregion

        #region Public Methods
        public async Task<string> GetHttpRequest(ApiRequest req)
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");
            var url = new Uri(req.EndPoint);
            var result = await client.GetAsync(url);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine(resultContent);
            return resultContent;
        }
        #endregion

    }
}
