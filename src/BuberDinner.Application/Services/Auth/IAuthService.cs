using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Auth
{
    public interface IAuthService
    {
        AuthResult Register(string firstName, string lastName, string email, string password);
        AuthResult Login(string email, string password);
    }
}