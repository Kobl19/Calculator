using Domain.Entity;
using Domain.Infastracture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculator.Buisness.Manager
{
    public interface ICalculatorManager
    {
        IQueryable<СalculatorStatistics> GetAll();
        OperationDetails AddStatistics(СalculatorStatistics statistics);
    }
}
