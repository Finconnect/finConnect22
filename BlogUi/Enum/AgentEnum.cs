using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogUi.Enumeration;
namespace BlogUi.Enumeration
{
    public class AgentEnum : Enumeration
    {
        public static AgentEnum Dbtr = new AgentEnum(1, "Dbtr");
        public static AgentEnum Cdtr = new AgentEnum(2, "Cdtr");
        public static AgentEnum UltmtDbtr = new AgentEnum(3, "UltmtDbtr");
        public static AgentEnum UltmtCbtr = new AgentEnum(4, "UltmtCbtr");


        protected AgentEnum() { }

        public AgentEnum(int id, string name): base(id, name)
        {
        }

        public static IEnumerable<AgentEnum> List()
        {
            return new[] { UltmtDbtr, Dbtr, Cdtr, UltmtCbtr };
        }
    }
}
