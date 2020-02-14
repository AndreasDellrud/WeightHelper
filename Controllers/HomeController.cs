using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeightHelperWeb.Models;

namespace WeightHelperWeb.Controllers
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
            var availableWeights = new List<Weight>{
                new Weight{
                    Value = 50,
                    Available = true
                },
                new Weight{
                    Value = 25,
                    Available = true
                },
                new Weight{
                    Value = 15,
                    Available = true
                },
                new Weight{
                    Value = 10,
                    Available = true
                },
                new Weight{
                    Value = 5,
                    Available = true
                },
                new Weight{
                    Value = 2.5,
                    Available = true
                },
                new Weight{
                    Value = 1.25,
                    Available = true
                }
            };

            var weightSelector = new WeightSelectorViewModel
            {
                AvailableWeights = availableWeights,
                BarWeight = 20,
                TargetWeight = 0
            };

            return View(weightSelector);
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
