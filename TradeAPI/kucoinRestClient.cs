using Kucoin.Net.Clients;
using System.Threading.Tasks;

namespace TradeAPI
{
    class kucoinRestClient : IExchangeClient
    {
        private readonly KucoinRestClient _restClient;
        public kucoinRestClient()
        {
            _restClient = new KucoinRestClient();
        }
        public async Task<decimal?> GetLastPriceAsync(string coinPair)
        {
            switch (coinPair)
            {
                case "BTCUSDT":
                    coinPair = "BTC-USDT";
                    break;
                case "ETHUSDT":
                    coinPair = "ETH-USDT";
                    break;
                case "SOLUSDT":
                    coinPair = "SOL-USDT";
                    break;
                case "FDUSDUSDT":
                    coinPair = "FDUSD-USDT";
                    break;
                case "ETHUSDC":
                    coinPair = "ETH-USDC";
                    break;
                case "USDCUSDT":
                    coinPair = "USDC-USDT";
                    break;
            }
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
