using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Şəhər adı daxil edilməyib")]
        [RegularExpression(@"^(?=.*[0-9])[- .()0-9]+$", ErrorMessage = "Invalid Mobile number")]
        public string Name { get; set; }
        public IList<Client> Client { get; set; }

    }
}
