using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class JackpotHandler : LotteryHandler
    {
        public JackpotHandler(LotteryHandler Successor) : base(Successor)
        {
        }

        public override string handleRequest(Ticket Ticket, Lottery Lottery)
        {
            if (Ticket.TicketNumbers == Lottery.WinningTicket.TicketNumbers && Ticket.TicketLetters.Equals(Lottery.WinningTicket.TicketLetters, StringComparison.CurrentCultureIgnoreCase))
            {
                return "Congratulations!!! You won the jackpot of $5,000,000!";
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
