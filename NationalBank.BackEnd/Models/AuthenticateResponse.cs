using NationalBank.BackEnd.Entities;
using static NationalBank.BackEnd.Models.Enums;

namespace NationalBank.BackEnd.Models;

public class AuthenticateResponse :BaseResultModel
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public RoleModel Role { get; set; }
    public string Token { get; set; }
}