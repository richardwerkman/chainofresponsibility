using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class NothingHandler : LotteryHandler
    {
        public NothingHandler(LotteryHandler Successor) : base(Successor)
        {
        }

        public override string handleRequest(Ticket Ticket, Lottery Lottery)
        {
            return "I'm so sorry, you did not win anything...";
        }
    }
}
