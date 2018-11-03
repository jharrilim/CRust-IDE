using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Cargo.Command
{
    public sealed class RunCommandBuilder : CommandBuilderBase
    {
        private RunCommandBuilder(string baseCmd) : base(baseCmd)
        {

        }

        internal static RunCommandBuilder FromBase(string baseCmd)
        {
            return new RunCommandBuilder(baseCmd + " " + Commands.Run);
        }

        public RunCommandBuilder WithRelease()
        {
            args.Add(Commands.RunOptions.Release);
            return this;
        }

        public RunCommandBuilder WithBin(string target)
        {
            args.Add(Commands.RunOptions.Bin + " " + target);
            return this;
        }
    }
}
