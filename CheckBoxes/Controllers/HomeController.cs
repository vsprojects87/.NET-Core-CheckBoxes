using CheckBoxes.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckBoxes.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //public IActionResult Index()
        //{
        //    var model = new ViewModel()
        //    {
        //        AcceptTerms = false,
        //        Text = "I accept the terms"
        //    };
        //    return View(model);
        //}

        public IActionResult Index()
        {
            var model = new ViewModel()
            {
               CheckBoxes = new List<CheckBoxOption>
               {
                   new CheckBoxOption {
                        IsChecked=true,
                        Text="Cricket",
                        Value="Cricket",
                   },
                   new CheckBoxOption {
                        IsChecked=false,
                        Text="Football",
                        Value="Football",
                   },
                   new CheckBoxOption {
                        IsChecked=false,
                        Text="Tennis",
                        Value="Tennis",
                   }
               }
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(ViewModel d)
        {
            return View();
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
