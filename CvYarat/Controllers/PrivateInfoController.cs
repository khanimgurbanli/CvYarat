using CvYarat.Data;
using CvYarat.Models;
using CvYarat.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;


namespace CvYarat.Controllers
{
    [Authorize]
    public class PrivateInfoController : Controller
    {

        Client c = new();
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment webHostEnvironment;

        public PrivateInfoController(ApplicationDbContext db, IWebHostEnvironment hostEnvironment)
        {
            this.db = db;
            webHostEnvironment = hostEnvironment;
        }




        public IActionResult Create()
        {
            List<SelectListItem> getCity = (from c in db.Cities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = c.Name,
                                                Value = c.Id.ToString()
                                            }).ToList();

            ViewData["City"] = getCity;



            if (db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault() == default)
                return View();
            else
                return RedirectToAction("Edit");
        }



        [HttpPost]
        public IActionResult Create(AddProfileImage client)
        {
            List<SelectListItem> getCity = (from c in db.Cities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = c.Name,
                                                Value = c.Id.ToString()
                                            }).ToList();

            ViewData["City"] = getCity;

            if (!ModelState.IsValid)
            {
                return View("Create", client);
            }

            var checkClient = db.Clients.ToList()
                .Any(s => s.Name == client.Name
                   && s.Surname == client.Surname
                    && s.FatherName == client.FatherName
                    && s.Birthdate == client.Birthdate
                    && s.Mail == client.Mail);


            if (checkClient)
            {
                ViewBag.checkResultMessage = "The user already exiest";
                return RedirectToAction("Create");
            }
            else
            {

                if (client.ImageFile != null)
                {
                    var extension = Path.GetExtension(client.ImageFile.FileName);
                    var newImageName = Guid.NewGuid() + extension;
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                    var fileStream = new FileStream(filePath, FileMode.Create);
                    client.ImageFile.CopyTo(fileStream);

                    c.Photo = newImageName;
                    c.Name = client.Name;
                    c.UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
                    c.Surname = client.Surname;
                    c.FatherName = client.FatherName;
                    c.Gender = client.Gender;
                    c.Birthdate = client.Birthdate;
                    c.MaritalStatus = client.MaritalStatus;
                    c.Citizenship = client.Citizenship;
                    c.Mail = client.Mail;
                    c.DrivingLicense = client.DrivingLicense;
                    c.MilitaryService = client.MilitaryService;
                    c.LivingAddress = client.LivingAddress;
                    c.RegistrationAddress = client.RegistrationAddress;
                    c.MobPhone = client.MobPhone;
                    c.Linkedin = client.Linkedin;
                    c.Github = client.Github;
                    c.Action = client.Action;
                    c.City = db.Cities.Where(c => c.Id == client.CityId).FirstOrDefault();

                    db.Add(c);
                    db.SaveChanges();

                }


                return RedirectToAction("Edit");
            }
        }




        public IActionResult Edit()
        {
            //sheherler
            List<SelectListItem> getCity = (from c in db.Cities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = c.Name,
                                                Value = c.Id.ToString()
                                            }).ToList();

            ViewData["City"] = getCity;

            var clnt = db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault();

            EditProfileImage edit = new();

            edit.Id = clnt.Id;
            edit.Photo = clnt.Photo;
            edit.Name = clnt.Name;
            edit.Surname = clnt.Surname;
            edit.FatherName = clnt.FatherName;
            edit.Gender = clnt.Gender;
            edit.Birthdate = clnt.Birthdate;
            edit.MaritalStatus = clnt.MaritalStatus;
            edit.Citizenship = clnt.Citizenship;
            edit.Mail = clnt.Mail;
            edit.DrivingLicense = clnt.DrivingLicense;
            edit.MilitaryService = clnt.MilitaryService;
            edit.LivingAddress = clnt.LivingAddress;
            edit.RegistrationAddress = clnt.RegistrationAddress;
            edit.MobPhone = clnt.MobPhone;
            edit.Linkedin = clnt.Linkedin;
            edit.Github = clnt.Github;
            edit.Action = clnt.Action;
            edit.CityId = clnt.CityId;

            return View(edit);
        }


        [HttpPut]
        public IActionResult Edit(EditProfileImage client)
        {
            List<SelectListItem> getCity = (from c in db.Cities.ToList()
                                            select new SelectListItem
                                            {
                                                Text = c.Name,
                                                Value = c.Id.ToString()
                                            }).ToList();

            ViewBag.City = getCity;

            var clnt = db.Clients.Where(c => c.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value).FirstOrDefault();

            //For Validation
            EditProfileImage edit = new();

            edit.Id = clnt.Id;
            edit.Photo = clnt.Photo;
            edit.Name = clnt.Name;
            edit.Surname = clnt.Surname;
            edit.FatherName = clnt.FatherName;
            edit.Gender = clnt.Gender;
            edit.Birthdate = clnt.Birthdate;
            edit.MaritalStatus = clnt.MaritalStatus;
            edit.Citizenship = clnt.Citizenship;
            edit.Mail = clnt.Mail;
            edit.DrivingLicense = clnt.DrivingLicense;
            edit.MilitaryService = clnt.MilitaryService;
            edit.LivingAddress = clnt.LivingAddress;
            edit.RegistrationAddress = clnt.RegistrationAddress;
            edit.MobPhone = clnt.MobPhone;
            edit.Linkedin = clnt.Linkedin;
            edit.Github = clnt.Github;
            edit.Action = clnt.Action;
            edit.City = db.Cities.Where(c => c.Id == clnt.CityId).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                return View("Edit", edit);
            }

            var getById = db.Clients.Where(c => c.Id == client.Id).FirstOrDefault();

            if (client.ImageFile != null)
            {

                var extension = Path.GetExtension(client.ImageFile.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images/", newImageName);
                var fileStream = new FileStream(filePath, FileMode.Create);
                client.ImageFile.CopyTo(fileStream);
                getById.Photo = newImageName;
            }

            //For edit

            getById.Name = client.Name;
            getById.Surname = client.Surname;
            getById.FatherName = client.FatherName;
            getById.Gender = client.Gender;
            getById.Birthdate = client.Birthdate;
            getById.MaritalStatus = client.MaritalStatus;
            getById.Citizenship = client.Citizenship;
            getById.Mail = client.Mail;
            getById.DrivingLicense = client.DrivingLicense;
            getById.MilitaryService = client.MilitaryService;
            getById.LivingAddress = client.LivingAddress;
            getById.RegistrationAddress = client.RegistrationAddress;
            getById.MobPhone = client.MobPhone;
            getById.Linkedin = client.Linkedin;
            getById.Github = client.Github;
            getById.Action = client.Action;
            getById.City = db.Cities.Where(c => c.Id == client.CityId).FirstOrDefault();

            db.Update(getById);
            db.SaveChanges();

            return RedirectToAction("Edit");
        }
    }
}
