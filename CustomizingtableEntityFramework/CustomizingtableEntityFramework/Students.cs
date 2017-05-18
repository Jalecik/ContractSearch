using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomizingtableEntityFramework
{
    [Table("tblStudents")]
  public   class Students
    {
        public int Id { get; set; }
        [Column("first_name")]
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        [ForeignKey("facultyId")]
        public Faculty faculty { get; set; }

    }
}
