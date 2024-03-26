using Microsoft.AspNetCore.Mvc;
using LabFourCar.Models; // Ensure this using directive matches your project structure

namespace LabFourCar.Controllers
{
    public class CarController : Controller
    {
        // Action method that returns a view displaying a car's details.
        public IActionResult Index()
        {
            // Creating a new Car object with hard-coded values.
            var car = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                EngineSize = "1.8L",
                EngineType = "Hybrid"
            };

            // Passing the car object to the view.
            return View(car);
        }
    }
}
