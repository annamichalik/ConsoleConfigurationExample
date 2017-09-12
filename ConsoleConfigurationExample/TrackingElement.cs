using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationExample
{
    public class TrackingElement : ConfigurationElement
    {
        public TrackingElement()
        {
        }
        public TrackingElement(string name, string code)
        {
            Name = name;
            Code = code;
        }

        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get { return (String) this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("code", IsRequired = true)]
        public string Code
        {
            get { return (string) this["code"]; }
            set { this["code"] = value; }
        }
    }
}
