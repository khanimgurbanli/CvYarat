using CvYarat.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CvYarat.Models
{
    public class ClientSkill
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bacarıq daxil edilməyib")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bacarıq səviyyəsi seçilməyib")]
        [EnumDataType(typeof(LevelCheck))]
        public string Level { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }

    }
}
