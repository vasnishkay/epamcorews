using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace EPAM.Core.ReporterHelper.Tests
{
    [TestClass]
    public class ReportNameHelperTests
    {
        [AssemblyInitialize]
        public static void Init(TestContext context)
        {
            //Thread.Sleep(30 * 1000);
        }

        [TestMethod]
        //[DataRow("Hello: my world", '_', "Hello_ my world")]
        [DataRow("Hello my %world", '_', "Hello my %world")]
        [DataRow("Hello my /world", '_', "Hello my _world")]
        public void NormalizeFileNameTest(string name, char repl, string expected)
        {
            var result = ReportNameHelper.NormalizeFileName(name, repl);

            result.Should().BeEquivalentTo(expected);
        }
    }
}