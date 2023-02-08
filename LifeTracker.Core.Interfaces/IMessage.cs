
using System;
using System.ComponentModel.DataAnnotations;

namespace LifeTracker.Core.Interfaces
{
    public interface IMessage : IEntity {

        Guid MessageId { get; set; }
        string MessageText { get; set; }
        string MessageResponseText { get; set; }
        SubjectType Subject { get; set; }
        ProfessionalType ProfessionalType { get; set; }
        bool WasItAnswered { get; set; }
        DateTime Date { get; set; }
        string UserEmail { get; set; }
    }

    public enum SubjectType {
        Dieta,
        Rutina,
        Otros
    }

    public enum ProfessionalType {
        Nutricionista,
        [Display(Name = "Personal Trainer")]
        PersonalTrainer
    }
}
