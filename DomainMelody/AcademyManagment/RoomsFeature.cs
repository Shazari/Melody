using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class RoomsFeature:BaseEntity
    {
        public RoomsFeature():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Feature),
            Name = Resources.AcademyManagment.Strings.FeatureKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid FeatureID { get; set; }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Room),
            Name = Resources.AcademyManagment.Strings.RoomKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid RoomID { get; set; }

        public virtual Feature Feature { get; set; }

        public virtual Room Room { get; set; }
    }
}
