using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class СalculatorStatistics
    {
        public int Id { get; set; }
        [Required]
        public string Expression { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string ClientIP { get; set; }
    }
}
