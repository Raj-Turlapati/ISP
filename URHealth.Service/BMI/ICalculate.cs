using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public interface ICalculate
    {
        decimal WeightInKg{get; set;}
        decimal HeightInMeters { get; set;}
        decimal Calculate();
    }
}
