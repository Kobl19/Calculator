using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestCalculator.ViewModels
{
    public class HistoryViewModel
    {
        public int Id { get; set; }
        public string Expression { get; set; }
        public DateTime dateTime { get; set; }
        public string ClientIP { get; set; }
    }
}