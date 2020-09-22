using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_Pattern
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInformation IdInformation { get; set; }

        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person) this.MemberwiseClone();
            clone.IdInformation=new IdInformation(IdInformation.IdNumber);
            if (Name != null) clone.Name = String.Copy(Name);
            return clone;

        }
    }
}
