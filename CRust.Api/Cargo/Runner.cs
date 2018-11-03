using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Threading;

namespace CRust.Api.Cargo
{
    public sealed class Runner
    {
        private const string cargoDirName = ".cargo/bin";
        private const string cargo = "cargo";

        private readonly string cargoDirPath;

        private StreamReader stdout;

        public Runner()
        {
            cargoDirPath = Path.Combine
            (
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
                cargoDirName
            );
        }

        public void Run(string cmd, out string stdout, out string stderr)
        {
            StringBuilder sbOut = new StringBuilder();
            StringBuilder sbErr = new StringBuilder();

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                CreateNoWindow = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                RedirectStandardInput = true,
                Arguments = cmd,
                FileName = cargo
            };

            Process process = new Process
            {
                StartInfo = processStartInfo,
                EnableRaisingEvents = true
            };

            process.OutputDataReceived += new DataReceivedEventHandler
            (
                (object sender, DataReceivedEventArgs e) =>
                {
                    sbOut.Append(e.Data);
                }
            );

            process.ErrorDataReceived += new DataReceivedEventHandler
            (
                (object sender, DataReceivedEventArgs e) =>
                {
                    sbErr.Append(e.Data);
                }
            );

            process.Start();
            process.BeginOutputReadLine();
            process.WaitForExit();
            process.CancelOutputRead();

            stdout = sbOut.ToString();
            stderr = sbErr.ToString();
        }
    }
}
