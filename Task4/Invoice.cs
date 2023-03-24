using System;

/*
 * Потрібно: Створити клас Invoice. 
 * У тілі класу створити три поля int account, string customer, string provider, 
 * які мають бути проініціалізовані один раз 
 * (при створенні екземпляра даного класу) без
 * можливості їхньої подальшої зміни. 
 * У тілі класу створити два закриті поля string article, 
 * int quantity Створити метод розрахунку вартості замовлення 
 * з ПДВ та без ПДВ. Написати програму, 
 * яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
 */
namespace Task4
{
    public class Invoice
    {
        private int _account;
        private string _customer;
        private string _provider;
        private string article;
        private int _quantity = 1;

        public int quantity
        {
            get
            {
                 return _quantity;   
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Negative not alowed");
                }
                _quantity = value;
            }
        }
        public int account
        {
            get { return _account; }
        }
        public string customer
        {
            get;
        }
        public string provider
        {
            get;
        }

        public Invoice(int account, string customer, string provider)
        {
            _account = account;
            _customer = customer;
            _provider = provider;
        }

        public int CalculateCostWithoutVAT()
        {
            return account * quantity;
        }

        public double CalculateCostWithVAT()
        {
            const double VAT = 0.2;
            return CalculateCostWithoutVAT() * (1+VAT);
        }
    }
}