using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public class BMICalculator : ICalculate
    {
        private decimal _height;
        private decimal _weight;
        public decimal HeightInMeters
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;    
            }
        }

        public decimal WeightInKg
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public decimal Calculate()
        {
            decimal heightsquare= (_height * _height);
            return (_weight / heightsquare);
        }
    }
}
