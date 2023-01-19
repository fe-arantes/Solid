using Application.Domains;
using Application.Repositories;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Application.Services;

public class UserService
{
    UserRepository _userRepository { get; } = new();
    EmailService _emailService { get; } = new();

    public void AddUserWrong(string username)
    {
        //Validate
        if ( username == "Admin" )
            throw new InvalidOperationException();

        //Create User
        var connection = new SqlConnection();
        connection.Open();
        var command = new SqlCommand("INSERT INTO...");

        //Send Email
        var client = new SmtpClient("host");
        client.Send(new MailMessage());
    }

    public void AddUserCorrect(string username)
    {
        var user = UserDomain.Create(username);
        if ( user.IsNotValid )
            throw new InvalidOperationException();

        _userRepository.Insert(user);
        _emailService.Send(user);
    }
}
