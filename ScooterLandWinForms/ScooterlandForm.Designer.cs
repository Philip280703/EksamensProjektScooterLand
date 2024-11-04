namespace ScooterLandWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog1 = new FolderBrowserDialog();
            labelPath = new Label();
            textBoxFrom = new TextBox();
            label1 = new Label();
            textBoxUSB = new TextBox();
            label2 = new Label();
            buttonBackup = new Button();
            buttonSelectFolder = new Button();
            buttonBackupLocation = new Button();
            SuspendLayout();
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(165, 108);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(170, 20);
            labelPath.TabIndex = 0;
            labelPath.Text = "mappe / fil til kopiering:";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(237, 145);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.ReadOnly = true;
            textBoxFrom.Size = new Size(391, 27);
            textBoxFrom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 34);
            label1.Name = "label1";
            label1.Size = new Size(271, 46);
            label1.TabIndex = 2;
            label1.Text = "Back-up System";
            // 
            // textBoxUSB
            // 
            textBoxUSB.Location = new Point(237, 250);
            textBoxUSB.Name = "textBoxUSB";
            textBoxUSB.Size = new Size(391, 27);
            textBoxUSB.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 214);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 4;
            label2.Text = "Back-up lokalition";
            // 
            // buttonBackup
            // 
            buttonBackup.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBackup.Location = new Point(295, 318);
            buttonBackup.Name = "buttonBackup";
            buttonBackup.Size = new Size(171, 80);
            buttonBackup.TabIndex = 5;
            buttonBackup.Text = "Back-up";
            buttonBackup.UseVisualStyleBackColor = true;
            buttonBackup.Click += this.buttonBackup_Click;
            // 
            // buttonSelectFolder
            // 
            buttonSelectFolder.Location = new Point(141, 144);
            buttonSelectFolder.Name = "buttonSelectFolder";
            buttonSelectFolder.Size = new Size(94, 29);
            buttonSelectFolder.TabIndex = 6;
            buttonSelectFolder.Text = "vælg";
            buttonSelectFolder.UseVisualStyleBackColor = true;
            buttonSelectFolder.Click += buttonSelectFolder_Click;
            // 
            // buttonBackupLocation
            // 
            buttonBackupLocation.Location = new Point(140, 249);
            buttonBackupLocation.Name = "buttonBackupLocation";
            buttonBackupLocation.Size = new Size(94, 29);
            buttonBackupLocation.TabIndex = 7;
            buttonBackupLocation.Text = "vælg";
            buttonBackupLocation.UseVisualStyleBackColor = true;
            buttonBackupLocation.Click += buttonBackupLocation_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonBackupLocation);
            Controls.Add(buttonSelectFolder);
            Controls.Add(buttonBackup);
            Controls.Add(label2);
            Controls.Add(textBoxUSB);
            Controls.Add(label1);
            Controls.Add(textBoxFrom);
            Controls.Add(labelPath);
            Name = "Form1";
            Text = "ScooterLand ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private Label labelPath;
        private TextBox textBoxFrom;
        private Label label1;
        private TextBox textBoxUSB;
        private Label label2;
        private Button buttonBackup;
        private Button buttonSelectFolder;
        private Button buttonBackupLocation;
    }
}
