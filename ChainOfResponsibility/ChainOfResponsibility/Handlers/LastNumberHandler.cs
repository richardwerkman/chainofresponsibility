using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class LastNumberHandler : LotteryHandler
    {
        public LastNumberHandler(LotteryHandler Successor) : base(Successor)
        {
        }

        public override string handleRequest(Ticket Ticket, Lottery Lottery)
        {
            if (Ticket.TicketNumbers.ToString()[4] == Lottery.WinningTicket.TicketNumbers.ToString()[4])
            {
                return "You had the last number right! You won $5!";
            }
            else
            {
                if (Successor != null)
                {
                    return Successor.handleRequest(Ticket, Lottery);
                }
                return "oops";
            }
        }
    }
}
