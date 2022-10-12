using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Generator.Interface
{
    public interface IBuilderGenerator
    {
        public void Reset();
        public void SetContext(List<string> content);
    }
}
