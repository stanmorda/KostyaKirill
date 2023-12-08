// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;


static void OnAddMoney(object? sender, AccountAddMoneyEventArgs args)
{
    Console.WriteLine($"Got event:{nameof(OnAddMoney)}. Summa: {args.Summa} {args.Date}");
}



var account = new Account(99);

account.AddMoney += OnAddMoney;
account.AddMoney += OnAddMoney;

account.Add(99);
account.Add(100);

account.AddMoney -= OnAddMoney;


Console.Read();

public class Account
{
    private int _sum;


    public event EventHandler<AccountAddMoneyEventArgs> AddMoney;

    public Account(int sum)
    {
        this._sum = sum;
    }
    
    public void Add(int sum)
    {
        this._sum += sum;
        
        AddMoney?.Invoke(this, new AccountAddMoneyEventArgs(sum, DateTime.Now));
    }
    
}

public class AccountAddMoneyEventArgs 
{
    public int Summa { get;  }
    public DateTime Date { get; }

    public AccountAddMoneyEventArgs(int summa, DateTime date)
    {
        Summa = summa;
        Date = date;
    }
}

