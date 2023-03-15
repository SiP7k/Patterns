﻿using System.Security.Principal;

namespace Patterns
{
    public class DefaultAccount : IAccount
    {

        public double Balance { get; set; }

        public double Interest { get; set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}