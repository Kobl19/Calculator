using AutoMapper;
using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestCalculator.ViewModels;

namespace TestCalculator.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize(cfg => 
            cfg.CreateMap<СalculatorStatistics, HistoryViewModel>()
            );
        }
    }
}