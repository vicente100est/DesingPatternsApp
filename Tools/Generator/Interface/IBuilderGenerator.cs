using System;
using System.Collections.Generic;
using System.Text;

namespace Tools.Generator.Interface
{
    public interface IBuilderGenerator
    {
        public enum TypeFormat
        {
            Json,
            Pipes
        }
        public enum TypeCharacter
        {
            Normal,
            Uppercase,
            Lowercase
        }
        public void Reset();
        public void SetContet(List<string> content);
        public void SetPath(string path);
        public void SetFormat(TypeFormat format);
        public void SetCharacter(TypeCharacter character = TypeCharacter.Normal);
    }
}
