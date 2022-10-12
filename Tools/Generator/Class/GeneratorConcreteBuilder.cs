using System;
using System.Collections.Generic;
using System.Text;
using Tools.Generator.Interface;
using static Tools.Generator.Interface.IBuilderGenerator;

namespace Tools.Generator.Class
{
    public class GeneratorConcreteBuilder : IBuilderGenerator
    {
        private Generator _generator;
        public GeneratorConcreteBuilder()
        {
            Reset();
        }
        public void Reset() => _generator = new Generator();
        public void SetContet(List<string> content) => _generator.Content = content;
        public void SetPath(string path) => _generator.Path = path;
        public void SetFormat(TypeFormat format) => _generator.Format = format;
        public void SetCharacter(TypeCharacter character) => _generator.Character = character;

        public Generator GetGenerator() => _generator;
    }
}
