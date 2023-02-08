
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM.Composite2;
using System.Linq;

namespace LifeTracker.Core.BLL
{
    public class SettingsBLL {

        private User _user;
        private UserBLL _userBLL;

        public SettingsBLL() {
            _user = new User();
            _userBLL = new UserBLL();
        }

        public void Save(IUser user) {
            _userBLL.EditUser((User)user);
        }

        public User Refresh(IUser user) {
            return (User)_userBLL.GetAll().Where(x => x.Email == user.Email).FirstOrDefault();
        }

    }
}
