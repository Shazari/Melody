using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Role:BaseEntity
    {
        public Role():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Role),
            Name =Resources.AcademyManagment.Strings.RoleKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength:20)]
        public string Name { get; set; }
        
        [Display(ResourceType = typeof(Resources.AcademyManagment.Role),
            Name =Resources.AcademyManagment.Strings.RoleKeys.NameInSystem)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string NameInSystem { get; set; }

    }
}
