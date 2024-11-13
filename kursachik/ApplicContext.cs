using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace kursachik
{
    internal class ApplicContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicContext() : base("SecondConnection") { }
    }
}
