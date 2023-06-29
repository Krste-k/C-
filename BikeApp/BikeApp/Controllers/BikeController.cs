using BikeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;

namespace BikeApp.Controllers
{
	public class BikeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult GetAllBikes (LocalDb localDb) 
		{
		    var bikes = LocalDb.bikes;
			return View(bikes);
		}
		public IActionResult GetAllBikesWithHydraulicBreaks()
		{
		   List<Bike> bikes = LocalDb.bikes.Where(bikes => bikes.HasHydrauslic == true).ToList();


			return View(bikes);
		}
		public IActionResult GetBikeById(int? id)
		{

			List<Bike> bikes = LocalDb.bikes.Where(bikes => bikes.Id == id).ToList();
			return View();
		}
		public IActionResult DeleteBike()
		{

			return View();
		}

	}
}
