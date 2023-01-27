using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ExchangeRatesBL.Models
{
    public class ExchangeRateResponseDTO
    {

        [JsonPropertyName("CurrentChange")]
        public double CurrentChange { get; set; }

        [JsonPropertyName("CurrentExchangeRate")]
        public double CurrentExchangeRate { get; set; }

        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("LastUpdate")]
        public DateTime LastUpdate { get; set; }

        [JsonPropertyName("Unit")]
        public int Unit { get; set; }
    }
}
