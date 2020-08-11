using MoneyExchangeRatePkg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTestProject
{
    public class Calculator : IcalculatorInterface
    {
        private IUSD_CLP_ExchangeRateFeed _feed;
        public Calculator(IUSD_CLP_ExchangeRateFeed feed)
        {
            this._feed = feed;
        }
        public int add(int a, int b)
        {
            return a + b;
        }

        public int multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int divide(int param1, int param2)
        {
           return param1 / param2;
        }

        public int ConvertUSDtoCLP(int unit)
        {
            return unit * this._feed.GetActualUSDValue();
        }

      

    }
}
