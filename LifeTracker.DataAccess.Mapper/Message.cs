using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using System;
using System.Configuration;
using System.Collections.Generic;
using LifeTracker.DataAccess.Mapper.DTO;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper
{
    public class Message : ICrud<IMessage> {

        protected IList<IMessage> dataContext = new List<IMessage>();
        protected string xmlDb;

        public Message() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] +"Messages.xml";
    }

        public void Delete(IMessage entity) {
            var messageId = (entity.MessageId != null ? entity.MessageId.ToString() : entity.Id.ToString());
            var exists = XmlSerializationMessage.Exists(xmlDb, messageId); 
            
            if (exists) {
                dataContext = new List<IMessage>();    // fresh data for dataContext
                XmlSerializationMessage.RemoveNode(xmlDb, messageId);
                GetAll();
            }
        }

        public IList<IMessage> GetAll() {
            var listOfmessages = XmlSerializationMessage.GetAll(xmlDb);
            dataContext = new List<IMessage>();    // fresh data for dataContext

            foreach (var messages in listOfmessages) {
                var messagesId = messages[0];
                var professionalType = messages[1];
                var subject = messages[2];
                var messageText = messages[3];
                var messageResponseText = messages[4];
                var wasItAnsered = messages[5];
                var userEmail = messages[6];
                var timestamp = messages[7];

                LifeTracker.Core.BE.Message message = new LifeTracker.Core.BE.Message {
                    MessageId = Guid.Parse(messagesId),
                    ProfessionalType = (ProfessionalType)Enum.Parse(typeof(ProfessionalType), professionalType.ToString()),
                    Subject = (SubjectType)Enum.Parse(typeof(SubjectType), subject.ToString()),
                    MessageText = messageText,
                    MessageResponseText = messageResponseText,
                    WasItAnswered = Convert.ToBoolean(wasItAnsered),
                    UserEmail = userEmail,
                    Date = Convert.ToDateTime(timestamp)                    
                };
                dataContext.Add(message);
            }
            return dataContext;
        }

        public IList<IMessage> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public IMessage GetId(Guid id) {
            throw new NotImplementedException();
        }

        public void Save(IMessage entity) {
            var exists = XmlSerializationMessage.Exists(xmlDb, (entity.MessageId != null ? entity.MessageId.ToString() : entity.Id.ToString()));

            if(exists)
                Delete(entity);

            string[,] entries = new string[,] {
                { "messageId", entity.Id.ToString() },
                { "professionalType", entity.ProfessionalType.ToString() },
                { "subject", entity.Subject.ToString() },
                { "messageText", entity.MessageText },
                { "messageResponseText", entity.MessageResponseText },
                { "wasItAnsered", entity.WasItAnswered.ToString() },
                { "userEmail", entity.UserEmail },
                { "timestamp", DateTime.Now.ToString() }
            };
            XmlSerializationMessage.SerializeNode(xmlDb, entries);
        }

    }
}
