using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BalancingARazor.Pages
{
    public class MassModel : PageModel
    {
        public string convMethod { get; set; }
        public string convMass { get; set; }
        double newMass = 0;
        string end = "";

        [BindProperty]
        public int MassConvOption { get; set; }
        [BindProperty]
        public double Mass { get; set; }
        public void OnGet()
        {
            convMethod = "Welcome to the mass converter.";
        }

        public void OnPost()
        {
            if(MassConvOption == 1)
            {
                //Pounds to Ounces: multiply the mass value by 16
                newMass = Mass * 16;
                end = " ounces";
            }
            if(MassConvOption == 2)
            {
                //Ounces to Pounds: divide the mass value by 16
                newMass = Mass / 16;
                end = " pounds";
            }
            if(MassConvOption == 3)
            {
                //Grams to Pounds: divide the mass value by 454
                newMass = Mass / 454;
                end = " pounds";

            }
            if(MassConvOption == 4)
            {
                //Milligrams to Pounds: divide the mass value by 453592
                newMass = Mass / 453492;
                end = " pounds";
            }
            newMass = Math.Round(newMass, 2);
            convMass = "Result: " + newMass.ToString() + end;
        }
    }
}