using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BalancingARazor.Pages
{
    public class TemperatureModel : PageModel
    {
        public string convMethod { get; set; }
        public string convTemp { get; set; }
        double newTemp = 0;
        string end = "";

        [BindProperty]
        public int TempConvOption { get; set; }
        [BindProperty]
        public double Temp { get; set; }

        public void OnGet()
        {
            convMethod = "Welcome to the temperature converter.";
        }

        public void OnPost()
        {  
            if (TempConvOption == 1)
            {
                //F2C: (32°F − 32) × 5 / 9 = 0°C
                newTemp = ((Temp - 32) * 5 / 9);
                end = " degrees Celcius";
            }
            if(TempConvOption == 2)
            {
                //C2F: (32°C × 9 / 5) +32 = 89.6°F
                newTemp = ((Temp * 9 / 5) + 32);
                end = " degrees Fahrenheit";
            }
            newTemp = Math.Round(newTemp, 2);
            convTemp = "Result: " + newTemp.ToString() + end;
        }
    }
}