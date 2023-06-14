using Lab01_ATM;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.Linq;


    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
       
    [Fact]
    public void TestBalance2()
    {
        ATM.Balance = 1000;
      
        // Act


        // Assert
        Assert.Equal(ATM.Balance, ATM.ViewBalance());


    }

    [Theory]
    [InlineData(500, 1500,1000)]

    [InlineData(-300, 1000, 1000)]
    [InlineData(1500, 2500,1000 )]
    public void TestDeposite(decimal depositeValue, decimal EexpectedBalanceAfterDeposite , decimal balance)
    {
       
        ATM.Balance = balance;

        decimal actual = ATM.Deposit(depositeValue);
        Assert.Equal(EexpectedBalanceAfterDeposite, actual);


    }
    [Theory]
    [InlineData(1500, 1000,1000)]
    [InlineData(500, 500,1000)]

    [InlineData(-300, 1000,1000)]

    public void TestWithdrawst2(decimal drawnValue, decimal EexpectedBalance, decimal balance)
    {
       
        ATM.Balance =balance;

        decimal actual = ATM.Withdraw(drawnValue);
        Assert.Equal(EexpectedBalance, actual);

    }[Fact]
    public void TestWithdrawst() {

        decimal initialBalance = 1000;
        ATM.Balance = initialBalance;
        decimal drawn = 500;
        
        decimal expectedBalance =ATM.Balance-drawn;
        decimal actual = ATM.Withdraw(drawn);
        Assert.Equal(expectedBalance, actual);

    
    }
}
   

