using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    internal interface IAccount
    {
        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest() {}
    }
}
