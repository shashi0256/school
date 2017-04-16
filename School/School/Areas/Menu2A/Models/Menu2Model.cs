using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School.Areas.Menu2A.Models
{
    public class Menu2Model
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ClassName { get; set; }

        [Required]
        public string ClassDescription { get; set; }

        public string DateModified { get; set; }
    }
}