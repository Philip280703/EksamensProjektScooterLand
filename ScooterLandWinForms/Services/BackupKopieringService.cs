using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using Microsoft.Extensions.Options;
using ScooterLandWinForms.DataAccess;
using ScooterLandWinForms.Models;
using ScooterLandWinForms.Serivces;
using static System.Windows.Forms.LinkLabel;

namespace ScooterLandWinForms.Serivces
{
    public class BackupKopieringService
    {
        public string FolderPlaceringPath { get; private set; }
        public string DestinationPath { get; private set; }
        public string BatFilPath { get; set; }

        private List<UsbClass> UsbList;

        private DbHandler db;

        public BackupKopieringService()
        {
            db = new DbHandler();
            UsbList = db.GetUsbList();
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
            foreach (DriveInfo drive in drives)
            {
                if (drive.DriveType == DriveType.Removable && drive.IsReady)
                {
                    if(drive.VolumeLabel == "USB-DRIVE" && !UsbList[0].LastUsed)
                    {
                        UsbList[0].LastUsed = true;
                        UsbList[1].LastUsed = false;
                        db.UpdateUsbList(UsbList[0]);
                        db.UpdateUsbList(UsbList[1]);

                        return true;

                    }
                    if (drive.VolumeLabel == "USB" && !UsbList[1].LastUsed)
                    {
                        UsbList[0].LastUsed = false;
                        UsbList[1].LastUsed = true;
                        db.UpdateUsbList(UsbList[0]);
                        db.UpdateUsbList(UsbList[1]);

                        return true;

                    }
                    if((drive.VolumeLabel == "USB-DRIVE" && UsbList[0].LastUsed == true) 
                        || (drive.VolumeLabel == "USB" && UsbList[1].LastUsed == true))
                    {
                        MessageBox.Show("Dette usb stik er der den seneste backup ligger på. brug derfor det andet usb stik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                }

            }
            MessageBox.Show("Ikke gyldigt usb stik i systemet", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        
    }
}
