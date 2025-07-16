using Ardalis.GuardClauses;
using System.Text.RegularExpressions;

namespace WhoRU.Domain.ValueObjects;

public class Email
{
    public string Value { get; private set; }

    public Email(string email)
    {
        Guard.Against.NullOrEmpty(email, nameof(email));
        if (!IsValidEmail(email))
            throw new ArgumentException("Invalid email format", nameof(email));

        Value = email;
    }

    private bool IsValidEmail(string email)
    {
        var pattern = @"^\S+@\S+\.\S+$";
        return Regex.IsMatch(email, pattern);
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj)
    {
        if (obj is Email other)
            return Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        return false;
    }

    public override int GetHashCode() => Value.ToLowerInvariant().GetHashCode();
}
