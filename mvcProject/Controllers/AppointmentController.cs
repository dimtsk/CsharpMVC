using Microsoft.AspNetCore.Mvc;
using System;

namespace mvcProject.Controllers
{
    public class AppointmentController : Controller
    {
        //https://localhost:44322/appointment
        public IActionResult Index()
        {
           /* string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);*/
            return View();

        }
        public IActionResult Detail()
        {
            return Ok("The id is : {1}");
        }
        public IActionResult Details(int id)
        {
            return Ok($"The id is :{id}");
        }
    }
}
