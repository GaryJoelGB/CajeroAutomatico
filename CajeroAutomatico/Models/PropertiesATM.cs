using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Models
{
    public class PropertiesATM
    {
        public decimal Amount = 15000;
        public decimal Transactions { get; set; }

        public int Key = 1997;

        public int Try = 3;

        public decimal AmountTotal { get { return this.Amount; } }
        public decimal Withdrawal { get; set; }

        public List<decimal> MovemTransactions = new List<decimal>();
        public List<DateTime> HourTime = new List<DateTime>();



    }
}
