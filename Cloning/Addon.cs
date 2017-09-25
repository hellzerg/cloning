using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace Cloning
{
    public abstract class Addon
    {
        public string Title { get; set; }
        public string Info { get; set; }
        public string Version { get; set; }

        public virtual bool IsInstalled() { return false; }
        public virtual void Backup(string path) { }
        public virtual void Restore(string path) { }
    }

    public class SevenZip : Addon
    {
        public SevenZip()
        {
            Title = "7-Zip";
            Info = "Backup 7-Zip configuration";
        }
        public string Key = @"HKEY_CURRENT_USER\SOFTWARE\7-Zip";

        public override bool IsInstalled()
        {
            return Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {  
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class AdobePhotoshop : Addon
    {
        public AdobePhotoshop()
        {
            Title = "Adobe Photoshop";
            Version = "Compatible ONLY with CS5";
            Info = "Backup Adobe Photoshop settings";

            Fill();
        }

        public List<string> Folders = new List<string>();
        public List<string> Keys = new List<string>();

        private void Fill()
        {
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Adobe Photoshop CS5\Adobe Photoshop CS5 Settings");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\CameraRaw\Settings");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Color\Settings");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Color\Proofing");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Adobe Photoshop CS5\Adobe Photoshop CS5 Settings\Presets");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Adobe Photoshop CS5\Presets");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Save For Web\12.0");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\LensCorrection\1.0\Settings");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Plugins");
            Folders.Add(Utilities.RoamingAppData + @"\Adobe\Adobe Photoshop CS5\Adobe Photoshop CS5 Settings\Workspaces");

            Keys.Add(@"HKEY_CURRENT_USER\Software\Adobe\Camera Raw\6.0");
            Keys.Add(@"HKEY_CURRENT_USER\Software\Adobe\Photoshop\11.0");
            Keys.Add(@"HKEY_CURRENT_USER\Software\Adobe\Photoshop\12.0");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;
            bool b2 = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b1 = true;
                    break;
                }
            }

            foreach (string k in Keys)
            {
                if (Directory.Exists(k))
                {
                    b2 = true;
                    break;
                }
            }

            return b1 || b2;
        }

        public override void Backup(string path)
        {
            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, false);
            }
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }
        }

        public override void Restore(string path)
        {
            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, true);
            }
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }
        }
    }

    public class AdobeReader : Addon
    {
        public AdobeReader()
        {
            Title = "Adobe Reader";
            Version = "Compatible with all Versions from 9.x-11.x";
            Info = "Backup Adobe Reader configuration";
        }

        public string Folder = Utilities.RoamingAppData + @"\Adobe\Acrobat";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class BitTorrent : Addon
    {
        public BitTorrent()
        {
            Title = "BitTorrent";
            Info = "Backup BitTorrent settings";
        }
 
        public string Folder = Utilities.RoamingAppData + @"\BitTorrent";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class BSPlayer : Addon
    {
        public BSPlayer()
        {
            Title = "BSPlayer";
            Info = "Backup BSPlayer configuration";

            Fill();
        }

        public List<string> Folders = new List<string>();

        private void Fill()
        {
            Folders.Add(Utilities.ProgramFiles + @"\Webteh\BSPlayer");
            Folders.Add(Utilities.ProgramFilesX86 + @"\Webteh\BSPlayer");
        }

        public override bool IsInstalled()
        {
            bool b = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public override void Backup(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }
        }
    }

    public class ClassicShell : Addon
    {
        public ClassicShell()
        {
            Title = "Classic Shell";
            Info = "Backup Classic Shell configuration";
        }

        public string Key = @"HKEY_CURRENT_USER\Software\IvoSoft";

        public override bool IsInstalled()
        {
            return Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class CCleaner : Addon
    {
        public CCleaner()
        {
            Title = "CCleaner";
            Info = "Backup CCleaner configuration";

            Fill();
        }

        public List<string> Files = new List<string>();
        public List<string> Keys = new List<string>();

        private void Fill()
        {
            Files.Add(Utilities.ProgramFiles + @"\CCleaner\ccleaner.ini");
            Files.Add(Utilities.ProgramFilesX86 + @"\CCleaner\ccleaner.ini");
            Files.Add(Utilities.ProgramFiles + @"\CCleaner\winapp2.ini");
            Files.Add(Utilities.ProgramFilesX86 + @"\CCleaner\winapp2.ini");

            Keys.Add(@"HKEY_CURRENT_USER\Software\Piriform\CCleaner");
            Keys.Add(@"HKEY_LOCAL_MACHINE\SOFTWARE\Piriform\CCleaner");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;
            bool b2 = false;

            foreach (string f in Files)
            {
                if (File.Exists(f))
                {
                    b1 = true;
                    break;
                }
            }

            foreach (string k in Keys)
            {
                if (Utilities.KeyExists(k))
                {
                    b2 = true;
                    break;
                }
            }

            return b1 || b2;
        }

        public override void Backup(string path)
        {
            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, false);
            }

            foreach (string f in Files)
            {
                Utilities.CopyFile(f, path + Path.GetFileName(f));
            }
        }

        public override void Restore(string path)
        {
            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, true);
            }

            foreach (string f in Files)
            {
                Utilities.CopyFile(path + Path.GetFileName(f), f);
            }
        }
    }

    public class Foobar2000 : Addon
    {
        public Foobar2000()
        {
            Title = "Foobar2000";
            Info = "Backup Foobar2000 configuration";

            Fill();
        }

        public List<string> Folders = new List<string>();

        public void Fill()
        {
            Folders.Add(Utilities.RoamingAppData + @"\foobar2000");
            Folders.Add(Utilities.ProgramFiles + @"\foobar2000\components");
            Folders.Add(Utilities.ProgramFilesX86 + @"\foobar2000\components");
        }

        public override bool IsInstalled()
        {
            bool b = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public override void Backup(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }
        }
    }

    public class FileZilla : Addon
    {
        public FileZilla()
        {
            Title = "FileZilla";
            Info = "Backup FileZilla settings";
        }

        public string Folder = Utilities.RoamingAppData + @"\FileZilla";
        public string Key = @"HKEY_CURRENT_USER\Software\FileZilla";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder) || Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class GoogleChrome : Addon
    {
        public GoogleChrome()
        {
            Title = "Google Chrome";
            Info = "Backup Google Chrome profile";
        }

        public string Folder = Utilities.LocalAppData + @"\Google\Chrome\User Data";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class IrfanView : Addon
    {
        public IrfanView()
        {
            Title = "IrfanView";
            Info = "Backup IrfanView settings";
        }

        public string file = Utilities.RoamingAppData + @"\IrfanView\i_view32.ini";

        public override bool IsInstalled()
        {
            return File.Exists(file);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFile(file, path + Path.GetFileName(file));
        }

        public override void Restore(string path)
        {
            Utilities.CopyFile(path + Path.GetFileName(file), file);
        }
    }

    public class JDownloader2 : Addon
    {
        public JDownloader2()
        {
            Title = "JDownloader 2.0";
            Info = "Backup JDownloader configuration";
            Version = "Compatible ONLY with 2.xx";
        }

        public string Folder = Utilities.LocalAppData + @"\JDownloader v2.0\cfg";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class LibreOffice : Addon
    {
        public LibreOffice()
        {
            Title = "LibreOffice";
            Info = "Backup LibreOffice profile";
            Version = "Compatible with 3.xx - 5.xx";

            Fill();
        }

        public List<string> Folders = new List<string>();

        public void Fill()
        {
            Folders.Add(Utilities.RoamingAppData + @"\LibreOffice\5\user");
            Folders.Add(Utilities.RoamingAppData + @"\LibreOffice\4\user");
            Folders.Add(Utilities.RoamingAppData + @"\LibreOffice\3\user");
        }

        public override bool IsInstalled()
        {
            bool b = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public override void Backup(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }
        }
    }

    public class MalwarebytesAntiMalware : Addon
    {
        public MalwarebytesAntiMalware()
        {
            Title = "Malwarebytes Anti-Malware";
            Info = "Backup Malwarebytes Anti-Malware settings";
            Version = "Compatible ONLY with 2.xx";
        }

        public string Folder = Utilities.ProgramData + @"\Malwarebytes\Malwarebytes Anti-Malware\Configuration";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class MaxthonCloudBrowser : Addon
    {
        public MaxthonCloudBrowser()
        {
            Title = "Maxthon Cloud Browser";
            Info = "Backup Maxthon Cloud Browser profile";
        }

        public string Folder = Utilities.RoamingAppData + @"\Maxthon3";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class MozillaFirefox : Addon
    {
        public MozillaFirefox()
        {
            Title = "Mozilla Firefox";
            Info = "Backup Mozilla Firefox profile";
        }

        public string Folder = Utilities.RoamingAppData + @"\Mozilla";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class MozillaThunderbird : Addon
    {
        public MozillaThunderbird()
        {
            Title = "Mozilla Thunderbird";
            Info = "Backup Mozilla Thunderbird profile";
        }

        public string Folder = Utilities.RoamingAppData + @"\Thunderbird";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class NotepadPlusPlus : Addon
    {
        public NotepadPlusPlus()
        {
            Title = "Notepad++";
            Info = "Backup Notepad++ configuration";
        }

        public string Folder = Utilities.RoamingAppData + @"\Notepad++";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class OpenOffice : Addon
    {
        public OpenOffice()
        {
            Title = "OpenOffice";
            Info = "Backup OpenOffice profile";
            Version = "Compatible ONLY with 4.xx";
        }

        public string Folder = Utilities.RoamingAppData + @"\OpenOffice\4\user";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class OperaBrowser : Addon
    {
        public OperaBrowser()
        {
            Title = "Opera Browser";
            Info = "Backup Opera Browser profile";
        }

        public string Folder = Utilities.RoamingAppData + @"\Opera Software\Opera Stable";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class PuTTY : Addon
    {
        public PuTTY()
        {
            Title = "PuTTY";
            Info = "Backup PuTTY session list";
        }

        public string Key = @"HKEY_CURRENT_USER\Software\SimonTatham";

        public override bool IsInstalled()
        {
            return Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class qBitTorrent : Addon
    {
        public qBitTorrent()
        {
            Title = "qBitTorrent";
            Info = "Backup qBitTorrent configuration";
        }

        public string Folder = Utilities.RoamingAppData + @"\qBittorrent";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class Skype : Addon
    {
        public Skype()
        {
            Title = "Skype";
            Info = "Backup Skype profile";
        }

        public string Key = @"HKEY_CURRENT_USER\Software\Skype\Phone\UI";
        public string Folder = Utilities.RoamingAppData + @"\Skype";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder) || Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class Speccy : Addon
    {
        public Speccy()
        {
            Title = "Speccy";
            Info = "Backup Speccy configuration";

            Fill();
        }

        public List<string> Files = new List<string>();
        public List<string> Keys = new List<string>();

        public void Fill()
        {
            Files.Add(Utilities.ProgramFiles + @"\Speccy\Speccy.ini");
            Files.Add(Utilities.ProgramFilesX86 + @"\Speccy\Speccy.ini");

            Keys.Add(@"HKEY_CURRENT_USER\Software\Piriform\Speccy");
            Keys.Add(@"HKEY_LOCAL_MACHINE\SOFTWARE\Piriform\Speccy");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;
            bool b2 = false;

            foreach (string f in Files)
            {
                if (File.Exists(f))
                {
                    b1 = true;
                    break;
                }
            }

            foreach (string k in Keys)
            {
                if (Utilities.KeyExists(k))
                {
                    b2 = true;
                    break;
                }
            }

            return b1 || b2;
        }

        public override void Backup(string path)
        {
            foreach (string f in Files)
            {
                Utilities.CopyFile(f, path + Path.GetFileName(f));
            }

            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, false);
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Files)
            {
                Utilities.CopyFile(path + Path.GetFileName(f), f);
            }

            foreach (string k in Keys)
            {
                Utilities.PortRegistryKey(path + Title + ".reg", k, true);
            }
        }
    }

    public class Steam : Addon
    {
        public Steam()
        {
            Title = "Steam";
            Info = "Backup Steam installation folder";

            Fill();
        }

        public List<string> Folders = new List<string>();

        public void Fill()
        {
            Folders.Add(Utilities.ProgramFiles + @"\Steam\SteamApps");
            Folders.Add(Utilities.ProgramFilesX86 + @"\Steam\SteamApps");
        }

        public override bool IsInstalled()
        {
            bool b = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public override void Backup(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }
        }
    }

    public class SublimeText : Addon
    {
        public SublimeText()
        {
            Title = "Sublime Text";
            Info = "Backup Sublime Text settings";
            Version = "Compatible ONLY with 3.xx";
        }

        public string Folder = Utilities.RoamingAppData + @"\Sublime Text 3";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class SumatraPDF : Addon
    {
        public SumatraPDF()
        {
            Title = "SumatraPDF";
            Info = "Backup SumatraPDF settings";
        }
 
        public string file = Utilities.RoamingAppData + @"\SumatraPDF\SumatraPDF-settings.txt";

        public override bool IsInstalled()
        {
            return File.Exists(file);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFile(file, path + Path.GetFileName(file));
        }

        public override void Restore(string path)
        {
            Utilities.CopyFile(path + Path.GetFileName(file), file);
        }
    }

    public class TeamSpeak : Addon
    {
        public TeamSpeak()
        {
            Title = "TeamSpeak";
            Info = "Backup TeamSpeak configuration";
        }
      
        public string Folder = Utilities.RoamingAppData + @"\TS3Client";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class TeamViewer : Addon
    {
        public TeamViewer()
        {
            Title = "TeamViewer";
            Info = "Backup TeamViewer configuration";
        }
       
        public string Key = @"HKEY_CURRENT_USER\Software\TeamViewer";

        public override bool IsInstalled()
        {
            return Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class TeraCopy : Addon
    {
        public TeraCopy()
        {
            Title = "TeraCopy";
            Info = "Backup TeraCopy configuration";
        }
       
        public string Folder = Utilities.RoamingAppData + @"\Teracopy";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class uTorrent : Addon
    {
        public uTorrent()
        {
            Title = "uTorrent";
            Info = "Backup uTorrent configuration";

            Fill();
        }
       
        public List<string> Files = new List<string>();

        public void Fill()
        {
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\dht.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\dht_feed.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\resume.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\rss.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\settings.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\toolbar.benc");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\toolbar_offer.benc");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\updates.dat");
            Files.Add(Utilities.RoamingAppData + @"\uTorrent\utorrent.lng");
        }

        public override bool IsInstalled()
        {
            bool b = false;

            foreach (string f in Files)
            {
                if (File.Exists(f))
                {
                    b = true;
                    break;
                }
            }

            return b;
        }

        public override void Backup(string path)
        {
            foreach (string f in Files)
            {
                Utilities.CopyFile(f, path + Path.GetFileName(f));
            }
        }

        public override void Restore(string path)
        {
            foreach (string f in Files)
            {
                Utilities.CopyFile(path + Path.GetFileName(f), f);
            }
        }
    }

    public class VivaldiBrowser : Addon
    {
        public VivaldiBrowser()
        {
            Title = "Vivaldi Browser";
            Info = "Backup Vivaldi Browser profile";
        }
        
        public string Folder = Utilities.LocalAppData + @"\Vivaldi\User Data\Default";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class VLCMediaPlayer : Addon
    {
        public VLCMediaPlayer()
        {
            Title = "VLC Media Player";
            Info = "Backup VLC Media Player settings";
        }
        
        public string file = Utilities.RoamingAppData + @"\vlc\vlcrc";

        public override bool IsInstalled()
        {
            return File.Exists(file);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFile(file, path + Path.GetFileName(file));
        }

        public override void Restore(string path)
        {
            Utilities.CopyFile(path + Path.GetFileName(file), file);
        }
    }

    public class Winamp : Addon
    {
        public Winamp()
        {
            Title = "Winamp";
            Info = "Backup Winamp configuration";
        }
        
        public string Folder = Utilities.RoamingAppData + @"\Winamp";

        public override bool IsInstalled()
        {
            return Directory.Exists(Folder);
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
        }
    }

    public class WinRAR : Addon
    {
        public WinRAR()
        {
            Title = "WinRAR";
            Info = "Backup WinRAR configuration";

            Fill();
        }
        
        public string Folder = Utilities.RoamingAppData + @"\WinRAR";
        public string Key = @"HKEY_CURRENT_USER\Software\WinRAR";
        public List<string> Files = new List<string>();

        public void Fill()
        {
            Files.Add(Utilities.ProgramFiles + @"\WinRAR\rarreg.key");
            Files.Add(Utilities.ProgramFilesX86 + @"\WinRAR\rarreg.key");
        }

        public override bool IsInstalled()
        {
            bool b1 = false;
            bool b2 = Directory.Exists(Folder);
            bool b3 = Utilities.KeyExists(Key);

            foreach (string f in Files)
            {
                if (File.Exists(f))
                {
                    b1 = true;
                    break;
                }
            }

            return b1 || b2 || b3;
        }

        public override void Backup(string path)
        {
            Utilities.CopyFolder(Folder, path + Title);
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);

            foreach (string f in Files)
            {
                Utilities.CopyFile(f, path + Path.GetFileName(f));
            }
        }

        public override void Restore(string path)
        {
            Utilities.CopyFolder(path + Title, Folder);
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);

            foreach (string f in Files)
            {
                Utilities.CopyFile(path + Path.GetFileName(f), f);
            }
        }
    }

    public class WinZip : Addon
    {
        public WinZip()
        {
            Title = "WinZip";
            Info = "Backup WinZip configuration";
        }
     
        public string Key = @"HKEY_CURRENT_USER\Software\Nico Mak Computing\WinZip";

        public override bool IsInstalled()
        {
            return Utilities.KeyExists(Key);
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);
        }
    }

    public class WireShark : Addon
    {
        public WireShark()
        {
            Title = "WireShark";
            Info = "Backup WireShark configuration";

            Fill();
        }
        
        public string Key = @"HKEY_CURRENT_USER\Software\Wireshark\WinSparkle Settings";
        public List<string> Files = new List<string>();
        public List<string> Folders = new List<string>();

        public void Fill()
        {
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\wireshark.conf");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\cfilters");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\dfilters");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\disabled_protos");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\ethers");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\manuf");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\hosts");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\services");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\subnets");
            Files.Add(Utilities.ProgramFiles + @"\Wireshark\ipxnets");

            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\wireshark.conf");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\cfilters");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\dfilters");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\disabled_protos");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\ethers");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\manuf");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\hosts");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\services");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\subnets");
            Files.Add(Utilities.ProgramFilesX86 + @"\Wireshark\ipxnets");

            Folders.Add(Utilities.ProgramFiles + @"\Wireshark\profiles");
            Folders.Add(Utilities.ProgramFiles + @"\Wireshark\plugins");
            Folders.Add(Utilities.ProgramFilesX86 + @"\Wireshark\profiles");
            Folders.Add(Utilities.ProgramFilesX86 + @"\Wireshark\plugins");
        }

        public override bool IsInstalled()
        {
            bool b1 = Utilities.KeyExists(Key);
            bool b2 = false;
            bool b3 = false;

            foreach (string f in Folders)
            {
                if (Directory.Exists(f))
                {
                    b2 = true;
                    break;
                }
            }

            foreach (string f in Files)
            {
                if (File.Exists(f))
                {
                    b3 = true;
                    break;
                }
            }

            return b1 || b2 || b3;
        }

        public override void Backup(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, false);

            foreach (string f in Folders)
            {
                Utilities.CopyFolder(f, path + Title);
            }

            foreach (string f in Files)
            {
                Utilities.CopyFile(f, path + Path.GetFileName(f));
            }
        }

        public override void Restore(string path)
        {
            Utilities.PortRegistryKey(path + Title + ".reg", Key, true);

            foreach (string f in Folders)
            {
                Utilities.CopyFolder(path + Title, f);
            }

            foreach (string f in Files)
            {
                Utilities.CopyFile(path + Path.GetFileName(f), f);
            }
        }
    }
}

