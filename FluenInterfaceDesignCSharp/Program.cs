using FluentInterfaceDesignCSharp.Problem;
using FluentInterfaceDesignCSharp.Solution;
using Authentication = FluentInterfaceDesignCSharp.Problem.Authentication;

{
    // Initial problem
    // Simple authentication object by username and password
    Authentication authentication = new("Max", "Power");

    // Error handling could be used by try catch... is this a nice solution?
    try
    {
        // This is by general a bad design concept because of missing error prone usage by developers
        authentication.Logout();
        authentication.Login();
    }
    catch (AuthenticationException ex)
    {
        Console.WriteLine(ex.ErrorCode);
    }

    try
    {
        authentication.Login();
        authentication.Logout();
    }
    catch (AuthenticationException ex)
    {
        Console.WriteLine(ex.ErrorCode);
    }


    // We want to avoid the possibility of retrieving wrong flow sequences.
    // Can the code become less error prone ? YES OF COURSE -> Fluent Interface Design Pattern
}

{
    // https://dotnettutorials.net/lesson/fluent-interface-design-pattern/
    // Solution by fluent interface design pattern
    // Wrong flow sequences are not working anymore
    // All configuration inputs can be set before login procedure is called
    // Can be easily extended by additional methods for example by an error handler
    // Authorize method can be executed empty or used by valid user data
    // Authentication object from IAuthentication shadows public member access from detailed implementation and allows only valid method usage
    // Interface is not general used by fluent interface design pattern. This is only for shadowing properties.
    FluentAuthentication fluentAuthentication = new();
    var authentication = fluentAuthentication.Username("Max").Password("Power").Authorize();
    authentication.Logout();
}
