using BuffetDinner.Application.Common.Interfaces.Authentication;

namespace BuffetDinner.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(IJwtTokenGenerator jwtTokenGenerator)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public AuthenticationResult Register(string fName, string lName, string email, string password)
    {
        // Check is user already exists

        // Create user (generate unique ID

        // Generate JWT token
        Guid userId = Guid.NewGuid();

        var token = _jwtTokenGenerator.GenerateJwtToken(userId, fName, lName);

        return new AuthenticationResult(
            userId,
            fName,
            lName,
            email,
            token);
    }

    public AuthenticationResult Login(string email, string password)
    {
        return new AuthenticationResult(
            Guid.NewGuid(),
            "firstname",
            "lastname",
            email,
            password);
    }
}
