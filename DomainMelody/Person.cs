using System;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.Security.Principal;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections;
using System.Collections.Generic;

namespace Models
{
    public class Person:IdentityUser
    {
        public Person():base()
        {
        }

        [Display(Name = "نام")]
        [StringLength(maximumLength: 20)]
        public string FirstName { get; set; }

        [Display(Name ="نام خانوادگی")]
        [Required(ErrorMessage ="لطفا {0} را وارد نمایید",AllowEmptyStrings =false)]
        [StringLength(maximumLength:30)]
        [System.ComponentModel.DataAnnotations.Schema.Index(IsUnique = false)]
        public string LastName { get; set; }


        [Display(Name = "تلفن ضروری")]
        [StringLength(maximumLength: 15)]
        public string EmergancyPhone { get; set; }

        [Display(Name = "رزومه")]
        public string ResumeUrl { get; set; }

        public virtual ICollection<Course> Course { get; set; }
        public virtual ICollection<JoinToCourse> JoinToCourse { get; set; }
        public virtual ICollection<PaymentCourse> PaymentCourse { get; set; }
    }
}
