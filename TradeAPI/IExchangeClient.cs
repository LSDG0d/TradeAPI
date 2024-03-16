using System.Threading.Tasks;

namespace TradeAPI
{
    interface IExchangeClient
    {
        Task<decimal?> GetLastPriceAsync(string coinPair);
    }
}
