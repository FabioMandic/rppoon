using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public abstract class Transaction: ITransaction
    {
        public DateTime time { get; set; }
        public decimal amount { get; set; }

        public abstract void DoTransaction();

    }
}
