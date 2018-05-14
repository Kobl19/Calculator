namespace Domain.EF
{
    using Domain.Entity;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DBContext : DbContext
    {
        public DBContext()
            : base("DefaultConnection")
        {}
        public virtual DbSet<�alculatorStatistics> CalculatorStatistics { get; set; }
    }
}