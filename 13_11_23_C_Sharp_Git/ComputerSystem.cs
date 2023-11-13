using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_23_C_Sharp_Git
{
    public class ComputerSystem
    {
        public List<ITemperatureControl> Components { get; set; } = new List<ITemperatureControl>();
        public ComputerSystem() 
        { 
            Components = new List<ITemperatureControl>();
        }

        public void RegistraitComponent(ITemperatureControl component)
        {
            Components.Add(component);
        }

        public void SetTemperatureForAllComponents(float coollingTemperature)
        {
            foreach (var component in Components)
            {
                if(component is Cooler <ITemperatureControl>)
                {
                    var cooler = (Cooler<ITemperatureControl>)component;
                    cooler.SetCoolingTemperature(coollingTemperature);
                }
            }
        }

        public void ShowTemperaturForAllComponents()
        {
            foreach(var component in Components)
            {
                component.MonitorTemperature();
            }
        }
        /*
         Метод OrderByDescending в C# используется для сортировки коллекции в обратном порядке.
        Он принимает делегат, который определяет порядок сортировки, и возвращает отсортированную коллекцию.

        Например:
        var numbers = new[] { 1, 3, 5, 7, 9 };
        var sortedNumbers = numbers.OrderByDescending(n => n);
        foreach (var number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
        // Этот код выведет числа в порядке от большего к меньшему:
        // 9
        // 7
        // 5
        // 3
        // 1
         */
        //public ITemperatureControl GetTemperatureMaxTemperature()
        //{
        //    return Components.OrderByDescending(n => n.Temperaturee).FirstOrDefault();
        //}
    }
}
