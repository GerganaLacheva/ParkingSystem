using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data.Models;
using System.Linq;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);
            return Redirect("/");   //redirect to homepage
        }

        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            Car car = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);    //Default value=null;
            DataAccess.Cars.Remove(car);
            return Redirect("/");
        }
    }
}
