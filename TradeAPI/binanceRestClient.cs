using Binance.Net.Clients;
using System.Threading.Tasks;

namespace TradeAPI
{
    class binanceRestClient: IExchangeClient
    {
        private readonly BinanceRestClient _restClient;

        public binanceRestClient()
        {
            _restClient = new BinanceRestClient();
        }


        public async Task<decimal?> GetLastPriceAsync(string coinPair)
        {
            try
            {
                var tickerResult = await _restClient.SpotApi.ExchangeData.GetTickerAsync(coinPair);
                return tickerResult.Data?.LastPrice;
            }
            catch
            {
                return null;
            }
        }
    }
}
