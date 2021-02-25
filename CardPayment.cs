using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSP.NET.L2.Refactored
{
    class CardPayment : Payment 
    {
        public override void BuyTicket(TicketDetails ticket, Action onPayChangeToMobilePhone)
        {
            ChargeCard(ticket);
        }

        private void ChargeCard(TicketDetails ticket)
        {
            var gateway = new ProcessingCenterGateway();
            gateway.Charge(ticket.Price);
        }

        internal class ProcessingCenterGateway
        {
            public void Charge(decimal ticketPrice)
            {
                //charging process
            }
        }
    }

}
