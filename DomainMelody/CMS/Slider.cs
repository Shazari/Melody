using System;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
  public  class Slider:BaseEntity
    {
        public Slider():base()
        {
        }

        [Display(ResourceType = typeof(Resources.CMS.Slider),
            Name =Resources.CMS.Strings.SliderKeys.Description)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string  Describtion { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Slider),
            Name = Resources.CMS.Strings.SliderKeys.Title)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength:150)]
        public string Title{ get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Slider),
            Name = Resources.CMS.Strings.SliderKeys.ImgUrl)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string ImgUrl { get; set; }

        [Display(ResourceType = typeof(Resources.Person),
            Name = Resources.Strings.PersonKeys.AdminName)]
        public string Person_Fk { get; set; }

        [ForeignKey("Person_Fk")]
        public virtual Person Person { get; set; }
    }
}
