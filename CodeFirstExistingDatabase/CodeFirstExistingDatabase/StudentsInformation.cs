namespace CodeFirstExistingDatabase
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentsInformation")]
    public partial class StudentsInformation
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthdate { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        public int? Phone { get; set; }

        [StringLength(50)]
        public string Country { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [Column("Entering year", TypeName = "date")]
        public DateTime? Entering_year { get; set; }

        [Column("Graduation Year", TypeName = "date")]
        public DateTime? Graduation_Year { get; set; }

        [StringLength(50)]
        public string Group { get; set; }

        [Column("Average Mark")]
        public double? Average_Mark { get; set; }

        public int? FacultyId { get; set; }

        [StringLength(50)]
        public string Status { get; set; }
    }
}
