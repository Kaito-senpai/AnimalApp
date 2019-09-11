using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalApp.Model
{
    public class Duck: Animal
    {
        public override int Legs()
        {
            return 2;
        }

        public override string MakeNoise()
        {
            return "Quack";
        }

        public string useDuck(Duck duck)
        {
            string duckXML = ToXML(duck, "Duck");

            return duckXML;
        }
    }
}
