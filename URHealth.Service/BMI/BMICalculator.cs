using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public class BMICalculator : ICalculate
    {
        private float _height;
        private float _weight;
        public float HeightInMeters
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

        public float WeightInKg
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

        public float Calculate()
        {
            float heightsquare= (_height * _height);
            return (_weight / heightsquare);
        }
    }
}
