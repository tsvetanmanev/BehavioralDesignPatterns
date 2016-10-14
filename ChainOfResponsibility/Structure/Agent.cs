
namespace ChainOfResponsibility.Structure
{
    internal abstract class Agent
    {
        protected Agent UpperLevelAgent { get; set; }

        public void SetUpperLevelAgent(Agent upperLevelAgent)
        {
            this.UpperLevelAgent = upperLevelAgent;
        }

        public abstract void ProcessTicket(Ticket ticket);
    }
}
