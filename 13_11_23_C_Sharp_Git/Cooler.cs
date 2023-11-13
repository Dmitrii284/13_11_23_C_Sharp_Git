using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_11_23_C_Sharp_Git
{
    public class Cooler<T> : ITemperatureControl where T : ITemperatureControl
    {
        public readonly T component;
        public float coolingTemperature;

        public Cooler(T component)
        {
            this.component = component;
        }
        public void SetCoolingTemperature(float coolingTemperature)
        {
            this.coolingTemperature = coolingTemperature;
        }

        public void MonitorTemperature()
        {
            component.MonitorTemperature();
            if (this.coolingTemperature > coolingTemperature)
            {
                this.CoolDown();
            }
        }

        //public ITemperatureControl GetTemperatureMaxTemperature()
        //{
        //    return component.OrderByDescending(n => n.T).FirstOrDefault();
        //}

        public void CoolDown()
        {
            this.CoolDown();
        }
    }
}
