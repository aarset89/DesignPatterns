using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercises.ObserverPattern
{
    public class Stock : Subject
    {
        private string _symbol;
        private float _price;

        public Stock(string symbol, float price)
        {
            _symbol = symbol;
            _price = price;
        }

        public float GetPrice()
        {
            return _price;
        }

        public void SetPrice(float price)
        {
            _price = price;
            NotifyObservers();
        }

        public string toString()
        {
            return "Stock{" +
                    "symbol='" + _symbol + '\'' +
                    ", price=" + _price +
                    '}';
        }
    }
}
