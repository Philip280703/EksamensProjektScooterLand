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
			groupBox1 = new GroupBox();
			label7 = new Label();
			label6 = new Label();
			label5 = new Label();
			label4 = new Label();
			label3 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// labelPath
			// 
			labelPath.AutoSize = true;
			labelPath.Location = new Point(133, 108);
			labelPath.Name = "labelPath";
			labelPath.Size = new Size(170, 20);
			labelPath.TabIndex = 0;
			labelPath.Text = "mappe / fil til kopiering:";
			// 
			// textBoxFrom
			// 
			textBoxFrom.Location = new Point(205, 145);
			textBoxFrom.Name = "textBoxFrom";
			textBoxFrom.ReadOnly = true;
			textBoxFrom.Size = new Size(319, 27);
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
			textBoxUSB.Location = new Point(205, 250);
			textBoxUSB.Name = "textBoxUSB";
			textBoxUSB.ReadOnly = true;
			textBoxUSB.Size = new Size(319, 27);
			textBoxUSB.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(143, 214);
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
			buttonBackup.Click += buttonBackup_Click;
			// 
			// buttonSelectFolder
			// 
			buttonSelectFolder.Location = new Point(109, 144);
			buttonSelectFolder.Name = "buttonSelectFolder";
			buttonSelectFolder.Size = new Size(94, 29);
			buttonSelectFolder.TabIndex = 6;
			buttonSelectFolder.Text = "vælg";
			buttonSelectFolder.UseVisualStyleBackColor = true;
			buttonSelectFolder.Click += buttonSelectFolder_Click;
			// 
			// buttonBackupLocation
			// 
			buttonBackupLocation.Location = new Point(108, 249);
			buttonBackupLocation.Name = "buttonBackupLocation";
			buttonBackupLocation.Size = new Size(94, 29);
			buttonBackupLocation.TabIndex = 7;
			buttonBackupLocation.Text = "vælg";
			buttonBackupLocation.UseVisualStyleBackColor = true;
			buttonBackupLocation.Click += buttonBackupLocation_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(label3);
			groupBox1.Location = new Point(552, 108);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(212, 214);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Guide";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(7, 167);
			label7.Name = "label7";
			label7.Size = new Size(190, 20);
			label7.TabIndex = 4;
			label7.Text = "3. Tryk på back-up knappen";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(21, 130);
			label6.Name = "label6";
			label6.Size = new Size(168, 20);
			label6.TabIndex = 3;
			label6.Text = "på det indsatte USB-stik";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(7, 109);
			label5.Name = "label5";
			label5.Size = new Size(198, 20);
			label5.TabIndex = 2;
			label5.Text = "2. Vælg placering af back-up";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(20, 65);
			label4.Name = "label4";
			label4.Size = new Size(137, 20);
			label4.TabIndex = 1;
			label4.Text = "laves en back-up af";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(6, 40);
			label3.Name = "label3";
			label3.Size = new Size(199, 20);
			label3.TabIndex = 0;
			label3.Text = "1. Vælg mappe som der skal ";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(groupBox1);
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
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
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
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label7;
    }
}
