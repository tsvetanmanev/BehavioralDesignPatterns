using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Structure
{
    internal class ThirdLevelAgent : Agent
    {
        public override void ProcessTicket(Ticket ticket)
        {
            if (ticket.Severity < 100)
            {
                Console.WriteLine("{0} fixed ticket ID {1}", this.GetType().Name, ticket.ID);
            }
            else
            {
                Console.WriteLine("Ticket ID {0} escalated to management", ticket.ID);
            }
        }
    }
}
