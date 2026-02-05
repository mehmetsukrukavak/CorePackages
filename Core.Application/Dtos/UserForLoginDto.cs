namespace Core.Application.Dtos;

public class UserForLoginDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string? AuthenticatorCode { get; set; }

    public UserForLoginDto()
    {
        Email = string.Empty;
        Password = string.Empty;
    }

    public UserForLoginDto(string email, string password)
    {
        Email = email;
        Password = password;
    }

    public UserForLoginDto(string email, string password, string authenticatorCode)
    {
        Email = email;
        Password = password;
        AuthenticatorCode = authenticatorCode;
    }
}
