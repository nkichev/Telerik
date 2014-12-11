using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Models
{
    [ComplexType]
    public class StudentInfo
    {
        [Column("Email")]
        public string Email { get; set; }

        [Column("Address")]
        public string Address { get; set; }
    }
}
