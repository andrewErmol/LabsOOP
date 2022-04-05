using ExpressionLibrary;
using Xunit;
using FluentAssertions;


namespace TestForEpression
{
    public class UnitTest1
    {
        [Fact]
        public void TestForExpressionWithoutPrioritySign()
        {
            Expression expression = new Expression("12 + 6 - 8");
            double result = expression.FindingResults();
            result.Should().Be(10);
        }

        [Fact]
        public void TesrForExpressionWithPrioritySign()
        {
            Expression expression = new Expression("12 + 6 - 8 * 2");
            double result = expression.FindingResults();
            result.Should().Be(2);
        }
    }
}