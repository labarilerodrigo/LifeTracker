using System;
using System.Collections.Generic;
using System.Linq;
using LifeTracker.Services.Login;
using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM.Composite2;
using LifeTracker.Services.Cryptography;

namespace LifeTracker.Core.BLL
{
    public class UserBLL : CrudBLL<IUser> {

        private UserRoleBLL _userRoleBLL;
        private UserServiceTypeBLL _userServiceTypeBLL;
        private List<LifeTracker.Services.IAM.Composite2.UserRole> _userRolesBE;

        public UserBLL() {
            _crud = new LifeTracker.DataAccess.Mapper.User();
            _userRoleBLL = new UserRoleBLL();
            _userServiceTypeBLL = new UserServiceTypeBLL();
            _userRolesBE = new List<LifeTracker.Services.IAM.Composite2.UserRole>();
        }

        /// <summary>
        /// LogIn the <paramref name="email"/> account instance.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public LoginResult Login(string email, string password) {
            // validate any existing open session instance
            if (LifeTracker.Services.IAM.UserSessionSingleton.Instance.IsLogged())
                throw new Exception("There is already a user session registered");

            // validate username (email)
            var user = _crud.GetAllWithPermission().Where(u => u.Email.ToLower().Equals(email.ToLower())).FirstOrDefault();
            if (user == null)
                throw new LoginException(LoginResult.InvalidUser);

            // validate password
            if (!DecryptPassword(user.Password).Equals(password))
                throw new LoginException(LoginResult.InvalidPassword);
            else {
                LifeTracker.Services.IAM.UserSessionSingleton.Instance.LogIn(user);
                return LoginResult.ValidUser;
            }
        }

        public void SetDefaultUsers() {
            // Roles
            _userRoleBLL.SetDefaultUserRoles();

            // Users
            var user1 = new User() {
                Email = "admin@lifetracker.com",
                Password = EncryptPassword("123"),
                Age = 34,
                Gender = Gender.Male,
                Weight = 81.3m,
                Height = 79.1m,
                Allergic = false,
                Allergies = string.Empty,
                Intensity = Intensity.Medium,
                Availability_In_Hours = 3,
                Objective = Objective.None,
                MaxCalories = 3000,
                DietCount = 0
            };
            var userRole1 = _userRoleBLL.GetAll().Where(x => x.Name.Contains("Administrador")).FirstOrDefault();
            user1.Permissions.Add(userRole1);
            _crud.Save(user1);
            saveUserCustomizedServices(user1);

            var user2 = new User() {
                Email = "rlabarile@client.com",
                Password = EncryptPassword("123"),
                Age = 27,
                Gender = Gender.Male,
                Weight = 61.3m,
                Height = 89.1m,
                Allergic = false,
                Allergies = string.Empty,
                Intensity = Intensity.Soft,
                Availability_In_Hours = 1,
                Objective = Objective.Load_Meals,
                MaxCalories = 3400,
                DietCount = 2.3m
            };
            var userRole2 = _userRoleBLL.GetAll().Where(x => x.Name.Contains("Cliente")).FirstOrDefault();
            user2.Permissions.Add(userRole2);
            _crud.Save(user2);
            saveUserCustomizedServices(user2);

            var user3 = new User() {
                Email = "rlabarile@clientpremium.com",
                Password = EncryptPassword("123"),
                Age = 34,
                Gender = Gender.Male,
                Weight = 83.4m,
                Height = 82.0m,
                Allergic = false,
                Allergies = string.Empty,
                Intensity = Intensity.Hard,
                Availability_In_Hours = 5,
                Objective = Objective.Load_Meals,
                MaxCalories = 3600,
                DietCount = 3.1m
            };
            var userRole3 = _userRoleBLL.GetAll().Where(x => x.Name.Contains("Cliente Premium")).FirstOrDefault();
            user3.Permissions.Add(userRole2);
            user3.Permissions.Add(userRole3); // a user with multiples roles
            _crud.Save(user3);
            saveUserCustomizedServices(user3);

            var user4 = new User() {
                Email = "rlabarile@professional.com",
                Password = EncryptPassword("123"),
                Age = 34,
                Gender = Gender.Male,
                Weight = 83.4m,
                Height = 82.0m,
                Allergic = false,
                Allergies = string.Empty,
                Intensity = Intensity.Hard,
                Availability_In_Hours = 5,
                Professional = true,
                Objective = Objective.None,
                MaxCalories = 2500,
                DietCount = 0
            };
            var userRole4 = _userRoleBLL.GetAll().Where(x => x.Name.Contains("Nutricionista")).FirstOrDefault();
            user4.Permissions.Add(userRole4);
            _crud.Save(user4);
            saveUserCustomizedServices(user4);
        }

        public void CreateUser(string username, string password, bool professional) {
            var user = new User() {
                Email = username,
                Password = EncryptPassword(password),
                Professional = professional
            };
            var userRole1 = _userRoleBLL.GetAll().Where(x => x.Name.Contains("Cliente")).FirstOrDefault(); // by default, assign "Cliente" role
            user.Permissions.Add(userRole1);
            _crud.Save(user);
            saveUserCustomizedServices(user);
        }

