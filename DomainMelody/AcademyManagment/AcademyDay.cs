using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class AcademyDay:BaseEntity
    {
        public AcademyDay():base()
        {
        }
        
        [Display(ResourceType = typeof(Resources.AcademyManagment.AcademyDay),
                    Name =Resources.AcademyManagment.Strings.AcademyDayKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
    }
}
