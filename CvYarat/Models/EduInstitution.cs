using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class EduInstitution
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Təhsil müəssisəsinin adı daxil edilməyib ")]
        public string Name { get; set; }

        public Education Education { get; set; }
    }
}
