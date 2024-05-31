namespace DotNetGitHooksTests
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category", "Unit")]
        public void CannotDivideByZero()
        {
            var divisor = 0;
            Assert.Throws<DivideByZeroException>(() => 1 / divisor);
        }
    }
}
