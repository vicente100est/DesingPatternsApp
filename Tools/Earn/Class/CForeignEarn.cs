using System;
using System.Collections.Generic;
using System.Text;
using Tools.Earn.Interface;

namespace Tools.Earn.Class
{
    public class CForeignEarn : IEarn
    {
        private decimal _porcentage;
        private decimal _extra;

        public CForeignEarn(decimal porcentage, decimal extra)
        {
            this._porcentage = porcentage;
            this._extra = extra;
        }

        public decimal Earn(decimal amount)
        {
            return (amount * _porcentage) + _extra;
        }
    }
}
