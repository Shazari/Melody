using System;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Instrument: BaseEntity
    {
        public Instrument():base()
        {
        }


        [Display(ResourceType = typeof(Resources.AcademyManagment.Instrument),
            Name =Resources.AcademyManagment.Strings.InstrumentKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength:30)]
        public string Name { get; set; }

        

    }
}
