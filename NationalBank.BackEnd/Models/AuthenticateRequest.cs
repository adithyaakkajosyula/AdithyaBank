namespace NationalBank.BackEnd.Models;

using System.ComponentModel.DataAnnotations;

public class AuthenticateRequest
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
    public string ReturnUrl { get; set; }
}