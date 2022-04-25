using CvYarat.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.ViewModel
{
    public class EditCertificationImage
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Təlimin adı daxil edilməyib")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Təlimçinin ad və soyadı daxil edilməyib")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Təlimçinin əlaqə nömrəsi daxil edilməyib")]
        public string Tel { get; set; }
        public string Mail { get; set; }

        [NotMapped]
        public IFormFile CertificatFile { get; set; }
        public string Photo { get; set; }


        [Required(ErrorMessage = "Təlim verən qurum daxil edilməldir")]
        public string Instition { get; set; }

        [Required(ErrorMessage = "Təlimin keçirildiyi yer göstərilməyib")]
        public string Address { get; set; }
        public DateTime? ProfBeginDate { get; set; }

        public DateTime? ProfEndDate { get; set; }
        public string Note { get; set; }
        public int? EducationId { get; set; }
        public Education Education { get; set; }
    }
}
