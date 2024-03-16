using Bybit.Net.Clients;
using System.Linq;
using System.Threading.Tasks;

namespace TradeAPI
{
    class bybitRestClient : IExchangeClient
    {
        private readonly BybitRestClient _restClient;
        public bybitRestClient()
        {
            _restClient = new BybitRestClient();
        }
        public async Task<decimal?> GetLastPriceAsync(string coinPair)
        {
            try
            {
                var tickerResult = await _restClient.V5Api.ExchangeData.GetSpotTickersAsync(coinPair);
                return tickerResult.Data?.List.First().LastPrice;
            }
            catch
            {
                return null;
            }
        }
    }
}
