using ChainOfResponsibility.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Agent firstLevelAgent = new FirstLevelAgent();
            Agent secondLevelAgent = new SecondLevelAgent();
            Agent thirdLevelAgent = new ThirdLevelAgent();

            firstLevelAgent.SetUpperLevelAgent(secondLevelAgent);
            secondLevelAgent.SetUpperLevelAgent(thirdLevelAgent);

            var easyTicket = new Ticket(1337, 28);
            var mediumTicket = new Ticket(1338, 56);
            var hardTicket = new Ticket(1458, 89);
            var imposibbleTicket = new Ticket(1555, 120);

            firstLevelAgent.ProcessTicket(easyTicket);
            firstLevelAgent.ProcessTicket(mediumTicket);
            firstLevelAgent.ProcessTicket(hardTicket);
            firstLevelAgent.ProcessTicket(imposibbleTicket);
        }
    }
}