        public void EditUser(User user) {
            AddRolePermissions(user);
        }

        public void RemoveUser(User user) {
            _crud.Delete(user);
            deleteUserCustomizedServices(user);
        }

        public decimal GetMaxCalories(User user) {
            return user.MaxCalories;
        }

        public Objective GetUserObjective(User user) {
            return user.Objective;
        }

        #region [ Add & Remove Permissions At Role Level ]
        /// <summary>
        /// Add <paramref name="user"/> role permission at User Role level.
        /// </summary>
        /// <param name="user"></param>
        public void AddRolePermissions(User user) {
            deleteUserCustomizedServices(user);
            _crud.Save(user);
            user = (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            saveUserCustomizedServices(user);
        }

        /// <summary>
        ///  Removes the permissions at User Role level.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="userRole"></param>
        /// <returns></returns>
        public User RemoveRolePermission(User user, UserRole userRole) {
            var _user = _crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            var _userPermission = _user.Permissions;
            var _userPermissionDel = _userPermission.Where(x => x.Id == userRole.Id).FirstOrDefault();

            deleteUserCustomizedServices((User)_user);
            _user.Permissions.Remove(_userPermissionDel);
            _crud.Save(_user);
            _user = (User)_crud.GetAll().Where(x => x.Email == _user.Email).FirstOrDefault();
            saveUserCustomizedServices((User)_user);

            // refresh and return the updated user
            return (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
        }
        #endregion

        #region [ Add & Remove Custom Permissions At Role Level ]
        /// <summary>
        /// Add <paramref name="user"/> custom permission to user.
        /// </summary>
        /// <param name="user"></param>
        public void AddCustomPermissions(User user) {
            var userSaved = user;

            deleteUserCustomizedServices(user);
            _crud.Save(user);
            user = (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            user.RemovePermission(user.Permissions.Where(x => x.Name == "User Permission").FirstOrDefault());
            user.AddPermission(userSaved.Permissions.Where(x => x.Name == "User Permission").FirstOrDefault());
            saveUserCustomizedServices(user);
        }

        public void RemoveCustomPermission(User user, UserRole userRole) {
            deleteUserCustomizedServices(user);
            var _userPermission = user.Permissions;
            user.RemovePermission(user.Permissions.Where(x => x.Name == "User Permission").FirstOrDefault());
            user.AddPermission(userRole);
            user = (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            saveUserCustomizedServices((User)user);
        }
        #endregion

        #region [ Common Methods for Permissions ]
        private void saveUserCustomizedServices(User user) {
            if (user.Id.ToString() == "00000000-0000-0000-0000-000000000000") {
                user = (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            }

            var userServices = GetCustomPermissions(user);
            var userServiceType = new LifeTracker.Core.BE.UserServiceType { User = user, ServiceTypes = userServices };
            _userServiceTypeBLL.Save(userServiceType);
        }

        /// <summary>
        /// Delete all customized services for a given <paramref name="user"/>.
        /// </summary>
        /// <param name="user"></param>
        private void deleteUserCustomizedServices(User user) {
            if (user.Id.ToString() == "00000000-0000-0000-0000-000000000000") {
                user = (User)_crud.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
            }

            var userServices = GetCustomPermissions(user);
            var userServiceType = new LifeTracker.Core.BE.UserServiceType { User = user, ServiceTypes = userServices };
            _userServiceTypeBLL.Delete(userServiceType);
        }

        public List<IPermission> GetPermissions(User user) {
            var userServices = new List<IPermission>();
            foreach (var userRole in user.Permissions) {
                foreach (var service in userRole.Children()) {
                    bool valid = true;
                    foreach (var lookForService in userServices) {
                        if (lookForService.Name == service.Name) {
                            valid = false;
                            break;
                        }
                    }
                    if (valid)
                        userServices.Add(service);
                }
            }
            return userServices;
        }

        public List<IPermission> GetCustomPermissions(User user) {
            List<IPermission> allCustomPermissions = new List<IPermission>();

            // Get only user custom services
            foreach (var userRole in user.Permissions) {
                var role = (UserRole)userRole;
                foreach (var permission in role.Permissions) {
                    if (role.Name == "User Permission") {
                        if (allCustomPermissions.Find(x => x.Name == permission.Name) == null)
                            allCustomPermissions.Add(permission);
                    }
                }
            }
            return allCustomPermissions;
        }

        public bool PermissionsExists(IList<IPermission> permissions) {
            bool hasAlreadyCustomPermissions = false;
            foreach (var permission in permissions) {
                if (permission.Name == "User Permission") {
                    hasAlreadyCustomPermissions = true;
                    return hasAlreadyCustomPermissions;
                }
            }
            return hasAlreadyCustomPermissions;
        }

        #endregion

        #region Encryption
        public string EncryptPassword(string password) {
            var encryptedPassword = Crypto.EncryptStringAES(password, "LifeTracker_Encryption");
            return encryptedPassword;
        }

        public string DecryptPassword(string password) {
            var decryptedPassword = Crypto.DecryptStringAES(password, "LifeTracker_Encryption");
            return decryptedPassword;
        }
        #endregion

    }

}
