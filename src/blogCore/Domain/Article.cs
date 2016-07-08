using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blogCore.Domain
{
    public class Article : BlogCoreBase
    {
        [Key]
        public int ArticleId { get; protected set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string SubTitle { get; set; }
        [Required]
        [MaxLength(250)]
        public string Slug { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
        public virtual ICollection<ContentVersion> ContentVersions { get; set; }
        public PublishStatusType PublishStatus { get; set; }
        public string FeaturedImage { get; set; }
        

        public enum PublishStatusType
        {
            [Description("Draft")]
            Draft,
            [Description("Private")]
            Private,
            [Description("Protected")]
            Protected,
            [Description("Public")]
            Public
        }
    }
}
