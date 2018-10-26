using System;
using Xunit;

namespace life.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var parameters = new GameParameters
            {
                Rows = 4,
                Columns = 8,
                State = "........\n" +
                        "....*...\n" +
                        "...**...\n" +
                        "........\n"
            };

            var sut = new GameOfLife();

            var expectedState =
                "........\n" +
                "...**...\n" +
                "...**...\n" +
                "........\n";

            Assert.Equal(expectedState, sut.NextState(parameters));
        }
    }
}
