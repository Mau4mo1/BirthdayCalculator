using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCalculator.Models
{
    public class BirthDateModel
    {
        [Required(ErrorMessage ="Vul dit in!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Vul dit in!")]
        public DateTime BirthDate { get; set; }
    }
}
