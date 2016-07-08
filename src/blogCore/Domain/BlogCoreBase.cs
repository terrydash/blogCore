using System;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blogCore.Domain
{
    public class BlogCoreBase
    {
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime ModifiedOn { get; set; }
        [Timestamp]
        public Byte[] Rowversion { get; set; }
    }
}
