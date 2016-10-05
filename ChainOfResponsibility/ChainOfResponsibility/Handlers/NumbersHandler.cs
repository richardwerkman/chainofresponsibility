using System;

namespace ChainOfResponsibility
{
    internal class NumbersHandler : LotteryHandler
    {
        public NumbersHandler(LotteryHandler Successor) : base(Successor)
        {
        }

        public override string handleRequest(Ticket Ticket, Lottery Lottery)
        {
            if(Ticket.TicketNumbers == Lottery.WinningTicket.TicketNumbers)
            {
                return "Congratulations you had the numbers right! You have won $50!";
            } else
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