using System;


namespace PhotoEnhancer
{
    public class SaturationParameters : IParameters
    {
        [ParameterInfo(Name = "Коэффициент увеличения/уменьшения насыщенности",
                    MinValue = 0,
                    MaxValue = 10,
                    DefailtValue = 1,
                    Increment = 0.05)]

        public double Coefficient { get; set; }
    }
}
