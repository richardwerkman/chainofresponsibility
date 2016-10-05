using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Ticket
    {
        public string TicketLetters { get; set; }
        public int TicketNumbers { get; set; } 

        public Ticket(string Letters, string Numbers)
        {
            if(Letters.Length == 2 && Numbers.Length == 5)
            {
                this.TicketLetters = Letters;
                try
                {
                    this.TicketNumbers = int.Parse(Numbers);
                } catch(Exception)
                {

                }
            } else
            {
                throw new FormatException();
            }
        }
    }
}
