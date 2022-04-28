using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF17
{
    public static class Calculator
    {
        public static void CalculateInterest(ICalculatedAccount account)
        {
           account.CalculateInterest();
        }
    }
}
