using System.Collections.Generic;
using System.Linq;

namespace CRust.Api.Cargo.Command
{
    public abstract class CommandBuilderBase
    {
        internal string cmd;
        internal List<string> args;

        public CommandBuilderBase(string baseCmd)
        {
            args = new List<string>();
            cmd = baseCmd;
        }
        
        public string Build() => args.Aggregate(cmd, (acc, b) => acc + " " + b);
    }
}
