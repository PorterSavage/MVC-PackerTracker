using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
    public class TripGearController : Controller
    {
        [HttpGet("/tripgear/new")]
        public ActionResult New(string destination, string clothes, string food, int money)
        {
            TripGear newTripGear = new TripGear(destination, clothes, food, money);
            return View(newTripGear);
        }

    }
}