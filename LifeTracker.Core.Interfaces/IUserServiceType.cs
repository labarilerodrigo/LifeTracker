namespace LifeTracker.Core.Interfaces
{
    public interface IUserServiceType {

        IUser User { get; set; }
        IServiceType ServiceType { get; set; }
    }
}
