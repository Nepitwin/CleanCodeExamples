namespace FluentInterfaceDesignCSharp.Problem;

internal sealed class AuthenticationException : Exception
{
    public enum Code { LoginFailed = 1, LogoutFailed = 2 };

    public readonly Code ErrorCode;

    public AuthenticationException(Code errorCode)
    {
        ErrorCode = errorCode;
    }
}
