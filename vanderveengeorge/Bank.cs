class Bank(Dictionary<string, CurrentAccount> accounts, string name)
{
    public Dictionary<string, CurrentAccount> Accounts { get; } = accounts;
    public string Name { get; set; } = name;
    void AddAccount(CurrentAccount account)
    {

    }
    void DeleteAccount(string number)
    {

    }
}