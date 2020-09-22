using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Pattern.Classes
{
    public class Product
    {
        public List<object> Parts;

        public Product()
        {
            Parts = new List<object>();
        }
        public void Add(string part)
        {
            this.Parts.Add(part);
        }

        public string PartsList()
        {
            string part = string.Empty;
            for (int i = 0; i < this.Parts.Count; i++)
            {
                part += this.Parts[i] + ", ";
            }

            part = part.Remove(part.Length - 2); // remove comma and space at the end of the string
            return "Product parts: " + part + "\n";
        }

    }
}
