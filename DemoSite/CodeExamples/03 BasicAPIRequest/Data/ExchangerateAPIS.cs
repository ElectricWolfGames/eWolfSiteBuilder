using APITests;
using APITests.Model;
using Newtonsoft.Json;

// Demo API request
// https://www.exchangerate-api.com/docs/c-sharp-currency-api

namespace APIs
{
    public class ExchangeEateAPIS
    {
        public void MakeRequest()
        {
            string urlString = $"https://v6.exchangerate-api.com/v6/{Consts.APIKey}/latest/USD";
            using (var webClient = new System.Net.WebClient())
            {
                var json = webClient.DownloadString(urlString);
                var exchangerateRates = JsonConvert.DeserializeObject<ExchangerateRateResponse>(json);

                Console.WriteLine($"BaseCode: {exchangerateRates.base_code}");
                Console.WriteLine($"GBP: {exchangerateRates.conversion_rates.GBP}");
                Console.WriteLine($"EUR: {exchangerateRates.conversion_rates.EUR}");
            }
        }
    }
}