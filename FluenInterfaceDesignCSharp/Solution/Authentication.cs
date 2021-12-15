namespace FluentInterfaceDesignCSharp.Solution;

internal sealed class Authentication : IAuthentication
{
    public string Username { get; set; }
    public string Password { get; set; }
    public Authentication()
    {
        Username = "";
        Password = "";
    }

    public void Logout()
    {
        Console.WriteLine($"Logout executed by username : {Username} password : {Password}");
    }
}
