using LifeTracker.Core.Interfaces;
using System.Collections.Generic;

namespace LifeTracker.Core.BLL
{
    public class ServiceTypeBLL : CrudBLL<IServiceType> {

        public ServiceTypeBLL() {
            _crud = new LifeTracker.DataAccess.Mapper.ServiceType();
        }

        public void SetDefaultServices() {
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Home", Description = "Home Dashboards" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Activity", Description = "User Activity" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Challenge", Description = "User Challenges" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "IAM", Description = "Identity Access Management" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Professional", Description = "Professional Consultancy" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Backup", Description = "System Backup" });
            _crud.Save(new LifeTracker.Services.IAM.Composite2.ServiceType() { Name = "Settings", Description = "User Settings" });
        }
    }
}
