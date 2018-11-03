using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Cargo.Command
{
    public sealed class BuildCommandBuilder : CommandBuilderBase
    {
        private BuildCommandBuilder(string baseCmd) : base(baseCmd)
        {

        }

        internal static BuildCommandBuilder FromBase(string baseCmd)
        {
            return new BuildCommandBuilder(baseCmd + " " + Commands.Build);
        }

        public BuildCommandBuilder WithLib()
        {
            args.Add(Commands.BuildOptions.Lib);
            return this;
        }

        public BuildCommandBuilder WithBin(string target)
        {
            args.Add(Commands.BuildOptions.Bin + " " + target);
            return this;
        }
    }
}
