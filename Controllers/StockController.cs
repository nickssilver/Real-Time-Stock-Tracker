using Microsoft.AspNetCore.Mvc;
using RealTimeStockTracker.Models;
using RealTimeStockTracker.Services;

namespace RealTimeStockTracker.Controllers
{
    public class StockController : Controller
    {
        private readonly StockService _stockService;

        public StockController(StockService stockService)
        {
            _stockService = stockService;
        }

        public async Task<IActionResult> Index(string symbol = "AAPL")
        {
            var stockData = await _stockService.GetRealTimeStockData(symbol);
            return View(stockData);
        }

        public IActionResult Alerts()
        {
            // Logic for handling price alerts
            return View();
        }

        public IActionResult Portfolio()
        {
            // Logic for handling portfolio management
            return View();
        }
    }
}
