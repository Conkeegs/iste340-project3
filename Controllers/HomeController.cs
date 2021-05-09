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
        private readonly IGetEmployment _getEmployment;
        private readonly IGetGraduate _getGraduate;
        private readonly IGetMinors _getMinors;
        private readonly IGetUndergraduate _getUndergraduate;
        private readonly IGetCoOp _getCoOp;

        public HomeController(IGetFaculty facultyRepository, IGetAbout getAbout, IGetEmployment getEmployment, IGetGraduate getGraduate, IGetMinors getMinors, IGetUndergraduate getUndergraduate, IGetCoOp getCoOp)
        {
            _facultyRepository = facultyRepository;
            _getAbout = getAbout;
            _getEmployment = getEmployment;
            _getGraduate = getGraduate;
            _getMinors = getMinors;
            _getUndergraduate = getUndergraduate;
            _getCoOp = getCoOp;
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
            var under = await _getUndergraduate.GetUnderGradDegrees();
            var underViewModel = new UndergradViewModel()
            {
                UnderGrads = under,
                Title = "Undergraduate Programs"
            };
            return View(underViewModel);
        }

        public async Task<IActionResult> Grad()
        {
            var grad = await _getGraduate.GetUnderGradDegrees();
            var gradViewModel = new GraduateViewModel()
            {
                Grads = grad,
                Title = "Graduate Programs"
            };
            return View(gradViewModel);
        }

        public async Task<IActionResult> Minors()
        {
            var min = await _getMinors.GetMinorList();
            var minViewModel = new MinorViewModel()
            {
                Minors = min,
                Title = "Minors"
            };
            return View(minViewModel);
        }

        public async Task<IActionResult> GetEmployTable()
        {
            var employ = await _getEmployment.GetEmployTable();
            var employmentViewModel = new EmploymentViewModel()
            {
                EmploymentTables = employ,
                Title = "Employment Options"
            };
            return View(employmentViewModel);
        }
        public async Task<IActionResult> GetCoOpTable()
        {
            var coop = await _getCoOp.GetCoOpTable();
            var coopViewModel = new CoOpViewModel()
            {
                CoOpTables = coop,
                Title = "CoOp Options"
            };
            return View(coopViewModel);
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
