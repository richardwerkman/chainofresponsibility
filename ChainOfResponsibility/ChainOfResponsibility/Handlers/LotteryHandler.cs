using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class LotteryHandler
    {
        public LotteryHandler Successor { get; set; }

        public LotteryHandler(LotteryHandler Successor)
        {
            if(Successor != null)
            {
                this.Successor = Successor;
            }
        }

        public abstract string handleRequest(Ticket Ticket, Lottery Lottery);
    }
}
