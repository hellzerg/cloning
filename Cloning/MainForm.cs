using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloning
{
    public partial class MainForm : Form
    {
        internal string CurrentBackupPath = Options.DataFolder + Utilities.NowShort + "\\";
        internal string CurrentRestorePath = "";

        List<Addon> addons = new List<Addon>();
        internal List<Addon> selectedAddons = new List<Addon>();

        SevenZip zip7 = new SevenZip();
        AdobePhotoshop photoshop = new AdobePhotoshop();
        AdobeReader reader = new AdobeReader();
        BitTorrent bt = new BitTorrent();
        BSPlayer bs = new BSPlayer();
        CCleaner cc = new CCleaner();
        ClassicShell cshell = new ClassicShell();
        FileZilla filezilla = new FileZilla();
        Foobar2000 foo = new Foobar2000();
        GoogleChrome chrome = new GoogleChrome();
        IrfanView iview = new IrfanView();
        JDownloader2 jdownloader = new JDownloader2();
        LibreOffice libre = new LibreOffice();
        MalwarebytesAntiMalware malware = new MalwarebytesAntiMalware();
        MaxthonCloudBrowser maxthon = new MaxthonCloudBrowser();
        MozillaFirefox ff = new MozillaFirefox();
        MozillaThunderbird tb = new MozillaThunderbird();
        NotepadPlusPlus npp = new NotepadPlusPlus();
        OpenOffice open = new OpenOffice();
        OperaBrowser opera = new OperaBrowser();
        PuTTY putty = new PuTTY();
        qBitTorrent qbt = new qBitTorrent();
        Skype carcinos = new Skype();
        Speccy speccy = new Speccy();
        Steam steam = new Steam();
        SublimeText sublime = new SublimeText();
        SumatraPDF pdf = new SumatraPDF();
        TeamSpeak ts = new TeamSpeak();
        TeamViewer tv = new TeamViewer();
        TeraCopy teracopy = new TeraCopy();
        uTorrent ut = new uTorrent();
        VivaldiBrowser vivaldi = new VivaldiBrowser();
        VLCMediaPlayer vlc = new VLCMediaPlayer();
        Winamp winamp = new Winamp();
        WinRAR rar = new WinRAR();
        WinZip zip = new WinZip();
        WireShark ws = new WireShark();

        bool SelectAllFlag = true;

        private string GetOS()
        {
            return (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "");
        }

        private string GetBitness()
        {
            string bitness = "";

            if (Environment.Is64BitOperatingSystem == true)
            {
                bitness = "You are working with 64-bit architecture";
            }
            else
            {
                bitness = "You are working with 32-bit architecture";
            }

            return bitness;
        }

        public MainForm()
        {
            InitializeComponent();
            Options.ApplyTheme(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (applist.CheckedItems.Count > 0)
            {
                if (!Directory.Exists(CurrentBackupPath))
                {
                    Directory.CreateDirectory(CurrentBackupPath);
                }

                for (int i = 0; i < applist.Items.Count; i++)
                {
                    if (applist.GetItemChecked(i))
                    {
                        selectedAddons.Add(addons[i]);
                    }
                }

                CloneHelper f = new CloneHelper(this, CloneType.Backup);
                f.ShowDialog(this);
            }
        }

        private void InitializeAddons()
        {
            addons.Add(zip7);
            addons.Add(photoshop);
            addons.Add(reader);
            addons.Add(bt);
            addons.Add(bs);
            addons.Add(cc);
            addons.Add(cshell); 
            addons.Add(filezilla);
            addons.Add(foo);
            addons.Add(chrome);
            addons.Add(iview);
            addons.Add(jdownloader);
            addons.Add(libre);
            addons.Add(malware);
            addons.Add(maxthon);
            addons.Add(ff);
            addons.Add(tb);
            addons.Add(npp);
            addons.Add(open);
            addons.Add(opera);
            addons.Add(putty);
            addons.Add(qbt);
            addons.Add(carcinos);
            addons.Add(speccy);
            addons.Add(steam);
            addons.Add(sublime);
            addons.Add(pdf);
            addons.Add(ts);
            addons.Add(tv);
            addons.Add(teracopy);
            addons.Add(ut);
            addons.Add(vivaldi);
            addons.Add(vlc);
            addons.Add(winamp);
            addons.Add(rar);
            addons.Add(zip);
            addons.Add(ws);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            
            Program._main = this;
            lblversion.Text = "Version: " + Program.GetCurrentVersionToString();
            lblos.Text = "Microsoft " + GetOS();
            lblbitness.Text = GetBitness();
            InitializeAddons();

            if (applist.Items.Count > 0)
            {
                applist.SetSelected(0, true);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AboutForm f = new AboutForm();
            f.ShowDialog(this);
        }

        private void applist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (applist.SelectedIndices.Count > 0)
            {
                apptxt.Text = addons[applist.SelectedIndex].Title;
                descriptiontxt.Text = addons[applist.SelectedIndex].Info;
                versiontxt.Text = addons[applist.SelectedIndex].Version;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (SelectAllFlag)
            {
                SelectAll(true);
                linkLabel1.Text = "Deselect all";
            }
            if (!SelectAllFlag)
            {
                SelectAll(false);
                linkLabel1.Text = "Select all";
            }

            SelectAllFlag = !SelectAllFlag;
            linkLabel1.Cursor = Cursors.Hand;
        }

        private void SelectAll(bool flag)
        {
            for (int i = 0; i < applist.Items.Count; i++)
            {
                applist.SetItemChecked(i, flag);
            }
        }

        private void SelectInstalled()
        {
            for (int i = 0; i < addons.Count; i++)
            {
                applist.SetItemChecked(i, addons[i].IsInstalled());
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectAll(false);
            SelectInstalled();
            linkLabel2.Cursor = Cursors.Hand;
        }

        private void applist_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int count = applist.CheckedItems.Count;

            if (e.NewValue == CheckState.Checked)
            {
                ++count;
            }
            if (e.NewValue == CheckState.Unchecked)
            {
                --count;
            }

            lblselectedapps.Text = count.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Options.SaveSettings();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OptionsForm f = new OptionsForm(this);
            f.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManagerForm f = new ManagerForm();
            f.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (applist.CheckedItems.Count > 0)
            {
                for (int i = 0; i < applist.Items.Count; i++)
                {
                    if (applist.GetItemChecked(i))
                    {
                        selectedAddons.Add(addons[i]);
                    }
                }

                SelectorForm f = new SelectorForm(this);
                f.ShowDialog(this);

                if (CurrentRestorePath != "")
                {
                    if (Directory.Exists(CurrentRestorePath))
                    {
                        CloneHelper f2 = new CloneHelper(this, CloneType.Restore);
                        f2.ShowDialog(this);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DriversForm f = new DriversForm();
            f.ShowDialog();
        }
    }
}
