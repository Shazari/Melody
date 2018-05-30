using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Feature:BaseEntity
    {
        public Feature():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Feature),
            Name =Resources.AcademyManagment.Strings.FeatureKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }

    }
}
