using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewOneRamkrishna.Models
{
    public class Employee
    {
        public int id { get; set; }
        [StringLength(50)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string EmpName { get; set; }

        //public string email { get; set; }
        //[Required(ErrorMessage ="Field Can't be Empty")]
        //[DataType(DataType.EmailAddress,ErrorMessage ="E-Mail is not Empty")]
        //public string contact { get; set; }
        public double salary { get; set; }


    }
}