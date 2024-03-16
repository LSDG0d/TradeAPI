using System.Threading.Tasks;
using Bitget.Net.Clients;

namespace TradeAPI
{
    class bitgetRestClient : IExchangeClient
    {
        private readonly BitgetRestClient _restClient;
        public bitgetRestClient()
        {
            _restClient = new BitgetRestClient();
        }
        public async Task<decimal?> GetLastPriceAsync(string coinPair)
        {
            try
            {
                coinPair += "_SPBL";
                var tickerResult = await _restClient.SpotApi.ExchangeData.GetTickerAsync(coinPair);
                return tickerResult.Data?.ClosePrice;
            }
            catch
            {
                return null;
            }
        }
    }
}
