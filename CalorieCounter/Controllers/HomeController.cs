using CalorieCounter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieCounter.Controllers
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
        [Route("{search}")]
        public IActionResult Index(string search,int page)
        {
            List<Food> foods = GetFoods().Where(x => x.Display_Name.ToLower().Contains(search.ToLower())).ToList();
            IndexModel model = new IndexModel() { SearchResults = foods};
            return View(model);
        }
        [Route("Food/{foodcode}")]
        public IActionResult Food(int foodcode)
        {
            var food = GetFoods().Single(x => Convert.ToInt32(x.Food_Code) == foodcode);
            return View(food);
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
        private List<Food> GetFoods()
        {
            List<Food> foods = new List<Food>();
            var streamreader = new StreamReader("Foods.json");
            using (streamreader)
            {
                foods = JsonConvert.DeserializeObject<List<Food>>(streamreader.ReadToEnd());
            }
            return foods;
        }
    }
}
