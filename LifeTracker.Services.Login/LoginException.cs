using System;
using System.Collections.Generic;
using System.Text;

namespace LifeTracker.Services.Login
{
    public class LoginException : Exception {
        public LoginResult Result;

        public LoginException(LoginResult result) {
            Result = result;
        }
    }
}
