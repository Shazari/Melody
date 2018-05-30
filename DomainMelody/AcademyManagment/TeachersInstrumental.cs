using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class TeachersInstrumental:BaseEntity
    {
        public TeachersInstrumental():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Instrument),
            Name =Resources.AcademyManagment.Strings.InstrumentKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Instrument_FK { get; set; }

        /// <summary>
        /// این شخص مدرس میباشد
        /// </summary>
        [Display(ResourceType = typeof(Resources.Person),
            Name = Resources.Strings.PersonKeys.TeacherName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string Person_FK { get; set; }

        [ForeignKey("Instrument_FK")]
        public virtual Instrument Instrument { get; set; }

        [ForeignKey("Person_FK")]
        public virtual Person Person { get; set; }
    }
}
