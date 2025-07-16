using Ardalis.GuardClauses;
using System.Text.RegularExpressions;

namespace WhoRU.Domain.ValueObjects;

public class PhoneNumber
{
    public string Value { get; private set; }

    public PhoneNumber(string phoneNumber)
    {
        Guard.Against.NullOrEmpty(phoneNumber, nameof(phoneNumber));
        if (!IsValidPhoneNumber(phoneNumber))
            throw new ArgumentException("Invalid phone number format", nameof(phoneNumber));

        Value = phoneNumber;
    }

    private bool IsValidPhoneNumber(string phoneNumber)
    {
        var pattern = @"^\+?[0-9]{10,15}$";
        return Regex.IsMatch(phoneNumber, pattern);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is PhoneNumber other)
            return Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        return false;
    }

    public override int GetHashCode() => Value.ToLowerInvariant().GetHashCode();
}
