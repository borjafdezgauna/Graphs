
namespace Tests
{
    public class UnitTests
    {
        [Fact]
        public void UnDirectedGraphs()
        {
            Assert.True(Common.Tests.TestUnDirectedGraphs());
        }

        [Fact]
        public void DirectedGraphs()
        {
            Assert.True(Common.Tests.TestDirectedGraphs());
        }

        [Fact]
        public void DistanceCalculator()
        {
            Assert.True(Common.Tests.TestDistanceCalculator().Success);
        }
    }
}