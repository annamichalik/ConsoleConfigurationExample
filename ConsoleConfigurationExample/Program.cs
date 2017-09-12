using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleConfigurationExample
{
    class Program
    {

        public static  List<TrackingElement> GetAllElements()
        {
            return SettingConfiguration.GetConfiguration().TrackingGroups.Cast<TrackingElement>().ToList();
        }

        public static string GetGroupNameForCode(string code)
        {
            var elements = GetAllElements();
            var selectedElement = elements.SingleOrDefault(e => e.Code == code);
            return selectedElement != null ? selectedElement.Name : string.Empty;
        }
        static void Main(string[] args)
        {
            var config = SettingConfiguration.GetConfiguration();
            Console.WriteLine($"Name for code wowtalkShow is {GetGroupNameForCode("wowTalkShow")}");
            Console.WriteLine($"Quantity for OneProduct is {config.OneProduct.Quantity}");
            Console.WriteLine($"Status for OneProduct is {config.OneProduct.SynchStatus}");
            Console.WriteLine($"Quantity for SecondProduct is {config.SecondProduct.Quantity}");
            Console.WriteLine($"Status for SecondProduct is {config.SecondProduct.SynchStatus}");
            Console.ReadKey();
        }
    }
}
