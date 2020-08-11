using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqTestProject
{
    public interface IcalculatorInterface
    {
        int add(int a, int b);
        int multiply(int a, int b);
        int divide(int param1, int param2);
        int ConvertUSDtoCLP(int unit);

    }
}
