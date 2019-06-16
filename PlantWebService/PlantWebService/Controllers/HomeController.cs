using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantWebService.Models;

namespace PlantWebService.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            int a=20, b=30, sum;
            sum = a * b;
            var add = sum;
            int v = Sum(49, 6);int c = Test(33333);
            return "This is summation result = " + sum + c ;
        }
        public int Sum(int a, int b)
        {
            return a + b;
        }
        public int Test(int a)
        {
            return a;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
