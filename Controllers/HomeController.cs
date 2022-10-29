using BMICalculator.Enums;
using BMICalculator.Extension;
using BMICalculator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BMICalculator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RecalculateBmi()
        {
            ViewBag.Bmi = null;
            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public ActionResult BmiForm(Models.BMIData bmiData)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Age = bmiData.Age;
                ViewBag.Weight = bmiData.Weight;
                ViewBag.Gender = bmiData.Gender;
                ViewBag.Height = bmiData.Height;
                ViewBag.Pal = bmiData.Pal;
                ViewBag.Bmi = CalculateBmi(bmiData);
                ViewBag.BasicMetabolism = CalculateBasicMetabolism(bmiData);
                ViewBag.Metabolism = Math.Round(CalculateMetabolism(ViewBag.BasicMetabolism, bmiData.Pal), 0);
            }
            return View("Index");
        }

        private double CalculateMetabolism(double basicMetabolism, PAL pal)
        {
            return basicMetabolism * pal.GetPalValue();
        }

        private double CalculateBasicMetabolism(BMIData bmiData)
        {
            switch (bmiData.Gender)
            {
                case Enums.Gender.FEMALE:
                    return 655 + (9.6 * bmiData.Weight) + (1.85 * bmiData.Height) - (4.7 * bmiData.Age);
                case Enums.Gender.MALE:
                    return 66.5 + (13.7 * bmiData.Weight) +(5 * bmiData.Height) - (6.8 * bmiData.Age);
                default:
                    throw new NotImplementedException();
            }
        }

        private double CalculateBmi(BMIData bmiData)
        {
            return Math.Round(bmiData.Weight / Math.Pow((float)bmiData.Height / 100, 2), 2);
        }
    }
}
