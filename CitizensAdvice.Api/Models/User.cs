namespace CitizensAdvice.Api.Models;

public class User
{
    public long Id { get; set; }
    public string Email { get; set; }
    public byte[] PasswordHash { get; set; }
    public byte[] PasswordSalt { get; set; }
    public RoleType Role { get; set; }
}

public enum RoleType
{
    Agency,
    ServiceUser
}