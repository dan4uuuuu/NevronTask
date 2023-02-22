using Microsoft.AspNetCore.Mvc;
using NevronTask.Extensions;
using NevronTask.Models;
using System.Reflection;

namespace NevronTask.Controllers
{
    public class NumbersController : Controller
    {
        private readonly int randomMin;
        private readonly int randomMax;
        public NumbersController(IConfiguration congfig)
        {
            IConfigurationSection radnomSection = congfig.GetSection("RandomNumbersRange");
            int.TryParse(radnomSection["Min"], out randomMin);
            int.TryParse(radnomSection["Max"], out randomMax);

        }
        public IActionResult Index()
        {
            return View(PrepareModelForView());
        }
        [HttpGet]
        public IActionResult Add()
        {
            Numbers.AddRandomNumber(randomMin, randomMax);

            return RedirectToAction("Index");
        }
        public IActionResult Sum()
        {
            Numbers.SumElements();

            return RedirectToAction("Index");
        }
        public IActionResult Clear()
        {
            Numbers.Clear();

            return RedirectToAction("Index");
        }
        private NumbersViewModel PrepareModelForView()
        {
            NumbersViewModel viewModel = new NumbersViewModel();
            viewModel.Sum = Numbers.Sum;
            viewModel.Elements = Numbers.Elements;

            return viewModel;
        }
    }
}
