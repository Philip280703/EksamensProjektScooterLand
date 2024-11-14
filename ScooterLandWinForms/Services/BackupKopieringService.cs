using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScooterLandWinForms.Serivces;
using static System.Windows.Forms.LinkLabel;

namespace ScooterLandWinForms.Serivces
{
    public class BackupKopieringService
    {
        public string FolderPlaceringPath { get; private set; }
        public string DestinationPath { get; private set; }
        public string BatFilPath { get; set; }

        private bool usb1;
        private bool usb2;

        private List<string> UsbList;

        private string filePath;

        /// <summary>
        /// null-constructor instansiere bat-filens path, henter system mappe og kombinere de to, så batfilen kan placeres
        /// </summary>
        public BackupKopieringService()
        {
            BatFilPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "copy_to_usb.bat");

            string vp = Directory.GetCurrentDirectory();
            char backslash = '\\';
            string disc = vp.Split(backslash)[0];
            string user = vp.Split(backslash)[1];
            string name = vp.Split(backslash)[2];
            string sorce = vp.Split(backslash)[3];
            string repo = vp.Split(backslash)[4];
            string cl = vp.Split(backslash)[5];
            string classl = "ScooterLandWinForms";
            string folder = "Services";
            string fil = "UsbListBool.txt";

            filePath = disc + backslash + user + backslash + name + backslash + sorce + backslash + repo + backslash + cl + backslash + classl + backslash + folder +  backslash + fil;
            UsbList = GetTextFile(filePath);
        }

        /// <summary>
        /// vælger folder eller element som skal til kopiering. Den string som skal med er stien til det valgte element/folder
        /// </summary>
        /// <param name="description"></param>
        /// <returns></returns>
        public string SelectFolder(string description)
        {
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = description;
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    return folderBrowser.SelectedPath;
                }
            }
            return null;
        }


        /// <summary>
        /// metoder til at lave private set på atributterne, både nuværende folder og desitnations folder
        /// </summary>
        /// <param name="path"></param>
        public void SetSourceFolderPath(string path) => FolderPlaceringPath = path;
        public void SetDestinationFolderPath(string path) => DestinationPath = path;



        /// <summary>
        /// metode som laver en bat-fil til at kunne kalde og gennemføre et xcopy. dertil kalder den CheckUsbstickName() og returnere en bool
        /// </summary>
        /// <returns></returns>
        public bool CreateBatFil()
        {
            if (string.IsNullOrEmpty(FolderPlaceringPath) || !Directory.Exists(FolderPlaceringPath))
                return false;

            if (string.IsNullOrEmpty(DestinationPath) || !Directory.Exists(DestinationPath))
                return false;

            bool iSsucces = CheckUsbstickName();
            if (iSsucces)
            {

                string batchContent = $@"
                @echo off
                echo Copying {FolderPlaceringPath} to {DestinationPath}
                xcopy ""{FolderPlaceringPath}"" ""{DestinationPath}\{Path.GetFileName(FolderPlaceringPath)}"" /E /H /C /I /Y
                echo Copy complete.
                pause
                ";
                try
                {
                    File.WriteAllText(BatFilPath, batchContent);
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }

        /// <summary>
        /// metode eksekvere bat-filen
        /// </summary>
        public void ExecuteBatchFile()
        {
            if (File.Exists(BatFilPath))
            {
                System.Diagnostics.Process.Start(BatFilPath);
            }
        }

        /// <summary>
        /// setter en bool af hvilket usb stik som sidder i computeren
        /// </summary>
        public bool CheckUsbstickName()
        {
            
            DriveInfo[] drives = DriveInfo.GetDrives();
            SetUsbStikBools();
            foreach (DriveInfo drive in drives)
            {
                if(drive.DriveType == DriveType.Removable && drive.IsReady && drive.VolumeLabel == "USB-DRIVE")
                {
                    if(usb1 == false)
                    {
                        // her opdatere der bool for hvilken er brugt, både i de private bools til usb1 og usb2, men også i txt-filen
                        usb1 = true;
                        usb2 = false;
                      
                        using(StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create)))
                        {
                            writer.WriteLine("USB-1 er sidst brugte");
                            writer.WriteLine("1");
                            writer.WriteLine("0");
                        }

                        return true;
                    }

                    MessageBox.Show("Dette usb stik er der den seneste backup ligger på. brug derfor det andet usb stik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                if (drive.DriveType == DriveType.Removable && drive.IsReady && drive.VolumeLabel == "UsbStik")
                {
                    if(usb2 == false)
                    {
                        // her opdatere der bool for hvilken er brugt, både i de private bools til usb1 og usb2, men også i txt-filen
                        usb2 = true;
                        usb1 = false;

                        using (StreamWriter writer = new StreamWriter(new FileStream(filePath, FileMode.Create)))
                        {
                            writer.WriteLine("USB-2 er sidst brugte");
                            writer.WriteLine("0");
                            writer.WriteLine("1");
                        }
                        return true;
                    }
                    MessageBox.Show("Dette usb stik er der den seneste backup ligger på. brug derfor det andet usb stik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return false;

        }

        /// <summary>
        /// tjekker om den givende path til hvor backup skal placeres er på et D:, E: eller F: drev
        /// </summary>
        /// <param name="sourcePath"></param>
        /// <returns></returns>
        public bool PathVerify(string sourcePath)
        {
            if (sourcePath.Contains("D:") || sourcePath.Contains("E:") || sourcePath.Contains("F:"))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Denne statiske metode går ind og læser txt-filen, og insætter hver række til en liste
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        static List<string> GetTextFile(string filename) 
        { 
            List<string> result = new List<string>();
            try
            {
                if (!File.Exists(filename))
                {
                    throw new FileNotFoundException("The specified file was not found.", filename);
                }

                result.AddRange(File.ReadAllLines(filename));
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
                
            return result;


        }

        /// <summary>
        /// Denne metode går ind og sætter de lokale bools til at være den tilsvarende værdi, som står i txt-filen
        /// </summary>
        private void SetUsbStikBools()
        {
            if (UsbList[1] == "0")
            {
                usb1 = false;
            }
            else if (UsbList[2] == "1")
			{ 
                usb1 = true;
            }

            if (UsbList[2] == "0")
            {
                usb1 = false;
            }
            else if (UsbList[2] == "1")
			{
                usb1 = true;
            }

        }

        
    }
}
