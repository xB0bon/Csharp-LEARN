using System;

namespace Coding.Exercise
{
    public delegate void StockPriceChangedHandler(string message);

    public class Stock
    {
        public event StockPriceChangedHandler OnStockPriceChanged;

        private decimal _price;
        private decimal _threshold;

        public decimal Price
        {
            get => _price;
            set
            {
                _price = value;
                if (_price < _threshold)
                {
                    RaiseStockPriceChangedEvent("Stock price is below threshold!");
                }
                else
                {
                    Console.WriteLine("No alert for " + _price);
                }
                
            }
        }


        public decimal Threshold
        {
            get => _threshold;
            set
            {
                _threshold = value;
            }
        }
        public void RaiseStockPriceChangedEvent(string message)
        {
            OnStockPriceChanged?.Invoke(message);
        }
    }

    public class StockAlert
    {
        public void OnStockPriceChanged(string message)
        {
            Console.WriteLine("Stock Alert: " + message);
        }
    }

    public class Exercise
    {
        public void TestStockPriceAlerts()
        {
            // TODO: Implement the stock price alert test
            Stock stock = new Stock();
            StockAlert stockAlert = new StockAlert();
            
            stock.OnStockPriceChanged += stockAlert.OnStockPriceChanged;
            
            stock.Threshold = 150;
            stock.Price = 130;
            stock.Price = 110;
        }
    }
}