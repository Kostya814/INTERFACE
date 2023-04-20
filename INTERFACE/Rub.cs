using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    class Rub: ICurrency
    {
        private DateTime _date;
        private int _currency;
        
        public Rub(DateTime date, int currency)
        {
            _date = date;
            _currency = currency;
        }
        public DateTime getDate()
        {
            return _date;
        }
        public int getCurrency()
        {
            return _currency;
        }
        public void ShowCurrency()
        {
            Console.WriteLine($"Курс рубля: {_currency} рублей на 1 доллар на {_date}");
        }
    }
}
