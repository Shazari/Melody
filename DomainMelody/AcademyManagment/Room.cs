using Models.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Room:BaseEntity
    {
        public Room():base()
        {
        }

        [Display(ResourceType = typeof(Resources.AcademyManagment.Room),
            Name =Resources.AcademyManagment.Strings.RoomKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength: 20)]
        public string Name { get; set; }

        public Guid Institute_FK { get; set; }

        [ForeignKey("Institute_FK")]
        public virtual Institute Institute { get; set; }
    }
}
