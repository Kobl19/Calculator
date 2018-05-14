using Domain.EF;
using Domain.Entity;
using Domain.Infastracture;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repositories
{
    public class CalculatorRepository : ICalculatorRepository
    {
        DBContext db=new DBContext();
        
        public IQueryable<СalculatorStatistics> GetAll()
        {
            return db.CalculatorStatistics;
        }
        public OperationDetails AddStatistics(СalculatorStatistics statistics)
        {
            if (statistics.Expression!=null&&statistics.ClientIP!=null)
            {
                statistics.Date = DateTime.Now;
                db.CalculatorStatistics.Add(statistics);
                db.SaveChanges();
                return new OperationDetails(true, "");
            }
            return new OperationDetails(false, "validation exception");
        }
        public void Dispose()
        {
            db.Dispose();
        }       
    }
}
