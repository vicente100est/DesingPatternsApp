using System;
using System.Collections.Generic;
using System.Text;
using Tools.Earn.Interface;

namespace Tools.Earn.Class
{
    public abstract class CEarnFactory
    {
        public abstract IEarn GetEarn();
    }
}
