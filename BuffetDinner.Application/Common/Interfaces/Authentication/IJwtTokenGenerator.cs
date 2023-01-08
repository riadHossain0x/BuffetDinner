using BuffetDinner.Domain.Entities;

namespace BuffetDinner.Application.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateJwtToken(User user);
}
