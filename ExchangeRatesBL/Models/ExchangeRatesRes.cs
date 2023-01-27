using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeRatesBL.Models
{
    public class ExchangeRatesRes
    {
        [JsonPropertyName("ExchangeRatesResponseCollectioDTO")]
        public ExchangeRatesResponseCollectioDTO ExchangeRatesResponseCollectioDTO { get; set; }

    }
}
