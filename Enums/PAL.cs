using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMICalculator.Enums
{
    public enum PAL
    {
        [Display(Name ="Leżący tryb życia, brak aktywności fizycznej")]
        NOTHING,
        [Display(Name ="Praca siedząca, aktywność fizyczna na niskim poziomie")]
        LOW,
        [Display(Name ="Praca nie fizyczna, trening 2 razy w tygodniu")]
        AVERAGE,
        [Display(Name ="Lekka praca fizyczna, trening 3-4 razy w tygodniu")]
        ABOVE_AVERAGE,
        [Display(Name ="Praca fizyczna, trening 5 razy w tygodniu")]
        HIGH,
        [Display(Name ="Ciężka praca fizyczna, codzienny trening")]
        SUPER_HIGH
    }

}
