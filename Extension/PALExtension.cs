using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMICalculator.Extension
{
    public static class PALExtension
    {
        public static double GetPalValue(this PAL palValue)
        {
            switch (palValue)
            {
                case PAL.NOTHING:
                    return 1;
                case PAL.LOW:
                    return 1.2;
                case PAL.AVERAGE:
                    return 1.4;
                case PAL.ABOVE_AVERAGE:
                    return 1.6;
                case PAL.HIGH:
                    return 1.8;
                case PAL.SUPER_HIGH:
                    return 2;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
