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
        [Required(ErrorMessage = "Pole płeć jest wymagane")]
        public Gender? Gender { get; set; }
        [Required(ErrorMessage = "Pole wiek jest wymagane")]
        [Range(1, 150, ErrorMessage ="Pole wiek musi być między 1 a 150")]
        public int? Age { get; set; }
        [Required(ErrorMessage = "Pole waga jest wymagane")]
        [Range(1, 300, ErrorMessage = "Pole waga musi być między 1 a 300")]
        public double? Weight { get; set; }
        [Required(ErrorMessage = "Pole wzrost jest wymagane")]
        [Range(1,300, ErrorMessage = "Pole wzrost musi być między 1 a 300")]
        public int? Height { get; set; }
        [Required(ErrorMessage = "Pole PAL jest wymagane")]
        public PAL? Pal { get; set; }
    }
}
