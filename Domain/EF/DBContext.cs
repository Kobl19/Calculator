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
        public virtual DbSet<ÑalculatorStatistics> CalculatorStatistics { get; set; }
    }
}