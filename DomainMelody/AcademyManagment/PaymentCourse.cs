using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class PaymentCourse:BaseEntity
    {
        public PaymentCourse():base()
        {
        }
        /// <summary>
        /// این شخص هنرجو میباشد
        /// </summary>
        /// 
        [Display(ResourceType = typeof(Resources.Person),
                Name =Resources.Strings.PersonKeys.StudentName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string Person_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Course),
                Name = Resources.AcademyManagment.Strings.JoinToCourseKeys.EntityName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid JoinToCourse_FK { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.PaymentCourse),
                Name = Resources.AcademyManagment.Strings.PaymentCourseKeys.PaymentDate)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public DateTime PaymentDate { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.PaymentCourse),
                Name = Resources.AcademyManagment.Strings.PaymentCourseKeys.RefrenceNumber)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength:30)]
        public string RefrenceNumber { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.PaymentCourse),
                Name = Resources.AcademyManagment.Strings.PaymentCourseKeys.PaymentStatus)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 30)]
        public string PaymentStatus { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.PaymentCourse),
                Name = Resources.AcademyManagment.Strings.PaymentCourseKeys.IsPaid)]
        public bool IsPaid { get; set; }

        [ForeignKey("JoinToCourse_FK")]
        public virtual JoinToCourse JoinToCourse { get; set; }

        [ForeignKey("Person_FK")]
        public virtual Person Person { get; set; }



    }
}
