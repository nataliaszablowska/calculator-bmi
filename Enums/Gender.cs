using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMICalculator.Enums
{
    public enum Gender
    {
        [Display(Name ="Kobieta")]
        FEMALE,
        [Display(Name ="Mężczyzna")]
        MALE
    }
}
