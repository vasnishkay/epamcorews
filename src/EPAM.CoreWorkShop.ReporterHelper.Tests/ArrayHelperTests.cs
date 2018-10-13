using EPAM.Core.ReporterHelper;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EPAM.CoreWorkShop.ReporterHelper.Tests
{
    [TestClass]
    public class ArrayHelperTests
    {
        [TestMethod]
        public void FillTests()
        {
            var array = new int[3];

            ArrayHelper.Fill(array, 5);

            var expectedResult = new int[] { 5, 5, 5 };

            array.Should().BeEquivalentTo(expectedResult);
        }
    }
}