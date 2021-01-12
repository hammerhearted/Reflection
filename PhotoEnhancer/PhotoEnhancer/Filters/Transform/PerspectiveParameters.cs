using System;


namespace PhotoEnhancer
{
    public class PerspectiveParameters : IParameters
    {
        [ParameterInfo(Name = "Сужение в %", MinValue = 0, MaxValue = 100, DefailtValue = 0, Increment = 5)]
        public double N { get; set; }
    }
}

