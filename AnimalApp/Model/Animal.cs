using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AnimalApp.Model
{
    public abstract class Animal
    {
        public abstract int Legs();
        public abstract string MakeNoise();

        public string ToXML(Animal objAnimal, string animal)
        {
            string result;

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", String.Empty);

            doc.PrependChild(dec);

            XmlElement baseElem = doc.CreateElement(animal);
            doc.AppendChild(baseElem);
            XmlElement elem = null;

            Type idType = objAnimal.GetType();

            foreach (MethodInfo propInfo in idType.GetMethods())
            {
                object val = propInfo.ReturnParameter.ParameterType;
                elem = doc.CreateElement(propInfo.Name);
                elem.InnerText = val.ToString();
                baseElem.AppendChild(elem);
            }

            result = baseElem.PreviousSibling.OuterXml.ToString() + Environment.NewLine + baseElem.OuterXml.ToString();
            
            return result;
        }
    }
}
