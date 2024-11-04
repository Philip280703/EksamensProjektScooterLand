namespace ScooterLandWinForms
{
    public partial class Form1 : Form
    {
        private readonly BackupKopieringService backupKopieringService;
        public Form1()
        { 
            InitializeComponent();
            backupKopieringService = new BackupKopieringService();
        }

        private void buttonSelectFolder_Click(object sender, EventArgs e)
        {
            string sourcePath = backupKopieringService.SelectFolder("Vælg folder eller element til kopiering.");
            if (sourcePath != null)
            {
                backupKopieringService.SetSourceFolderPath(sourcePath);
                textBoxFrom.Text = sourcePath;
            }
        }

        private void buttonBackupLocation_Click(object sender, EventArgs e) 
        {
            string sourcePath = backupKopieringService.SelectFolder("vælg placering for back-up");
            if (sourcePath != null)
            {
                backupKopieringService.SetDestinationFolderPath(sourcePath);
                textBoxUSB.Text = sourcePath;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e) 
        {
            if (backupKopieringService.CreateBatchFile())
            {
                MessageBox.Show("Back-up er nu gennemført :).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backupKopieringService.ExecuteBatchFile();
            }
            else
            {
                MessageBox.Show("Fejl! Sikre at begge destinationer passer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
