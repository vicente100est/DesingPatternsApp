using System;
using System.Collections.Generic;
using System.Text;
using Tools.Earn.Interface;

namespace Tools.Earn.Class
{
    public class CForeignEarnFactory : CEarnFactory
    {
        private decimal _porcentage;
        private decimal _extra;

        public CForeignEarnFactory(decimal porcentage, decimal extra)
        {
            this._porcentage = porcentage;
            this._extra = extra;
        }

        public override IEarn GetEarn()
        {
            return new CForeignEarn(_porcentage, _extra);
        }
    }
}
