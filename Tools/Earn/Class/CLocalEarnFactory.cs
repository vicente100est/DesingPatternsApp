using System;
using System.Collections.Generic;
using System.Text;
using Tools.Earn.Interface;

namespace Tools.Earn.Class
{
    public class CLocalEarnFactory : CEarnFactory
    {
        private decimal _porcentage;

        public CLocalEarnFactory(decimal porcentage)
        {
            this._porcentage = porcentage;
        }

        public override IEarn GetEarn()
        {
            return new CLocalEarn(_porcentage);
        }
    }
}
