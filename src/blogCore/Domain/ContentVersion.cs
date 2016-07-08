using System;
using System.ComponentModel.DataAnnotations;

namespace blogCore.Domain
{
    public class ContentVersion : BlogCoreBase
    {
        [Key]
        public int ContentVersionId { get; set; }
        [Required]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }

    }
}