using CvYarat.Data.Enums;
using CvYarat.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CvYarat.ViewModel
{
    public class EditProfileImage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Adınız daxil edilməyib")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid course name ")]
        [StringLength(50, ErrorMessage = "You can enter a maximum of 50 character elements.", MinimumLength = 3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyadınız  daxil edilməyib")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid course name ")]
        [StringLength(50, ErrorMessage = "You can enter a maximum of 50 character elements.", MinimumLength = 3)]
        public string Surname { get; set; }



        [Required(ErrorMessage = "Ata adı daxil edilməyib")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Invalid course name ")]
        [StringLength(50, ErrorMessage = "You can enter a maximum of 50 character elements.", MinimumLength = 3)]
        public string FatherName { get; set; }


        [Required(ErrorMessage = "Cinsiyyət seçilməyib")]
        [EnumDataType(typeof(SelectGender))]
        public SelectGender Gender { get; set; }

        [Required(ErrorMessage = "Doğum tarixiniz daxil edilməyib")]
        public DateTime Birthdate { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }
        public string Photo { get; set; }
        public bool Status { get; set; }

        [Required(ErrorMessage = "Ailə vəziyyəti seçilməyib")]
        [EnumDataType(typeof(MrtlStatus))]
        public MrtlStatus MaritalStatus { get; set; }

        public string Citizenship { get; set; }

        [Required(ErrorMessage = "Elektron poçt ünvanı daxil edilməyib")]
        [EmailAddress]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Sürücülük vəsiqəsi haqqında məlumat daxil edilməyib")]
        [EnumDataType(typeof(DrvgLicense))]
        public DrvgLicense DrivingLicense { get; set; }


        [Required(ErrorMessage = "Hərbi bilet haqqında məlumat daxil edilməyib")]
        [EnumDataType(typeof(MltryService))]
        public MltryService MilitaryService { get; set; }


        [Required(ErrorMessage = "Yaşayış ünvanı daxil edilməyib")]
        public string LivingAddress { get; set; }
        public string RegistrationAddress { get; set; }

        [Required(ErrorMessage = "Mobil nömrə daxil edilməyib")]
        [Phone]
        [RegularExpression(@"^(?=.*[0-9])[- .()0-9]+$", ErrorMessage = "Invalid Mobile number")]
        public string MobPhone { get; set; }
        public string Linkedin { get; set; }
        public string Github { get; set; }

        [Required(ErrorMessage = "Yaşadığınız şəhər seçilməyib")]
        public int CityId { get; set; }
        public City City { get; set; }
        public string Action { get; set; }
    }
}
