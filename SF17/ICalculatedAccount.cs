using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF17
{
    public interface ICalculatedAccount
    {
        public double Balance { get; set; }

        // процентная ставка
        public double Interest { get; set; }
        public void CalculateInterest();
    }
}
