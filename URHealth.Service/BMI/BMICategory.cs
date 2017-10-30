using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URHealth.Service.BMI
{
    public static class BMICategory
    {
        public static string GetBMICategory(float bmiValue)
        {
            string bmiCategory = "";

            if (bmiValue <= 18.5f)
                bmiCategory = "Under Weight";

            else if (bmiValue > 18.5f && bmiValue <= 24.9f)
                bmiCategory = "Normal Weight";

            else if (bmiValue > 25f && bmiValue <= 29.9f)
                bmiCategory = "Over Weight";
            else
                bmiCategory = "Obesity";

            return bmiCategory;
        }
    }
}
