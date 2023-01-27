using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeRatesBL.Models
{
    public class ExchangeRatesResponseCollectioDTO
    {
        [JsonPropertyName("ExchangeRates")]
        public ExchangeRates ExchangeRates { get; set; }

    }
}
