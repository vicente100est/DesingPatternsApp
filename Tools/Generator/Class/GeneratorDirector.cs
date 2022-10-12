using System;
using System.Collections.Generic;
using System.Text;
using Tools.Generator.Interface;
using static Tools.Generator.Interface.IBuilderGenerator;

namespace Tools.Generator.Class
{
    public class GeneratorDirector
    {
        private IBuilderGenerator _builderGenerator;
        public GeneratorDirector(IBuilderGenerator generatorBuilder)
        {
            SetBuilder(generatorBuilder);
        }
        public void SetBuilder(IBuilderGenerator builderGenerator) => this._builderGenerator = builderGenerator;

        public void CreateSimpleJsonGenerator(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContet(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Json);
        }

        public void CreateSimplePiPEgENERATOR(List<string> content, string path)
        {
            _builderGenerator.Reset();
            _builderGenerator.SetContet(content);
            _builderGenerator.SetPath(path);
            _builderGenerator.SetFormat(TypeFormat.Pipes);
            _builderGenerator.SetCharacter(TypeCharacter.Uppercase);
        }
    }
}
