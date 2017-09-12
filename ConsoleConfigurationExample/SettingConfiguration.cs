using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationExample
{
    public class SettingConfiguration : ConfigurationSection
    {
        public static SettingConfiguration GetConfiguration()
        {
            SettingConfiguration configuration =
                ConfigurationManager
                .GetSection("settingSection")
                as SettingConfiguration;

            if (configuration != null)
                return configuration;

            return new SettingConfiguration();
        }
        [ConfigurationProperty("groups")]
        public ElementCollection TrackingGroups
        {
            get
            { return (ElementCollection)this["groups"]; }
            set
            { this["groups"] = value; }
        }
        [ConfigurationProperty("OneProduct")]
        public ProductElement OneProduct
        {
            get
            {
                return (ProductElement)this["OneProduct"];
            }
            set
            {
                this["OneProduct"] = value;
            }
        }


        [ConfigurationProperty("SecondProduct")]
        public ProductElement SecondProduct
        {
            get
            {
                return (ProductElement)this["SecondProduct"];
            }
            set
            {
                this["SecondProduct"] = value;
            }
        }
    }
}
