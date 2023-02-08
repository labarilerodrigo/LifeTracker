using LifeTracker.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.Services.IAM
{
    /// <summary>
    /// User Session
    /// </summary>
    public class UserSession {

        // User
        private IUser _user { get; set; }
        public IUser User {
            get {
                return _user;
            }
        }
        public List<string> Gender {
            get {
                return Enum.GetNames(typeof(Gender)).ToList();
            }
        }
        public List<string> Intensity {
            get {
                return Enum.GetNames(typeof(Intensity)).ToList();
            }
        }

        public List<string> Objective {
            get {
                return Enum.GetNames(typeof(Objective)).ToList();
            }
        }


        // LogIn & LogOut Objects
        public void LogIn(IUser user) {
            _user = user;
        }
        public void Logout() {
            _user = null;
        }
        public bool IsLogged() {
            return _user != null;
        }

        //private bool _isLoggingOut = false;
        public bool IsLoggingOut { get; set; }    

    }
}
