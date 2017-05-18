namespace EntityCodeFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class studentContext : DbContext
    {
        public studentContext()
            : base("name=studentContext")
        {
        }

        public DbSet<Students> Students { get; set; }
    }
}
