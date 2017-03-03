using Xunit;

namespace Tests
{
    
    public class Tests
    {
        [Fact]
        public void TwoAndTwoIsFour() 
        {
            Assert.Equal(ConsoleApplication.Program.Add(2,2), 4);
        }
    }
}
