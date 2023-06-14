using Microsoft.VisualStudio.TestPlatform.TestHost;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AtmTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void TestTheBalance() {
            // Arrange
            decimal expectedBalance = 1000.00m;

            // Act
            decimal actualBalance = Program.ViewBalance();

            // Assert
            Assert.Equal(expectedBalance, actualBalance);
        }


    }
    }
