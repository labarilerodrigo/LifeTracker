using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;
using LifeTracker.Services.IAM;
using System.Collections.Generic;
using System.Linq;

namespace LifeTracker.Core.BLL
{
    public class ProfessionalBLL {

        private LifeTracker.DataAccess.Mapper.Message _messageMpp;

        public ProfessionalBLL() {
            _messageMpp = new DataAccess.Mapper.Message();
        }

        public void Save(IMessage message) {
            _messageMpp.Save(message);
        }

        public IList<IMessage> GetAll() {
            // get unread messages
            return _messageMpp.GetAll();
        }

        public IList<IMessage> GetAllUnreadMessages() {
            // get unread messages
            return _messageMpp.GetAll().Where(x => x.WasItAnswered == false).ToList();
        }

    }
}
