using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace MobileDevice.Helper
{
    public class DLLHelper
    {
        /// <summary>
        /// Get the iTunesMobileDeviceDll location
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GetiTunesMobileDeviceDllPath()
        {
            //Judging the registry
            RegistryKey subkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Apple Inc.\Apple Mobile Device Support\Shared");
            if (subkey != null)
            {
                string path = subkey.GetValue("iTunesMobileDeviceDLL") as string;
                if (!string.IsNullOrWhiteSpace(path))
                {
                    FileInfo file = new FileInfo(path);
                    if(file.Exists)
                    {
                        return file.DirectoryName;
                    }
                }
            }
            //Judge common path
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + @"\Apple\Mobile Device Support";//Judge 64 bits
            if (File.Exists(directory + @"\iTunesMobileDevice.dll"))
            {
                return directory;
            }
            directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\Apple\Mobile Device Support";//For older versions of iTunes64
            if (File.Exists(directory + @"\iTunesMobileDevice.dll"))
            {
                return directory;
            }
            return string.Empty;
        }

        /// <summary>
        /// Get the AppleApplicationSupport directory
        /// </summary>
        /// <returns>System.String.</returns>
        public static string GetAppleApplicationSupportFolder()
        {
            //Judging the registry
            RegistryKey subkey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Apple Inc.\Apple Application Support");
            if (subkey != null)
            {
                string path = subkey.GetValue("InstallDir") as string;
                if (!string.IsNullOrWhiteSpace(path))
                {
                    return path;
                }
            }
            //Judging common paths
            string directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles) + @"\Apple\Apple Application Support\";//Judge 64 bits
            if (!File.Exists(directory + @"\CoreFoundation.dll"))
            {
                return directory;
            }
            directory = Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86) + @"\Apple\Apple Application Support\";//For older versions of iTunes64
            if (!File.Exists(directory + @"\CoreFoundation.dll"))
            {
                return directory;
            }
            return string.Empty;
        }
    }
}
