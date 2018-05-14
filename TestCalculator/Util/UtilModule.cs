using Domain.Interfaces;
using Domain.Repositories;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestCalculator.Buisness;
using TestCalculator.Buisness.Manager;

namespace TestCalculator.Util
{
    public class UtilModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ICalculatorManager>().To<CalculatorManager>();
            Bind<ICalculatorRepository>().To<CalculatorRepository>();
        }
    }
}