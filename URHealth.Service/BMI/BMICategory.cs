using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public static class BMICategory
    {
        public static string GetBMICategory(decimal bmiValue)
        {
            string bmiCategory = "";

            if (bmiValue <= (decimal)18.5)
                bmiCategory = "Under Weight";

            else if (bmiValue > (decimal)18.5 && bmiValue <= (decimal)24.9)
                bmiCategory = "Normal Weight";

            else if (bmiValue > (decimal)25 && bmiValue <= (decimal)29.9)
                bmiCategory = "Over Weight";
            else
                bmiCategory = "Obesity";

            return bmiCategory;
        }
    }
}
