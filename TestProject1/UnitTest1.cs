using Account;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public void CheckAccountBalanceTest()
    {
        // Arrange
        var account = new Account.Account("Ali" , "123" , "isfahan" , 2 , 500 , AccountType.NRI);
        // Act
        String result = account.CheckAccountBalance();
        // Assert
        
        Assert.Equal("Your bank account balance :498" ,  result);
    }
    
    
    [Fact]
    public void WithdrawTest()
    {
        // Arrange
        var account = new Account.Account("Ali" , "123" , "isfahan" , 2 , 500 , AccountType.NRI);
        // Act
        String result = account.Withdraw(100);
        // Assert
        
        Assert.Equal("Withdrawal Completed Successfully" ,  result);
    }
    
    [Fact]
    public void DepositTest()
    {
        // Arrange
        var account = new Account.Account("Ali" , "123" , "isfahan" , 2 , 500 , AccountType.NRI);
        // Act
        String result = account.Deposit(100);
        // Assert
        Assert.Equal("Deposit was Made Successfully" ,  result);
    }
    
    [Fact]
    public void LoanRequest1Test()
    {
        // Arrange
        var account = new Account.Account("Ali" , "123" , "isfahan" , 2 , 500 , AccountType.NRI);
        // Act
        String result = account.LoanRequest("Ali", "123" ,100);
        // Assert
        Assert.Equal("Loan Application Applied Successfully" ,  result);
    }
    
    [Fact]
    public void LoanRequest2Test()
    {
        // Arrange
        var account = new Account.Account("Ali" , "123" , "isfahan" , 2 , 500 , AccountType.NRI);
        // Act
        String result = account.LoanRequest("Ali", "123" ,LoanType.BUSINESS);
        // Assert
        Assert.Equal("Loan Application Applied Successfully" ,  result);
    }
    
    
    
    
}