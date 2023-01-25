using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRatesBL.Models
{
    public class ApiRequest
    {
        // HttpRequest
        public string EndPoint { get; set; }
        public string? ContentType { get; set; }
        public string? Body { get; set; }

        public ApiRequest()
        {

        }
    }

}
