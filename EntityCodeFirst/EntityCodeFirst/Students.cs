﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst
{
    [Table("hhjh")]
  public   class Students
    {  
        [Required]
  

        public int Id { get; set; }
         [MaxLength(50)]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string  Email{ get; set; }

    }
}
