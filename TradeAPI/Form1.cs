using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradeAPI
{
    public partial class Form1 : Form
    {
        private readonly IExchangeClient _binanceClient;
        private readonly IExchangeClient _bybitClient;
        private readonly IExchangeClient _bitgetClient;
        private readonly IExchangeClient _kucoinClient;
        public Form1()
        {
            InitializeComponent();
            _binanceClient = new binanceRestClient();
            _bybitClient = new bybitRestClient();
            _bitgetClient = new bitgetRestClient();
            _kucoinClient = new kucoinRestClient();
        }

        private async void timerUpdate_Tick(object sender, EventArgs e)
        {
            await GetPricesAsync();
        }
        private async Task GetPricesAsync()
        {
            var coinPair = comboBoxCoin.Text;
            //Получаем значения сколько бабок уйдёт за монетку
            var binancePrice = await _binanceClient.GetLastPriceAsync(coinPair);
            var bybitPrice = await _bybitClient.GetLastPriceAsync(coinPair);
            var bitgetPrice = await _bitgetClient.GetLastPriceAsync(coinPair);
            var kucoinPrice = await _kucoinClient.GetLastPriceAsync(coinPair);
            //Обновляем тектовые новыми значениями
            labelBinance.Text = $"Binance: {Convert.ToString(binancePrice ?? 0m)}";
            labelBybit.Text = $"Bybit: {Convert.ToString(bybitPrice ?? 0m)}";
            labelBitget.Text = $"Bitget: {Convert.ToString(bitgetPrice ?? 0m)}";
            labelKucoin.Text = $"Kucoin: {Convert.ToString(kucoinPrice ?? 0m)}";
        }
    }
}
