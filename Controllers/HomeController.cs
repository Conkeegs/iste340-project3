using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project3_FinalExam.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Project3_FinalExam.Services;
using Project3_FinalExam.ViewModels;

namespace Project3_FinalExam.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGetFaculty _facultyRepository;
        private readonly IGetAbout _getAbout;

        public HomeController(IGetFaculty facultyRepository, IGetAbout getAbout)
        {
            _facultyRepository = facultyRepository;
            _getAbout = getAbout;
        }

        public async Task<IActionResult> Index()
        {
            var about = await _getAbout.GetAllAbout();
            var aboutViewModel = new AboutViewModel()
            {
                About = about,
                Title = "About Page"
            };
            return View(aboutViewModel);
        }

        public async Task<IActionResult> GetFaculty()
        {
            var allFaculty = await _facultyRepository.GetAllFaculty();
            var sortedFaculty = allFaculty.OrderBy(f => f.username);
            var homeViewModel = new HomeViewModel()
            {
                Faculty = allFaculty.ToList(),
                Title = "This is your Faculty"
            };
            return View(homeViewModel);
        }

        public async Task<IActionResult> Under()
        {
            var getUnder = new GetUndergraduate();
            var under = await getUnder.GetUnderGradDegrees();
            var underViewModel = new UndergradViewModel()
            {
                UnderGrads = under,
                Title = "Undergraduate Programs"
            };
            return View(underViewModel);
        }

        public async Task<IActionResult> Grad()
        {
            var getGrad = new GetGraduate();
            var grad = await getGrad.GetUnderGradDegrees();
            var gradViewModel = new GraduateViewModel()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            return View(gradViewModel);
        }

        public async Task<IActionResult> Minors()
        {
            var getMinors = new GetMinors();
            var min = await getMinors.GetMinorList();
            var minViewModel = new MinorViewModel()
            {
                Minors = min,
                Title = "Minors"
            };
            return View(minViewModel);
        }

        public async Task<IActionResult> GetEmployTable()
        {
            var getEmploy = new GetEmployment();
            var employ = await getEmploy.GetEmployTable();
            var employmentViewModel = new EmploymentViewModel()
            {
                EmploymentTables = employ,
                Title = "Employment Options"
            };
            return View(employmentViewModel);
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
    }
}
