using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L2.Refactored
{
    abstract class Payment
    {

        protected decimal _cashAccepted;
        public Payment() { }

        public abstract void BuyTicket(TicketDetails ticket, Action onPayChangeToMobilePhone);
       
    }
}
