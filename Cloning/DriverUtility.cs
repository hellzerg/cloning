using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace Cloning
{
    public class DriverUtility
    {
        string windowsRoot;
        string systemRoot;

        public DriverUtility()
        {
            windowsRoot = Environment.GetEnvironmentVariable("SystemRoot") + "\\";
            systemRoot = windowsRoot + "system32\\";
        }

        public ArrayList ListDrivers(bool showMicrosoft)
        {
            ArrayList driverList = new ArrayList();

            RegistryKey regDeviceGUIDs = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\");
            string[] deviceGUIDs = regDeviceGUIDs.GetSubKeyNames();

            foreach (string deviceGUID in deviceGUIDs)
            {

                RegistryKey regDevice = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\" + deviceGUID);
                string[] regDeviceSubkeys = regDevice.GetSubKeyNames();

                foreach (string regDriverNumber in regDeviceSubkeys)
                {
                    string tmpProvider = "", tmpDesc = "";
                    try
                    {
                        RegistryKey regDriver = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\" + deviceGUID + "\\" + regDriverNumber);

                        try
                        {
                            tmpDesc = regDriver.GetValue("DriverDesc").ToString();
                            tmpProvider = regDriver.GetValue("ProviderName").ToString();
                        }
                        catch { }

                        if (tmpProvider.Length > 0 && tmpDesc.Length > 0)
                        {
                            if (tmpProvider != "Microsoft")
                            {
                                driverList.Add(
                                    new DriverInfo(tmpProvider, tmpDesc, deviceGUID, regDriverNumber)
                                );
                            }
                            else
                            {
                                if (showMicrosoft)
                                {
                                    driverList.Add(
                                        new DriverInfo(tmpProvider, tmpDesc, deviceGUID, regDriverNumber)
                                    );
                                }
                            }

                        }
                        regDriver.Close();
                    }
                    catch { }
                    
                    regDevice.Close();
                }
            }

            regDeviceGUIDs.Close();

            return driverList;
        }

        public void BackupDriver(string classGUID, string driverID, string backupLocation)
        {
            string infFile, infFilePath;
            string driverDesc;

            RegistryKey regDriverType = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\" + classGUID);
            string driverType = regDriverType.GetValue("Class").ToString();

            RegistryKey driverInfo = Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\Class\\" + classGUID + "\\" + driverID);
            driverDesc = driverInfo.GetValue("DriverDesc").ToString();
            infFile = driverInfo.GetValue("InfPath").ToString();
            infFilePath = windowsRoot + "inf\\" + infFile.ToString();

            if (driverType.Length > 0)
            {
                Directory.CreateDirectory(backupLocation + driverType);
            }
            Directory.CreateDirectory(backupLocation + driverType + "\\" + driverDesc);

            try
            {
                FileSystem.CopyFile(infFilePath, backupLocation + driverType + "\\" + driverDesc + "\\" + infFile, UIOption.AllDialogs, UICancelOption.DoNothing);
            }
            catch { }

            IniFile driverIniFile = new IniFile();
            List<string> driverFiles = driverIniFile.GetKeys(infFilePath, "SourceDisksFiles");

            foreach (string driverFile in driverFiles)
            {
                try
                {
                    if (driverFile.Split('.').Length > 1)
                    {

                        if (driverFile.Split('.')[1] == "hlp")
                        {
                            FileSystem.CopyFile(windowsRoot + "Help\\" + driverFile, backupLocation + driverType + "\\" + driverDesc + "\\" + driverFile, UIOption.AllDialogs, UICancelOption.DoNothing);
                        }
                        else if (driverFile.Split('.')[1] == "sys")
                        {
                            FileSystem.CopyFile(systemRoot + "drivers\\" + driverFile, backupLocation + driverType + "\\" + driverDesc + "\\" + driverFile, UIOption.AllDialogs, UICancelOption.DoNothing);
                        }
                        else
                        {
                            FileSystem.CopyFile(systemRoot + driverFile, backupLocation + driverType + "\\" + driverDesc + "\\" + driverFile, UIOption.AllDialogs, UICancelOption.DoNothing);
                        }
                    }
                }
                catch { }
            }


            regDriverType.Close();
            driverInfo.Close();
        }
    }
}
