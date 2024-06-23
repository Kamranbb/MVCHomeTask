using Microsoft.AspNetCore.Mvc;
using MVCHomeTask.Models;

namespace MVCHomeTask.Controllers
{
    public class CityController : Controller
    {

        public List<City> Citys { get; set; } = new()
     {
         new() {Id=1,Name="Baku",CountryId=1},
         new() {Id=2,Name="Yevlakh",CountryId=1},
         new() {Id=3,Name="Sumqayit",CountryId=1},
         new() {Id=4,Name="Antalya",CountryId=2},
         new() {Id=5,Name="Istanbul", CountryId = 2},
         new() {Id=6,Name="Diyarbakir", CountryId = 2}
     };

        public IActionResult Index(int? CountryId)
        {
            if (CountryId is null) return View(Citys);
            if (Citys.Exists(c => c.Id == CountryId))
                return View(Citys.FindAll(m => m.CountryId == CountryId));
            return NotFound();
        }
    }
}

