using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rppon._1.termin
{
    public interface IBankAccount
    {
        void AccountDetails();
        void sendMoney(decimal amount);
        void withdrawMoney(decimal amount);
    }
}
