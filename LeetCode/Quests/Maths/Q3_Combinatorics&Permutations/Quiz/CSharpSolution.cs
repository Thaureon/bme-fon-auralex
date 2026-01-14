public class Bank {

    public long[] balances;
    public Bank(long[] balance) {
        balances = balance;
    }
    
    public bool Transfer(int account1, int account2, long money) {
        if(account1 > balances.Length || account2 > balances.Length)
        {
            return false;
        }

        var withdraw = Withdraw(account1, money);
        if(withdraw)
        {
            Deposit(account2, money);
        }
        return withdraw;
    }
    
    public bool Deposit(int account, long money) {
        if(account > balances.Length)
        {
            return false;
        }

        balances[account - 1] += money;

        return true;
    }
    
    public bool Withdraw(int account, long money) {
        if(account > balances.Length)
        {
            return false;
        }
        if(balances[account - 1] < money)
        {
            return false;
        }

        balances[account - 1] -= money;

        return true;
    }
}

/**
 * Your Bank object will be instantiated and called as such:
 * Bank obj = new Bank(balance);
 * bool param_1 = obj.Transfer(account1,account2,money);
 * bool param_2 = obj.Deposit(account,money);
 * bool param_3 = obj.Withdraw(account,money);
 */