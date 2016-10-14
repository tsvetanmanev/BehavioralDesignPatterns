using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Ticket
    {
        public Ticket (int id, int severity)
        {
            this.ID = id;
            this.Severity = severity;
        }

        public int ID { get; private set; }
        public int Severity { get; private set; }
    }
}
