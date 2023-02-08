using LifeTracker.Core.Interfaces;

namespace LifeTracker.Core.BLL
{
    public class UserRoleBLL : CrudBLL<IUserRole> {

        ServiceTypeBLL _serviceTypeBLL;

        public UserRoleBLL() {
            this._crud = new LifeTracker.DataAccess.Mapper.UserRole();
            _serviceTypeBLL = new ServiceTypeBLL();
        }

        public void SetDefaultUserRoles() {
            // Get All Services
            _serviceTypeBLL.SetDefaultServices();
            var services = _serviceTypeBLL.GetAll();

            // Roles
            var role1 = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "Cliente" };
            role1.AddPermission(services[0]);
            role1.AddPermission(services[1]);
            role1.AddPermission(services[6]);
            _crud.Save(role1);

            var role2 = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "Cliente Premium" };
            role2.AddPermission(services[0]);
            role2.AddPermission(services[1]);
            role2.AddPermission(services[2]);
            role2.AddPermission(services[4]);
            role2.AddPermission(services[6]);
            _crud.Save(role2);

            var role3 = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "Nutricionista" };
            role3.AddPermission(services[0]);
            role3.AddPermission(services[4]);
            role3.AddPermission(services[6]);
            _crud.Save(role3);

            var role4 = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "Personal Trainer" };
            role4.AddPermission(services[0]);
            role4.AddPermission(services[4]);
            role4.AddPermission(services[6]);
            _crud.Save(role4);

            var role5 = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "Administrador" };
            role5.AddPermission(services[0]);
            role5.AddPermission(services[1]);
            role5.AddPermission(services[2]);
            role5.AddPermission(services[3]);
            role5.AddPermission(services[4]);
            role5.AddPermission(services[5]);
            role5.AddPermission(services[6]);
            _crud.Save(role5);
        }

        public void CreateCustomRole(IServiceType ServiceType) {
            var userRole = new LifeTracker.Services.IAM.Composite2.UserRole() { Name = "User Permission" };
            _crud.Save(userRole);
        }
    }
}
