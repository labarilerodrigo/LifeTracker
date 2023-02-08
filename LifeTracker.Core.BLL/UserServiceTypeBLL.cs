using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;

namespace LifeTracker.Core.BLL
{
    public class UserServiceTypeBLL : CrudBLL<UserServiceType> {

        private UserRoleBLL _userRoleBLL;
        private ServiceTypeBLL _ServiceTypeBLL;

        public UserServiceTypeBLL() {
            _crud = new LifeTracker.DataAccess.Mapper.UserServiceType();
            _userRoleBLL = new UserRoleBLL();
            _ServiceTypeBLL = new ServiceTypeBLL();
        }

    }

}
