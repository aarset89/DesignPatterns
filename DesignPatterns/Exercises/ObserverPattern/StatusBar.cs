using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ObserverPattern
{
    public class StatusBar: Observer
    {
        private List<Stock> _stocks = new List<Stock>();
        //private Stock _stock;

        public void AddStock(Stock stock)
        {
            _stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void PriceChanged()
        {
            Console.WriteLine("Price changed - Refresing Status Bar");
            Show();
        }

        public void Show()
        {
            foreach (Stock stock in _stocks)
                Console.WriteLine(stock.toString());
            //Console.WriteLine(_stock.toString());

        }

    }
}
