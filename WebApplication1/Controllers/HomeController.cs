using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using WebApplication1.Repository;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository _studentRepository;

        public HomeController(ILogger<HomeController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }


        public IActionResult Index(bool Order)
        {
            if (Order !=null && Order ==true)
            {
                return View(_studentRepository.GetAllByState());
            }
            return View(_studentRepository.GetAll());
        }

        public IActionResult NotHaveLessons(int id)
        {
            return View(_studentRepository.DontGetLesson(id));
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}