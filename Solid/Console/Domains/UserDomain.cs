namespace Application.Domains;

public class UserDomain
{
    private string _username { get; }
    public string Username => IsValid ? _username : string.Empty;
    public bool IsValid { get; }
    public bool IsNotValid => !IsValid;

    private UserDomain(string username)
    {
        _username = username;
        IsValid = Validate(this);
    }

    private bool Validate(UserDomain user)
    {
        if ( user._username == "Admin" )
        {
            return false;
        }

        return true;
    }

    public static UserDomain Create(string username)
    {
        return new(username);
    }
}
