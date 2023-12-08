using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Common.Exceptions;
using BuberDinner.Application.Common.Interfaces.Auth;
using BuberDinner.Application.Persistence;
using BuberDinner.Domain.Entity;

namespace BuberDinner.Application.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IJwtGenerator _jwtGenerator;
        private readonly IUserRepository _userRepository;

        public AuthService(IJwtGenerator jwtGenerator, IUserRepository userRepository)
        {
            _jwtGenerator = jwtGenerator;
            _userRepository = userRepository;
        }

        public AuthResult Login(string email, string password)
        {
            User? user = _userRepository.GetUserByEmail(email);
            if (user is null)
            {
                throw new InvalidOperationException("User with given email not exsit");
            }

            if (user.Password != password)
            {
                throw new UnauthorizedAccessException("Invalid password");
            }
            var token = _jwtGenerator.GenrateToken(user.Id, user.FirstName, user.LastName);

            //check if user is exist
            return new AuthResult(
                user.Id,
                user.FirstName,
                user.LastName,
                user.Email,
                token
            );
        }

        public AuthResult Register(string firstName, string lastName, string email, string password)
        {
            if (_userRepository.GetUserByEmail(email) is not null)
            {
                throw new DuplicateEmailException("Email already exsit");
            }
            var user = new User
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Password = password
            };
            _userRepository.Add(user);

            Guid userId = Guid.NewGuid();
            var token = _jwtGenerator.GenrateToken(userId, firstName, lastName);

            return new AuthResult(
               userId,
               firstName,
               lastName,
               email,
               token
           );
        }
    }
}