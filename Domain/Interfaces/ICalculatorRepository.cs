using Domain.Entity;
using Domain.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICalculatorRepository:IDisposable
    {
        IQueryable<СalculatorStatistics> GetAll();
        OperationDetails AddStatistics(СalculatorStatistics statistics);
    }
}
