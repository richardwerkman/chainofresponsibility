using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Lottery
    {
        public Ticket WinningTicket { get; set; }

        public Lottery(Ticket WinningTicket)
        {
            this.WinningTicket = WinningTicket;
        }
    }
}
