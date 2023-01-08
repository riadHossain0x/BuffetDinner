using BuffetDinner.Domain.Entities;

namespace BuffetDinner.Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    User? GetUserByEmail(string email);
    void Add(User user);
}
