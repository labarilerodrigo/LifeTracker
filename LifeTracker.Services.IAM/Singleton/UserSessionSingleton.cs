using System;

namespace LifeTracker.Services.IAM
{
    /// <summary>
    /// User Session Instance
    /// </summary>
    public class UserSessionSingleton {

        private static UserSession _instance;
        private static Object _lock = new object();

        public static UserSession Instance {
            get {
                lock (_lock) {
                    if (_instance == null)
                        _instance = new UserSession();
                }
                return _instance;
            }
        }
    }
}
