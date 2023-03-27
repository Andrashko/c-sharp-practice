using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Invoice
    {
        private int _account;
        private string _customer;
        private string _provider;
        private string _article;
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
                    throw new Exception("Введено не вiрне число");
                }
                _quantity = value;
            }
        }

        public string article
        {
            get { return _article; }
        }
        public int account
        {
            get { return _account; }
        }
        public string customer
        {
            get { return _customer; }
        }
        public string provider
        {
            get { return _provider; }
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
            return CalculateCostWithoutVAT() * (1 + VAT);
        }
    }
}
