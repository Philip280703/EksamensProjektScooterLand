﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScooterLandWinForms
{
    public class BackupKopieringService
    {
        public string FolderPlaceringPath {  get; private set; }
        public string DestinationPath { get; private set; }
        public string BatFilPath { get; set; }

        /// <summary>
        /// null-constructor instansiere bat-filens path, henter system mappe og kombinere de to, så batfilen kan placeres
        /// </summary>
        public BackupKopieringService()
        {
            BatFilPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "copy_to_usb.bat");
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
       /// metode som laver en bat-fil til at kunne kalde og gennemføre et xcopy
       /// </summary>
       /// <returns></returns>
        public bool CreateBatchFile()
        {
            if (string.IsNullOrEmpty(FolderPlaceringPath) || !Directory.Exists(FolderPlaceringPath))
                return false;

            if (string.IsNullOrEmpty(DestinationPath) || !Directory.Exists(DestinationPath))
                return false;

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
    }
}
