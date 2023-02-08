using LifeTracker.DataAccess.Mapper;
using LifeTracker.Services.IAM;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace LifeTracker.Core.BLL
{
    public class BackupBLL {

        private Backup _backupMpp;
        private string _xmlBackupDb;
        private const string _backupExtension = ".bkp";

        public BackupBLL() {
            _backupMpp = new Backup();
            _xmlBackupDb = ConfigurationManager.AppSettings["lifetracker.db.xml.backup.path"];
        }

        public void Backup(string name) {
            // persist the backup data
            var _dateTime = DateTime.UtcNow.ToString("yyyy-MM-dd HH.mm.ss.fff", CultureInfo.InvariantCulture);
            _dateTime = _dateTime.Replace(" ", "_");
            var _backupKey = "System_Backup_" + name.Replace(" ", "_") + "_" +_dateTime;
            var _fileName = _xmlBackupDb + _backupKey + _backupExtension;
            var _backupFolder = _xmlBackupDb + _backupKey;
            var _backup = new LifeTracker.Core.BE.Backup() { 
                Name = name, 
                Directory = _backupFolder, 
                Filename = _fileName, 
                UserEmail = UserSessionSingleton.Instance.User.Email, 
                Operation = BE.Operation.Backup };

            _backupMpp.Save(_backup);

            // call the backup service
            LifeTracker.Services.Backup.XmlDb.Backup(_backup);
        }

        public void Restore(string id) {
            var _backup = _backupMpp.GetAll().Where(x => x.UserId.ToString().Contains(id)).FirstOrDefault();
            _backup.Operation = BE.Operation.Restore;
            _backup.TimeStamp = DateTime.Now;
            _backup.UserEmail = UserSessionSingleton.Instance.User.Email;
            _backupMpp.Save(_backup);

            // call the restore service
            LifeTracker.Services.Backup.XmlDb.Restore(_backup);
        }

        public IList<LifeTracker.Core.BE.Backup> GetAllBackup() {
            return _backupMpp.GetAll();
        }

    }
}
