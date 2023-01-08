namespace BuffetDinner.Infrastructure.Services;

using Application.Common.Interfaces.Services;

public class DatetimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}
