namespace Inserter.UI.WinForms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpConnectionSettings = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.btnNewServer = new System.Windows.Forms.Button();
            this.cboServer = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFileAndOutputSettings = new System.Windows.Forms.GroupBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.cboDestinationDatabase = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.cboDestinationTable = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInsertFormat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkSimpleInsert = new System.Windows.Forms.CheckBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpGeneralControls = new System.Windows.Forms.GroupBox();
            this.btnSaveNewServer = new System.Windows.Forms.Button();
            this.txtNewServerAlias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewDatabaseName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewServerName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpConnectionSettings.SuspendLayout();
            this.grpFileAndOutputSettings.SuspendLayout();
            this.grpGeneralControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConnectionSettings
            // 
            this.grpConnectionSettings.Controls.Add(this.btnConnect);
            this.grpConnectionSettings.Controls.Add(this.chkWindowsAuthentication);
            this.grpConnectionSettings.Controls.Add(this.txtPassword);
            this.grpConnectionSettings.Controls.Add(this.txtUser);
            this.grpConnectionSettings.Controls.Add(this.cboDatabase);
            this.grpConnectionSettings.Controls.Add(this.btnNewServer);
            this.grpConnectionSettings.Controls.Add(this.cboServer);
            this.grpConnectionSettings.Controls.Add(this.label4);
            this.grpConnectionSettings.Controls.Add(this.label3);
            this.grpConnectionSettings.Controls.Add(this.label2);
            this.grpConnectionSettings.Controls.Add(this.label1);
            this.grpConnectionSettings.Location = new System.Drawing.Point(16, 15);
            this.grpConnectionSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnectionSettings.Name = "grpConnectionSettings";
            this.grpConnectionSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpConnectionSettings.Size = new System.Drawing.Size(456, 231);
            this.grpConnectionSettings.TabIndex = 0;
            this.grpConnectionSettings.TabStop = false;
            this.grpConnectionSettings.Text = "Connection Settings";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 191);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(440, 28);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "&Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkWindowsAuthentication
            // 
            this.chkWindowsAuthentication.AutoSize = true;
            this.chkWindowsAuthentication.Location = new System.Drawing.Point(99, 162);
            this.chkWindowsAuthentication.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkWindowsAuthentication.Name = "chkWindowsAuthentication";
            this.chkWindowsAuthentication.Size = new System.Drawing.Size(209, 21);
            this.chkWindowsAuthentication.TabIndex = 9;
            this.chkWindowsAuthentication.Text = "Use Windows Authentication";
            this.chkWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 130);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(197, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(99, 98);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 22);
            this.txtUser.TabIndex = 7;
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(99, 65);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(292, 24);
            this.cboDatabase.TabIndex = 6;
            // 
            // btnNewServer
            // 
            this.btnNewServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewServer.Location = new System.Drawing.Point(400, 30);
            this.btnNewServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(48, 28);
            this.btnNewServer.TabIndex = 5;
            this.btnNewServer.Text = "+";
            this.btnNewServer.UseVisualStyleBackColor = true;
            this.btnNewServer.Click += new System.EventHandler(this.btnNewServer_Click);
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(99, 32);
            this.cboServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(292, 24);
            this.cboServer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // grpFileAndOutputSettings
            // 
            this.grpFileAndOutputSettings.Controls.Add(this.btnCancel);
            this.grpFileAndOutputSettings.Controls.Add(this.rtbMessages);
            this.grpFileAndOutputSettings.Controls.Add(this.cboDestinationDatabase);
            this.grpFileAndOutputSettings.Controls.Add(this.label11);
            this.grpFileAndOutputSettings.Controls.Add(this.btnInsert);
            this.grpFileAndOutputSettings.Controls.Add(this.cboDestinationTable);
            this.grpFileAndOutputSettings.Controls.Add(this.label7);
            this.grpFileAndOutputSettings.Controls.Add(this.txtInsertFormat);
            this.grpFileAndOutputSettings.Controls.Add(this.label6);
            this.grpFileAndOutputSettings.Controls.Add(this.chkSimpleInsert);
            this.grpFileAndOutputSettings.Controls.Add(this.btnSearchFile);
            this.grpFileAndOutputSettings.Controls.Add(this.txtSourceFilePath);
            this.grpFileAndOutputSettings.Controls.Add(this.label5);
            this.grpFileAndOutputSettings.Location = new System.Drawing.Point(480, 15);
            this.grpFileAndOutputSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFileAndOutputSettings.Name = "grpFileAndOutputSettings";
            this.grpFileAndOutputSettings.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFileAndOutputSettings.Size = new System.Drawing.Size(556, 411);
            this.grpFileAndOutputSettings.TabIndex = 1;
            this.grpFileAndOutputSettings.TabStop = false;
            this.grpFileAndOutputSettings.Text = "File and Output Settings";
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(8, 300);
            this.rtbMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(539, 99);
            this.rtbMessages.TabIndex = 11;
            this.rtbMessages.Text = "";
            // 
            // cboDestinationDatabase
            // 
            this.cboDestinationDatabase.FormattingEnabled = true;
            this.cboDestinationDatabase.Location = new System.Drawing.Point(97, 191);
            this.cboDestinationDatabase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDestinationDatabase.Name = "cboDestinationDatabase";
            this.cboDestinationDatabase.Size = new System.Drawing.Size(344, 24);
            this.cboDestinationDatabase.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 194);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "Database";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(8, 265);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(257, 28);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "&Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // cboDestinationTable
            // 
            this.cboDestinationTable.FormattingEnabled = true;
            this.cboDestinationTable.Location = new System.Drawing.Point(97, 224);
            this.cboDestinationTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDestinationTable.Name = "cboDestinationTable";
            this.cboDestinationTable.Size = new System.Drawing.Size(344, 24);
            this.cboDestinationTable.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 228);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Table";
            // 
            // txtInsertFormat
            // 
            this.txtInsertFormat.Location = new System.Drawing.Point(97, 98);
            this.txtInsertFormat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInsertFormat.Multiline = true;
            this.txtInsertFormat.Name = "txtInsertFormat";
            this.txtInsertFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInsertFormat.Size = new System.Drawing.Size(344, 84);
            this.txtInsertFormat.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Format";
            // 
            // chkSimpleInsert
            // 
            this.chkSimpleInsert.AutoSize = true;
            this.chkSimpleInsert.Location = new System.Drawing.Point(97, 68);
            this.chkSimpleInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSimpleInsert.Name = "chkSimpleInsert";
            this.chkSimpleInsert.Size = new System.Drawing.Size(140, 21);
            this.chkSimpleInsert.TabIndex = 3;
            this.chkSimpleInsert.Text = "Use Simple Insert";
            this.chkSimpleInsert.UseVisualStyleBackColor = true;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(449, 29);
            this.btnSearchFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(100, 28);
            this.btnSearchFile.TabIndex = 2;
            this.btnSearchFile.Text = "S&earch...";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Location = new System.Drawing.Point(97, 32);
            this.txtSourceFilePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.Size = new System.Drawing.Size(344, 22);
            this.txtSourceFilePath.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "File Path";
            // 
            // grpGeneralControls
            // 
            this.grpGeneralControls.Controls.Add(this.btnSaveNewServer);
            this.grpGeneralControls.Controls.Add(this.txtNewServerAlias);
            this.grpGeneralControls.Controls.Add(this.label10);
            this.grpGeneralControls.Controls.Add(this.txtNewDatabaseName);
            this.grpGeneralControls.Controls.Add(this.label9);
            this.grpGeneralControls.Controls.Add(this.txtNewServerName);
            this.grpGeneralControls.Controls.Add(this.label8);
            this.grpGeneralControls.Location = new System.Drawing.Point(16, 254);
            this.grpGeneralControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGeneralControls.Name = "grpGeneralControls";
            this.grpGeneralControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpGeneralControls.Size = new System.Drawing.Size(456, 172);
            this.grpGeneralControls.TabIndex = 2;
            this.grpGeneralControls.TabStop = false;
            this.grpGeneralControls.Text = "General Controls";
            // 
            // btnSaveNewServer
            // 
            this.btnSaveNewServer.Location = new System.Drawing.Point(8, 133);
            this.btnSaveNewServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveNewServer.Name = "btnSaveNewServer";
            this.btnSaveNewServer.Size = new System.Drawing.Size(440, 28);
            this.btnSaveNewServer.TabIndex = 6;
            this.btnSaveNewServer.Text = "&Save";
            this.btnSaveNewServer.UseVisualStyleBackColor = true;
            this.btnSaveNewServer.Click += new System.EventHandler(this.btnSaveNewServer_Click);
            // 
            // txtNewServerAlias
            // 
            this.txtNewServerAlias.Location = new System.Drawing.Point(108, 98);
            this.txtNewServerAlias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewServerAlias.Name = "txtNewServerAlias";
            this.txtNewServerAlias.Size = new System.Drawing.Size(339, 22);
            this.txtNewServerAlias.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 102);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alias";
            // 
            // txtNewDatabaseName
            // 
            this.txtNewDatabaseName.Location = new System.Drawing.Point(108, 66);
            this.txtNewDatabaseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewDatabaseName.Name = "txtNewDatabaseName";
            this.txtNewDatabaseName.Size = new System.Drawing.Size(339, 22);
            this.txtNewDatabaseName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Database";
            // 
            // txtNewServerName
            // 
            this.txtNewServerName.Location = new System.Drawing.Point(108, 34);
            this.txtNewServerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewServerName.Name = "txtNewServerName";
            this.txtNewServerName.Size = new System.Drawing.Size(339, 22);
            this.txtNewServerName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 38);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(292, 265);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(257, 28);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "C&ancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 438);
            this.Controls.Add(this.grpGeneralControls);
            this.Controls.Add(this.grpFileAndOutputSettings);
            this.Controls.Add(this.grpConnectionSettings);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Inserter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpConnectionSettings.ResumeLayout(false);
            this.grpConnectionSettings.PerformLayout();
            this.grpFileAndOutputSettings.ResumeLayout(false);
            this.grpFileAndOutputSettings.PerformLayout();
            this.grpGeneralControls.ResumeLayout(false);
            this.grpGeneralControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConnectionSettings;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Button btnNewServer;
        private System.Windows.Forms.ComboBox cboServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFileAndOutputSettings;
        private System.Windows.Forms.GroupBox grpGeneralControls;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkWindowsAuthentication;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cboDestinationTable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInsertFormat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkSimpleInsert;
        private System.Windows.Forms.Button btnSearchFile;
        private System.Windows.Forms.TextBox txtSourceFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSaveNewServer;
        private System.Windows.Forms.TextBox txtNewServerAlias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNewDatabaseName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewServerName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.ComboBox cboDestinationDatabase;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCancel;
    }
}

