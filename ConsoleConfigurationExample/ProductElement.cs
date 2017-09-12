using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationExample
{
    public class ProductElement : ConfigurationElement
    {

     
        [ConfigurationProperty("Qty", IsRequired = false)]
        public int Quantity
        {
            get
            {
                return (int)this["Qty"];
            }
            set
            {
                this["Qty"] = value;
            }
        }



        [ConfigurationProperty("SynchStatus", IsRequired = true)]
        public string SynchStatus
        {
            get
            {
                return this["SynchStatus"] as string;
            }
            set
            {
                this["SynchStatus"] = value;
            }
        }
    }
}
