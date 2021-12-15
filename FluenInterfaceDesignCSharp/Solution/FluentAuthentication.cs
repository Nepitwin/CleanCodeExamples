namespace FluentInterfaceDesignCSharp.Solution;

internal class FluentAuthentication
{
    private readonly Authentication _model = new();

    public FluentAuthentication Username(string username)
    {
        _model.Username = username;
        return this;
    }

    public FluentAuthentication Password(string password)
    {
        _model.Password = password;
        return this;
    }

    public IAuthentication Authorize()
    {
        Console.WriteLine($"Login executed by username : {_model.Username} password : {_model.Password}");
        return _model;
    }
}