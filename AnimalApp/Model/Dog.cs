using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Model
{
    public class Dog: Animal
    {
        public override int Legs()
        {
            return 4;
        }

        public override string MakeNoise()
        {
            return "Woof";
        }

        public string useDog(Dog dog)
        {
            string dogXML = ToXML(dog, "Dog");

            return dogXML;
        }
    }
}
