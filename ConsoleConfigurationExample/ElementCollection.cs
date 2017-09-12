using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationExample
{
    public class ElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new TrackingElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((TrackingElement)element).Name;
        }


    }
}
