class CurrentAccount(string number, double balance, double creditLine, Person owner) : Account(number, balance, owner)
{
    public double CreditLine { get; set; } = creditLine;
    public override void Withdraw(double amount)
    {
        base.Withdraw(amount - CreditLine);

    }

}