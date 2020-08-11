using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoneyExchangeRatePkg
{
    public interface IUSD_CLP_ExchangeRateFeed
    {
        int GetActualUSDValue();
    }
}