using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Converter
    {
        private double usdRate;
        private double eurRate;
        private double plnRate;
        private double countForChange;
       


        public double USD
        {
            // converter.USD = 8.0; в програмі викликає нескінченну рекурсію.
            set => USD = value;

            get => usdRate;
        }

        public double EUR
        {
            set => EUR = value;

            get => eurRate;
        }

        public double PLN
        {
            set => PLN = value;

            get => plnRate;
        }

        public double CountForChange
        {
            get => countForChange;
        }

        public Converter(double USD, double EUR, double PLN)
        {
            this.usdRate = USD;
            this.eurRate = EUR;
            this.plnRate = PLN;
        }
        // дії навпаки
        // чому приймає аргумент і ніяк не взаємодіє з  public double CountForChange
        public double ConvertUAHtoUSD(double countForChange)
        {
            return countForChange * USD;
        }

        public double ConvertUAHtoEUR(double countForChange)
        {
            return countForChange * EUR;
        }

        public double ConvertUAHtoPLN(double countForChange)
        {
            return countForChange * PLN;
        }

        public double ConvertUSDtoUAH(double countForChange)
        {
            return countForChange / USD;
        }

        public double ConvertEURtoUAH(double countForChange)
        {
            return countForChange / EUR;
        }

        public double ConvertPLNtoUAH(double countForChange)
        {
            return countForChange / PLN;
        }

        
    }
}
