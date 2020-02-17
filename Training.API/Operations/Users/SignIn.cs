using System;
using System.Collections.Generic;
using System.Text;
using Training.API.Contracts.Services;
using Training.DTO;

namespace Training.API.Operations.Users
{
    public class SignIn
    {
        private IPasswordHasher _PasswordHasher;

        private readonly ITokenService _TokenService;

        public SignIn(IPasswordHasher passwordHasher, ITokenService tokenService)
        {
            _PasswordHasher = passwordHasher;
            _TokenService = tokenService;
        }


        public void Execute(UserCredentials user)
        {

        }
    }
}
