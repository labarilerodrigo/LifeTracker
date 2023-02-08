using LifeTracker.Core.BE;
using LifeTracker.Core.Interfaces;
using LifeTracker.DataAccess.DAO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace LifeTracker.DataAccess.Mapper {

    public class Backup : ICrud<LifeTracker.Core.BE.Backup> {

        protected IList<LifeTracker.Core.BE.Backup> dataContext = new List<LifeTracker.Core.BE.Backup>();
        protected string xmlDb;

        public Backup() {
            xmlDb = ConfigurationManager.AppSettings["lifetracker.db.xml.path"] + "Backup.xml";
        }

        public void Delete(Core.BE.Backup entity) {
            throw new NotImplementedException();
        }

        public IList<LifeTracker.Core.BE.Backup> GetAll() {
            var listOfUserBackups = XmlSerializationBackup.GetAll(xmlDb);
            dataContext = new List<LifeTracker.Core.BE.Backup>();    // fresh data for dataContext

            foreach (var entry in listOfUserBackups) {
                var systemBackupId = entry[0].Item2;
                var systemUserEmail = entry[1].Item2;
                var systemOperation = entry[2].Item2;
                var systemBackupName = entry[3].Item2;
                var systemBackupDirectory = entry[4].Item2;
                var systemBackupFilename = entry[5].Item2;
                var timeStamp = entry[6].Item2;

                var backup = new LifeTracker.Core.BE.Backup() {
                    UserId = Guid.Parse(systemBackupId),
                    UserEmail = systemUserEmail,
                    Operation = (Operation)Enum.Parse(typeof(Operation), systemOperation),
                    Name = systemBackupName,
                    Directory = systemBackupDirectory,
                    Filename = systemBackupFilename,
                    TimeStamp = DateTime.Parse(timeStamp)
                };
                dataContext.Add(backup);
            }
            return dataContext;
        }

        public IList<Core.BE.Backup> GetAllWithPermission() {
            throw new NotImplementedException();
        }

        public LifeTracker.Core.BE.Backup GetId(Guid id) {
            return GetAll().Where(u => u.Id.Equals(id)).FirstOrDefault();
        }

        public void Save(LifeTracker.Core.BE.Backup entity) {
            Tuple<string, string, string, string, string, string, string> tuple = new Tuple<string, string, string, string, string, string, string>(
                entity.Id.ToString(), 
                entity.UserEmail, 
                entity.Operation.ToString(), 
                entity.Name, 
                entity.Directory, 
                entity.Filename, 
                entity.TimeStamp.ToString());

            var exists = XmlSerializationBackup.Exists(xmlDb, tuple);

            if (!exists)
                XmlSerializationBackup.SerializeNode(xmlDb, tuple);
        }

    }

} 
