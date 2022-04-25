using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class Deportament
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Məlumat  daxil edilməyib")]
        public string Name { get; set; }

        public WorkExperience WorkExperience { get; set; }
    }
}
