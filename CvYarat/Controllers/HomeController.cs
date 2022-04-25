using CvYarat.Data;
using CvYarat.Models;
using CvYarat.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CvYarat.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment _hostEnvironment;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        Client client = new();
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PDF(int param)
        {
            List<SelectListItem> getCity = (from c in db.Cities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = c.Name,
                                                Value = c.Id.ToString()
                                            }).ToList();

            ViewData["City"] = getCity;


            List<SelectListItem> getInstitution = (from e in db.EduInstitutions.ToList()
                                                   select new SelectListItem
                                                   {
                                                       Text = e.Name,
                                                       Value = e.Id.ToString()
                                                   }).ToList();

            ViewData["Institution"] = getInstitution;


            List<SelectListItem> GetEduInst = (from e in db.EducationLevels.ToList()
                                               select new SelectListItem
                                               {
                                                   Text = e.Level,
                                                   Value = e.Id.ToString()
                                               }).ToList();

            ViewData["EduLevel"] = GetEduInst;


            List<SelectListItem> Deportaments = (from e in db.Deportaments.ToList()
                                                 select new SelectListItem
                                                 {
                                                     Text = e.Name,
                                                     Value = e.Id.ToString()
                                                 }).ToList();

            ViewData["Dprtmnt"] = Deportaments;

            ModelCollection collection = new();

            var clients = db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault();
            var educations = db.Educations.Where(e => e.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id).ToList();
            var trainings = db.ClientTrainings.Where(e => e.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id).ToList();
            var skills = db.ClientSkills.Where(e => e.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id).ToList();
            var workExperiences = db.WorkExperiences.Where(e => e.ClientId == db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault().Id).ToList();

            collection.Client = clients;
            collection.Educations = educations;
            collection.ClientTrainings = trainings;
            collection.ClientSkills = skills;
            collection.WorkExperiences = workExperiences;

            return View(collection);
        }



        public IActionResult PDFCV(int param)
        {
            var getList = db.Clients.Where(c => c.UserId == User
                 .FindFirst(ClaimTypes.NameIdentifier).Value)
                .Include(e => e.Educations)
                .Include(s => s.ClientSkills)
                .Include(w => w.WorkExperiences)
                .Include(t => t.ClientTrainings)
               .ToList();

            return View();
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
