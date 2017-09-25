using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using System.Windows.Forms;
using System.Reflection;

namespace Cloning
{
    public static class Utilities
    {
        internal static string RoamingAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        internal static string ProgramFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        internal static string ProgramFilesX86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        internal static string LocalAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        internal static string ProgramData = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);

        internal static string Now = DateTime.Now.ToLongDateString() + " - " + DateTime.Now.ToLongTimeString();
        internal static string NowShort = (DateTime.Now.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString()).Replace("/", "-").Replace(":", ".");

        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

        internal static void SetControlPropertyThreadSafe(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new SetControlPropertyThreadSafeDelegate
                (SetControlPropertyThreadSafe),
                new object[] { control, propertyName, propertyValue });
            }
            else
            {
                control.GetType().InvokeMember(
                    propertyName,
                    BindingFlags.SetProperty,
                    null,
                    control,
                    new object[] { propertyValue });
            }
        }

        internal static bool IsFolder(string path)
        {
            return ((File.GetAttributes(path) & FileAttributes.Directory) == FileAttributes.Directory);
        }

        internal static void CopyFolder(string source, string destination)
        {
            try
            {
                foreach (string folder in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(folder.Replace(source, destination));
                }

                foreach (string file in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
                {
                    File.Copy(file, file.Replace(source, destination), true);
                }
            }
            catch { }
        }

        internal static void CopyFile(string source, string destination)
        {
            try
            {
                File.Copy(source, destination, true);
            }
            catch { }
        }

        internal static void PortRegistryKey(string filePath, string registryPath, bool import)
        {
            string path = "\"" + filePath + "\"";
            string key = "\"" + registryPath + "\"";

            Process proc = new Process();
            try
            {
                proc.StartInfo.FileName = "regedit.exe";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.Verb = "runas";

                if (import == true)
                {
                    proc = Process.Start("regedit.exe", "/s " + path + " " + key);
                }
                else
                {
                    proc = Process.Start("regedit.exe", "/e " + path + " " + key);
                }


                proc.WaitForExit();
            }
            catch //(Exception ex)
            {
                proc.Dispose();
            }
        }

        public static bool KeyExists(string key)
        {
            bool keyExists = false;

            RegistryKey k = Registry.CurrentUser.OpenSubKey(key.Replace(@"HKEY_CURRENT_USER\", string.Empty));
            if (k != null)
            {
                keyExists = true;
            }

            RegistryKey k2 = Registry.LocalMachine.OpenSubKey(key.Replace(@"HKEY_LOCAL_MACHINE\", string.Empty));
            if (k2 != null)
            {
                keyExists = true;
            }

            return keyExists;
        }
    }
}
