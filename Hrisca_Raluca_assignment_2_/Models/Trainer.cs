using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hrisca_Raluca_assignment_2_.Models
{
    public class Trainer
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First name can not be empty")]
        [MinLength(2, ErrorMessage = "First name must be greater than or equal to 2 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last name can not be empty")]
        [MinLength(2, ErrorMessage = "Last name must be greater than or equal to 2 characters")]
        public string LastName { get; set; }

        [Display(Name = "Subject")]
        [Required(ErrorMessage = "Subject can not be empty")]
        [MinLength(2, ErrorMessage = "Subject must be greater than or equal to 2 characters")]
        public string Subject { get; set; }

    }
}