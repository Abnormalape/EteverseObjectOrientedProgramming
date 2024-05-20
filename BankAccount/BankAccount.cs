using System;

public class BankAccount
{
    private decimal balance;

    public BankAccount(decimal initialBalance)
    {
        balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
        else
        {
            throw new ArgumentException("입금액은 반드시 0보다 커야합니다.");
        }

    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 & amount <= balance)
        {
            balance -= amount;
        }
        else
        {
            throw new ArgumentException("출금액이 잘못되었습니다.");
        }
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
