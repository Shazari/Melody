using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{

    public class JoinToCourse:BaseEntity
    {
        public JoinToCourse():base()
        {
        }


       [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
            Name =Resources.AcademyManagment.Strings.CourseKeys.Name)]
       [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Course_FK { get; set; }
       
        /// <summary>
        /// این شخص هنرجو میباشد
        /// </summary>
        /// 
        [Display(ResourceType = typeof(Resources.Person),
            Name =Resources.Strings.PersonKeys.StudentName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        
        public string Person_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.JoinToCourse),
            Name =Resources.AcademyManagment.Strings.JoinToCourseKeys.RegisterDate)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
            ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime RegisterDate { get; set; }
        [ForeignKey("Person_FK")]
        public virtual Person Person { get; set; }

        [ForeignKey("Course_FK")]
        public virtual Course Course { get; set; }
    }
}
