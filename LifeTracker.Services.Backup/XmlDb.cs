using LifeTracker.Core.BE;
using System.Configuration;
using System.IO;
using System.Windows.Forms;

namespace LifeTracker.Services.Backup
{
    public static class XmlDb {

        private static string xmlDbPath = ConfigurationManager.AppSettings["lifetracker.db.xml.path"];

        public static void Backup(LifeTracker.Core.BE.Backup backup) {
            try {
                if (!Directory.Exists(backup.Directory))
                    Directory.CreateDirectory(backup.Directory);

                // Copy the files and overwrite destination files if they already exist. 
                string[] files = System.IO.Directory.GetFiles(xmlDbPath, "*.xml");
                foreach (string file in files) {
                    var fileName = System.IO.Path.GetFileName(file);
                    var destFile = System.IO.Path.Combine(backup.Directory, fileName);
                    File.Copy(file, destFile, true);
                }
            }
            catch (System.Exception ex) {
                MessageBox.Show("Backup service encountered a problem while backing up files.\n" + ex.Message);
            }
        }

        public static void Restore(LifeTracker.Core.BE.Backup backup) {
            try {
                if (!Directory.Exists(backup.Directory))
                    throw new System.Exception("Backup directory not found.");

                // Copy the files and overwrite destination files if they already exist. 
                string[] files = System.IO.Directory.GetFiles(backup.Directory, "*.xml");
                foreach (string file in files) {
                    var fileName = System.IO.Path.GetFileName(file);
                    var destFile = System.IO.Path.Combine(xmlDbPath, fileName);
                    if(fileName != "Backup.xml")
                        File.Copy(file, destFile, true);
                }
            }
            catch (System.Exception ex) {
                MessageBox.Show("Restore service encountered a problem while restoring the files.\n" + ex.Message);
            }
        }


    }
}
