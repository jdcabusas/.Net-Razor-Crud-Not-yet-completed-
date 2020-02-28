using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Applicant_List.Model
{
    public class Applicant
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Exp { get; set; }
        public string Degree { get; set; }
        public string Major { get; set; }
    }
}
