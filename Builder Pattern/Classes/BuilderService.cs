using System;
using System.Collections.Generic;
using System.Text;
using Builder_Pattern.Interfaces;

namespace Builder_Pattern.Classes
{
    public class BuilderService: IBuilder
    {
        private Product _product;

        public BuilderService()
        {
            _product = new Product();
        }

        public void BuildPart1()
        {
            this._product.Add("Part 1");
        }

        public void BuildPart2()
        {
            this._product.Add("Part 2");
        }

        public void BuildPart3()
        {
            this._product.Add("Part 3");
        }

        public void Reset()
        {
            this._product=new Product();
        }

        public Product GetProduct()
        {
            Product result = this._product;
            this.Reset(); // call reset method for returning the product and then don't call the reset function explicitly.
                          // this behaviour can be changed. we can call reset independently too.  
            return result;
        }
    }
}
