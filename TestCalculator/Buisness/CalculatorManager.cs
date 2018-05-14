using Domain.Entity;
using Domain.Infastracture;
using Domain.Interfaces;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestCalculator.Buisness.Manager;

namespace TestCalculator.Buisness
{
    public class CalculatorManager:ICalculatorManager
    {
        ICalculatorRepository calculatorRepo;
        public CalculatorManager(ICalculatorRepository calculatorRepository)
        {
            this.calculatorRepo = calculatorRepository;
        }
        public IQueryable<СalculatorStatistics> GetAll()
        {
            return calculatorRepo.GetAll();
        }
        public OperationDetails AddStatistics(СalculatorStatistics statistics)
        {
            return calculatorRepo.AddStatistics(statistics);
        }
    }
}