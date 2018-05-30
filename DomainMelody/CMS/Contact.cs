using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
   public class Contact:BaseEntity
    {
        public Contact() : base()
        {
        }

        [Display(ResourceType = typeof(Resources.CMS.Contact),
                    Name = Resources.CMS.Strings.ContactKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Contact),
                    Name = Resources.CMS.Strings.ContactKeys.Email)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Contact),
                    Name = Resources.CMS.Strings.ContactKeys.Mobile)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 16)]
        public string Mobile { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Contact),
                    Name = Resources.CMS.Strings.ContactKeys.ContentBody)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string ContentBody { get; set; }

    }
}
