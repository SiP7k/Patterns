using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }
}
