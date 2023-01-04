﻿namespace BuffetDinner.Application.Services.Common.Interfaces.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateJwtToken(Guid id, string firstName, string lastName);
}