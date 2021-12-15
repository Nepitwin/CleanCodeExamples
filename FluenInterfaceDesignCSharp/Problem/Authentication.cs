namespace FluentInterfaceDesignCSharp.Problem;

internal sealed class Authentication
{
    private readonly string _username;
    private readonly string _password;
    private bool UserAuthenticated { get; set; }

    public Authentication(string username, string password)
    {
        _username = username;
        _password = password;
    }

    public void Login()
    {
        Console.WriteLine($"Login executed by username : {_username} password : {_password}");
        UserAuthenticated = true;
    }

    public void Logout()
    {
        if (!UserAuthenticated)
        {
            throw new AuthenticationException(AuthenticationException.Code.LogoutFailed);
        }

        Console.WriteLine($"Logout executed by username : {_username} password : {_password}");
    }
}

