using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using CRust.Api.Cargo.Command;
using System.IO;
using Xunit.Abstractions;

namespace CRust.Api.Tests.Cargo.Command
{
    public class CommandBuilderTests
    {
        private readonly ITestOutputHelper testOutputHelper;

        public CommandBuilderTests(ITestOutputHelper toh)
        {
            testOutputHelper = toh;
        }

        [Fact]
        public void CommandBuilder_ShouldReturnExpectedString_WhenUsingBuildWithLib()
        {
            string expected = " build --lib";
            CommandBuilder builder = new CommandBuilder();

            string actual = builder
                .Build()
                .WithLib()
                .Build();

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("foo.rs")]
        [InlineData("foo\\foo.rs")]
        [InlineData("/src/foo/lib/foo.rs")]
        [InlineData("../bar/foo/baz.rs")]
        public void CommandBuilder_ShouldReturnExpectedString_WhenUsingBuildWithBin_GivenAValidFileName(string fileName)
        {
            string expectedCmd = " build --bin '{0}'";
            string expectedFilePath = Path.GetFullPath(fileName);
            string expected = String.Format(expectedCmd, expectedFilePath);

            CommandBuilder builder = new CommandBuilder();

            string actual = builder
                .Build()
                .WithBin(expectedFilePath)
                .Build();

            testOutputHelper.WriteLine("Expected: " + expected);
            testOutputHelper.WriteLine("Actual: " + actual);
            Assert.Equal(expected, actual);
        }
    }
}
