using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTERFACE
{
    class Comparator
    {
        private Dollar _dollar;
        private Rub _rub;
        public Comparator(Dollar dollar, Rub rub)
        {
            _dollar = dollar;
            _rub = rub;
        }
        public void Count()
        {
           double a = _dollar.getCurrency()/30;
           double b = _rub.getCurrency()/30/ a;
           Console.WriteLine($"{a} Курс рубля к доллару  {Math.Round(b,2)} Курс доллара к рублю."); 
        }
    }
}
