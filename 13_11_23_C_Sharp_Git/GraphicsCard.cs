using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13_11_23_C_Sharp_Git
{
    public class GraphicsCard : ITemperatureControl
    {
        public string Name { get; set; }
        public float Temperature { get; set; }

        public GraphicsCard(string name, float temperature) 
        {
            Name = name;
            Temperature = temperature;
        }
        public void MonitorTemperature()
        {
            Console.WriteLine($"Мониторинг температуры процессора {Name}: {Temperature}°C");
        }
        public void CoolDown()
        {
            Console.WriteLine($"Охлаждение процессора{Name}");
        }
    }
}
