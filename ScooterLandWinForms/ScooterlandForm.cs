using ScooterLandWinForms.Serivces;

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
            string sourcePath = backupKopieringService.SelectFolder("V�lg folder eller element til kopiering.");
            if (sourcePath != null)
            {
                backupKopieringService.SetSourceFolderPath(sourcePath);
                textBoxFrom.Text = sourcePath;
            }
        }

        private void buttonBackupLocation_Click(object sender, EventArgs e)
        {
            string sourcePath = backupKopieringService.SelectFolder("v�lg placering for back-up");
            if (sourcePath != null)
            {
                if(backupKopieringService.PathVerify(sourcePath) == false)
                {
                    MessageBox.Show("Der skal v�lges en mappe p� et usb-stik som back-up skal ligge p�", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    backupKopieringService.SetDestinationFolderPath(sourcePath);
                    textBoxUSB.Text = sourcePath;
                }
            
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            if (backupKopieringService.CreateBatFil())
            {
                if (backupKopieringService.CheckUsbstickName())
                {
					backupKopieringService.ExecuteBatchFile();
					MessageBox.Show("Back-up er nu gennemf�rt :).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
                else
                {
                    MessageBox.Show("Backup ikke gennemf�rt, usb-stikket er det samme som det sidst brugte", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Fejl! Sikre at begge destinationer passer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
