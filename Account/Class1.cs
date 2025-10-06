namespace Account;

public class Account
{
    public string Name { get; set; }
    public string NationalCode { get; set; }
    public string City { get; set; }
    public int BanckNumber { get; set; }
    public int Balance { get; set; }
    public int Score { get; set; }
    public AccountType accountType { get; set; }

    public Account(string name, string nationalCode, string city, int banckNumber, int balance, AccountType accounttype)
    {
        Name = name;
        NationalCode = nationalCode;
        City = city;
        BanckNumber = banckNumber;
        Balance = balance;
        accountType = accounttype;
        Score = 0;
    }

    public string CheckAccountBalance()
    {
        if (accountType.Equals(AccountType.SAVING_ACC))
        {
            if (Balance >= 1)
            {
                Balance -= 1;
            }
            else
            {
                return "You are Very Poor";
            }
        }
        else
        {
            if (Balance >= 2)
            {
                Balance -= 2;
            }
            else
            {
                return "You are Very Poor";
            }
        }

        Score += 10;
        return "Your bank account balance :" + Balance;
    }

    public string Withdraw(int amount)
    {
        if (amount > 10000)
        {
            return "The Withdrawal Limit is $10000";
        }

        if (amount > Balance)
        {
            return "Your Account Balance is NOT Enough";
        }

        Balance -= amount;
        Score += 20;
        return "Withdrawal Completed Successfully";
    }

    public string Deposit(int amount)
    {
        if (amount > 1000)
        {
            Balance -= Balance / 100;
            return "The Withdrawal Limit is $1000" + CheckAccountBalance();
        }

        Balance += amount;
        Score += 30;
        return "Deposit was Made Successfully";
    }

    public void ProfitCalculation()
    {
        if (accountType.Equals(AccountType.SAVING_ACC))
        {
            Balance += Balance / 10;
        }
        else
        {
            Balance += Balance / 50;
        }
    }

    public string LoanRequest(string name , string nationalCode , int amount)
    {
        if (!Name.Equals(name) || !NationalCode.Equals(nationalCode) )
        {
            return "Account Not Found";
        }

        if (Balance / 2 < amount)
        {
            return "Your Credit is not Enough for This Loan";
        }

        if (Score < 100)
        {
            return "You don't Have Enough Score";
        }

        if (accountType.Equals(AccountType.NRI))
        {
            Balance += amount;
            return "Loan Application Applied Successfully";
        }
        else
        {
            if (amount > 500)
            {
                return "Your Type Account is not Enough for This Loan";
            }
            Balance += amount;
            return "Loan Application Applied Successfully";
        }
        
    }

    public string LoanRequest(string name , string nationalCode , LoanType loanType)
    {
        if (!Name.Equals(name) || !NationalCode.Equals(nationalCode) )
        {
            return "Account Not Found";
        }
        
        Balance +=(int)loanType;
        return "Loan Application Applied Successfully";
    }
}

public enum AccountType
{
    SAVING_ACC,
    SALARY_ACC,
    NRI
}

public enum LoanType
{
    BUSINESS = 7000,
    STUDENT = 2000,
    MORTGAGE = 5000,
    MARRIAGE = 4000
}