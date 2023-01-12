using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Core.Models
{
    public class CoverType : BaseEntity
    {
        [Display(Name = "Cover Type")]
        public string Name { get; set; }
    }
}
