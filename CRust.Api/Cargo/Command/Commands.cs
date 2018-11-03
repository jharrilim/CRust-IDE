using System;
using System.Collections.Generic;
using System.Text;

namespace CRust.Api.Cargo.Command
{

    internal static class Commands
    {
        internal static string Cargo { get; } = "cargo";
        internal static string Build { get; } = "build";
        internal static string Install { get; } = "install";
        internal static string Run { get; } = "run";
        internal static string Test { get; } = "test";
        internal static string Update { get; } = "update";
        internal static string Publish { get; } = "publish";

        internal static class RunOptions
        {
            internal static string Release { get; } = "--release";

            /// <summary>
            /// Supply the name of the target after this
            /// </summary>
            internal static string Bin { get; } = "--bin";
        }

        internal static class BuildOptions
        {
            internal static string Lib { get; } = "--lib";

            /// <summary>
            /// Build only the specified binary
            /// </summary>
            internal static string Bin { get; } = "--bin";
            internal static string Release { get; } = "--release";
            internal static string Verbose { get; } = "--verbose";
        }
    }
}
