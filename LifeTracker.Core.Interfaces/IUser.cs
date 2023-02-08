
using System;
using System.Collections.Generic;

namespace LifeTracker.Core.Interfaces
{
    public interface IUser : IEntity {

        new Guid Id { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        IList<IPermission> Permissions { get; set; }

        // User Personal Data
        int Age { get; set; }
        Gender Gender { get; set; }
        decimal Weight { get; set; }
        decimal Height { get; set; }
        bool Allergic { get; set; }
        string Allergies { get; set; }
        Intensity Intensity { get; set; }
        int Availability_In_Hours { get; set; }
        bool Professional { get; set; }
        Objective Objective { get; set; }
        decimal MaxCalories { get; set; }
        decimal DietCount { get; set; }

    }

    public enum Gender {
        Male,
        Female
    }

    public enum Intensity {
        Soft,
        Medium,
        Hard
    }

    public enum Objective {
        None,
        Increase_Weight,
        Decrease_Weight,
        Keep_Same_Weight,
        Load_Meals
    }


}

