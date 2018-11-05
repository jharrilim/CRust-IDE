using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.IO;
using System.Linq;

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
            target = Path.GetFullPath(target);
            target = $"'{target}'";
            args.Add(Commands.BuildOptions.Bin + " " + target);
            return this;
        }
    }
}
