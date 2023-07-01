namespace MessageProcessingSystem.DataAccess;

public class Account
{
    public Account(string login, string password)
    {
        Login = login;
        Password = password;
    }
    public string Login { get; internal set; }
    public string Password { get; internal set; }
}