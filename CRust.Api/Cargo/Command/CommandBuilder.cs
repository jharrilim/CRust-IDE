using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CRust.Api.Cargo.Command
{
    /// <summary>
    /// The start of the fluent API for building Cargo commands.
    /// </summary>
    public class CommandBuilder
    {
        private string baseCmd;

        public CommandBuilder()
        {
            baseCmd = Commands.Cargo;
        }

        public RunCommandBuilder Run()
        {
            return RunCommandBuilder.FromBase(baseCmd);
        }

        public BuildCommandBuilder Build()
        {
            return BuildCommandBuilder.FromBase(baseCmd);
        }
    }
}
