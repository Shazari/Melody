using System;
using Models.Infrastructure;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
   public class Article:BaseEntity
    {
        public Article() : base()
        {
        }

        [Display(ResourceType = typeof(Resources.CMS.Article),
                    Name =Resources.CMS.Strings.ArticleKeys.Title)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),AllowEmptyStrings =false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Article),
                    Name = Resources.CMS.Strings.ArticleKeys.ContentBody)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages), AllowEmptyStrings = false,
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        [DataType(dataType:DataType.Html)]
        public string  ContentBody { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Article),
                    Name = Resources.CMS.Strings.ArticleKeys.Priority)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public int   Priority { get; set; }

        [Display(ResourceType = typeof(Resources.Person),
                    Name = Resources.Strings.PersonKeys.AdminName)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public string  Person_Fk  { get; set; }

        [Display(ResourceType = typeof(Resources.CMS.Menu),
                    Name = Resources.CMS.Strings.MenuKeys.Name)]
        [Required(ErrorMessageResourceType = typeof(Resources.Messages),
                    ErrorMessage = Resources.Strings.MessagesKeys.DataRequeird)]
        public Guid Menu_Fk { get; set; }

        [ForeignKey("Menu_FK")]
        public virtual Menu Menu { get; set; }

        [ForeignKey("Person_FK")]
        public virtual Person Person { get; set; }
    }

}
