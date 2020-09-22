using System;
using System.Collections.Generic;
using System.Text;
using Builder_Pattern.Interfaces;

namespace Builder_Pattern.Classes
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set => _builder = value;
        }

        public void BuildMinimalViableProduct()
        {
            this._builder.BuildPart1();
        }

        public void BuildFullSpecProduct()
        {
            this._builder.BuildPart1();
            this._builder.BuildPart2();
            this._builder.BuildPart3();
        }
    }
}