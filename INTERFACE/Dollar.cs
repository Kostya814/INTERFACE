namespace INTERFACE
{
    class Dollar:ICurrency
    {
        private DateTime _date;
        private int _currency;
        public Dollar(DateTime date, int currency)
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
             Console.WriteLine($"Курс доллара: {_currency} Долларов на 1 рубль на {_date}");
        }
    }
}
