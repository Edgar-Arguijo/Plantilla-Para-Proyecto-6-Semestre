using System;
using System.IO;
using System.Configuration;

namespace Plantilla_Bonita
{   
    /// <summary>
    /// Clase de proteccion / encriptacion de la cadena de conexion
    /// </summary>
    public class ConnectionProtection
    {
        public string FileName { get; set; }
        /// <summary>
        /// Determine if configuration file exists for application
        /// </summary>
        /// <param name="FileName">Current executable and path</param>
        public ConnectionProtection(string FileName)
        {
            if (!File.Exists(string.Concat(FileName, ".config")))
            {
                throw new FileNotFoundException(string.Concat(FileName, ".config"));
            }

            this.FileName = FileName;
        }
        /// <summary>
        /// Encriptar ConnectionString
        /// </summary>
        /// <param name="encrypt"></param>
        /// <param name="fileName"></param>
        /// <returns>Si se realizo correctamente</returns>
        private bool EncryptConnectionString(bool encrypt, string fileName)
        {
            bool success = true;
            Configuration configuration = null;

            try
            {
                configuration = ConfigurationManager.OpenExeConfiguration(fileName);
                var configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;

                if ((!(configSection.ElementInformation.IsLocked)) && (!(configSection.SectionInformation.IsLocked)))
                {
                    if (encrypt && (!configSection.SectionInformation.IsProtected))
                    {
                        //Se encripta el archivo
                        configSection.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    }

                    if ((!encrypt) && configSection.SectionInformation.IsProtected) //encrypt is true so encrypt
                    {
                        //Se desencripta el archivo
                        configSection.SectionInformation.UnprotectSection();
                    }

                    configSection.SectionInformation.ForceSave = true;
                    configuration.Save();

                    success = true;

                }
            }
            catch (Exception ex)
            {
                success = false;
            }

            return success;

        }
        public bool IsProtected()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(FileName);
            var configSection = configuration.GetSection("connectionStrings") as ConnectionStringsSection;
            return configSection.SectionInformation.IsProtected;
        }
        public bool EncryptFile()
        {
            if (File.Exists(FileName))
            {
                return EncryptConnectionString(true, FileName);
            }
            else
            {
                return false;
            }
        }

        public bool DecryptFile()
        {
            if (File.Exists(FileName))
            {
                return EncryptConnectionString(false, FileName);
            }
            else
            {
                return false;
            }
        }

    }
}
