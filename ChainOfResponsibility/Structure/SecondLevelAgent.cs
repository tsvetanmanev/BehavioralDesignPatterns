using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Structure
{
    internal class SecondLevelAgent : Agent
    {
        public override void ProcessTicket(Ticket ticket)
        {
            if (ticket.Severity < 70)
            {
                Console.WriteLine("{0} fixed ticket ID {1}", this.GetType().Name, ticket.ID);
            }
            else if(this.UpperLevelAgent != null)
            {
                this.UpperLevelAgent.ProcessTicket(ticket);
            }
        }
    }
}
