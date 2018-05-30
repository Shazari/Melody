using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Institute:BaseEntity
    {
        public Institute():base()
        {
        }
        
        [Display(ResourceType = typeof(Resources.AcademyManagment.Institute),
                    Name =Resources.AcademyManagment.Strings.InstituteKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }
    }
}
