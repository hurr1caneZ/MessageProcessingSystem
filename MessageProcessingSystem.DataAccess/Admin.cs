namespace MessageProcessingSystem.DataAccess;

public class Admin
{
    public Admin(Account login, Account password, Guid id)
    {
        Login = login;
        Password = password;
        Id = id;
    }
    public Account Login { get; internal set; }
    public Account Password { get; internal set; }
    public Guid Id { get; internal set; }
}