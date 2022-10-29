using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMICalculator.Models
{
    public class BMIData
    {
        [Required]
        public Gender Gender { get; set; }
        [Required]
        [Range(1, 150)]
        public int Age { get; set; }
        [Required]
        [Range(1, 300)]
        public double Weight { get; set; }
        [Required]
        [Range(1,300)]
        public int Height { get; set; }
        [Required]
        public PAL Pal { get; set; }
    }
}
