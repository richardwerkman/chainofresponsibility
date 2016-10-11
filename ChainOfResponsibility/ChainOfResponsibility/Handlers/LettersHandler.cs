using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class LettersHandler : LotteryHandler
    {
        public LettersHandler(LotteryHandler Successor) : base(Successor) { }

        public override string handleRequest(Ticket Ticket, Lottery Lottery)
        {
            if (Ticket.TicketLetters.Equals(Lottery.WinningTicket.TicketLetters, StringComparison.CurrentCultureIgnoreCase))
            {
                return "Congratulations you had the letters right! You have won $20!";
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
