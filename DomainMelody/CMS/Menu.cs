using System;
using System.ComponentModel.DataAnnotations;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Menu:BaseEntity
    {
        public Menu():base()
        {
        }

        [Display(ResourceType = typeof(Resources.CMS.Menu),
                    Name = Resources.CMS.Strings.MenuKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Menu),
                    Name = Resources.CMS.Strings.MenuKeys.ParentName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 50)]
        public Guid ParentId { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Menu),
                    Name = Resources.CMS.Strings.MenuKeys.ActionUrl)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 150)]
        public string ActionUrl { get; set; }

        [ForeignKey("ParentId")]
        public virtual Menu ParentMenu { get; set; }

    }
}
