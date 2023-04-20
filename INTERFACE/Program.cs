using INTERFACE;

public class Program
{
    static void Main(string[] args)
    {
        ICurrency currency = new Dollar(DateTime.Now,100);
        ICurrency currency1 = new Rub(DateTime.Now, 60); 
        Comparator comparator = new  Comparator((Dollar)currency,(Rub)currency1);
        comparator.Count();
    }
}

