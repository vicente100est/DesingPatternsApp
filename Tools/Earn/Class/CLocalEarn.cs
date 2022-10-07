using System;
using System.Collections.Generic;
using System.Text;
using Tools.Earn.Interface;

namespace Tools.Earn.Class
{
    public class CLocalEarn : IEarn
    {
        private decimal _porcentage;

        public CLocalEarn(decimal porcentage)
        {
            this._porcentage = porcentage;
        }

        public decimal Earn(decimal amount)
        {
            return amount * _porcentage;
        }
    }
}
