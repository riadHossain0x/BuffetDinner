namespace BuffetDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    public AuthenticationResult Register(string fName, string lName, string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), fName, lName, email, password);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(Guid.NewGuid(), "firstname", "lastname", email, password);
    }
}
