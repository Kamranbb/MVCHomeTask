using Microsoft.AspNetCore.Mvc;
using MVCHomeTask.Models;


namespace MVCHomeTask.Controllers
{
    public class HomeController : Controller
    {
        public List<Country> Countries { get; set; } = new()
        {
            new() {Id=1,Name="Azerbaycan"},
            new() {Id=2,Name="Turkiye"}

        };
        public IActionResult Index()
        {
            return View(Countries);
        }
    }
}
