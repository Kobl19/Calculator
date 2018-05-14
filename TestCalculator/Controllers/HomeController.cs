using AutoMapper;
using Domain.Entity;
using Domain.Infastracture;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TestCalculator.Buisness.Manager;
using TestCalculator.ViewModels;

namespace TestCalculator.Controllers
{
    public class HomeController : Controller
    {
        ICalculatorManager calculatorManager;
        public HomeController(ICalculatorManager calculatorMan)
        {
            this.calculatorManager = calculatorMan;
        }
        // GET: Home
        public ActionResult Index()
        {
            IEnumerable<СalculatorStatistics> currentIPStat = calculatorManager.GetAll().Where(x => x.ClientIP == Request.UserHostAddress).Where(x => x.Date.Year == DateTime.Now.Year && x.Date.Day == DateTime.Now.Day);
            List<HistoryViewModel> model = Mapper.Map<IEnumerable<СalculatorStatistics>, List<HistoryViewModel>>(currentIPStat);
            return View(model);
        }
        [HttpPost]
        public ActionResult Index(string calcFormula)
        {
            СalculatorStatistics model = new СalculatorStatistics();
            model.Expression = calcFormula;
            model.ClientIP= System.Web.HttpContext.Current.Request.UserHostAddress;
            OperationDetails result=calculatorManager.AddStatistics(model);
            return Json(result.Succedeed);
        }
    }
}