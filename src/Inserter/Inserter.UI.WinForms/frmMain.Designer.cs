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
            this.grbConnectionSettings = new System.Windows.Forms.GroupBox();
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
            this.grpGeneralControls = new System.Windows.Forms.GroupBox();
            this.chkWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSourceFilePath = new System.Windows.Forms.TextBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.chkSimpleInsert = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInsertFormat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboDestinationTable = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNewServerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNewDatabaseName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNewServerAlias = new System.Windows.Forms.TextBox();
            this.btnSaveNewServer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDestinationDatabase = new System.Windows.Forms.ComboBox();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.grbConnectionSettings.SuspendLayout();
            this.grpFileAndOutputSettings.SuspendLayout();
            this.grpGeneralControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConnectionSettings
            // 
            this.grbConnectionSettings.Controls.Add(this.btnConnect);
            this.grbConnectionSettings.Controls.Add(this.chkWindowsAuthentication);
            this.grbConnectionSettings.Controls.Add(this.txtPassword);
            this.grbConnectionSettings.Controls.Add(this.txtUser);
            this.grbConnectionSettings.Controls.Add(this.cboDatabase);
            this.grbConnectionSettings.Controls.Add(this.btnNewServer);
            this.grbConnectionSettings.Controls.Add(this.cboServer);
            this.grbConnectionSettings.Controls.Add(this.label4);
            this.grbConnectionSettings.Controls.Add(this.label3);
            this.grbConnectionSettings.Controls.Add(this.label2);
            this.grbConnectionSettings.Controls.Add(this.label1);
            this.grbConnectionSettings.Location = new System.Drawing.Point(12, 12);
            this.grbConnectionSettings.Name = "grbConnectionSettings";
            this.grbConnectionSettings.Size = new System.Drawing.Size(342, 188);
            this.grbConnectionSettings.TabIndex = 0;
            this.grbConnectionSettings.TabStop = false;
            this.grbConnectionSettings.Text = "Connection Settings";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(74, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(149, 20);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(74, 80);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 7;
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(74, 53);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(220, 21);
            this.cboDatabase.TabIndex = 6;
            // 
            // btnNewServer
            // 
            this.btnNewServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewServer.Location = new System.Drawing.Point(300, 24);
            this.btnNewServer.Name = "btnNewServer";
            this.btnNewServer.Size = new System.Drawing.Size(36, 23);
            this.btnNewServer.TabIndex = 5;
            this.btnNewServer.Text = "+";
            this.btnNewServer.UseVisualStyleBackColor = true;
            // 
            // cboServer
            // 
            this.cboServer.FormattingEnabled = true;
            this.cboServer.Location = new System.Drawing.Point(74, 26);
            this.cboServer.Name = "cboServer";
            this.cboServer.Size = new System.Drawing.Size(220, 21);
            this.cboServer.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // grpFileAndOutputSettings
            // 
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
            this.grpFileAndOutputSettings.Location = new System.Drawing.Point(360, 12);
            this.grpFileAndOutputSettings.Name = "grpFileAndOutputSettings";
            this.grpFileAndOutputSettings.Size = new System.Drawing.Size(417, 334);
            this.grpFileAndOutputSettings.TabIndex = 1;
            this.grpFileAndOutputSettings.TabStop = false;
            this.grpFileAndOutputSettings.Text = "File and Output Settings";
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
            this.grpGeneralControls.Location = new System.Drawing.Point(12, 206);
            this.grpGeneralControls.Name = "grpGeneralControls";
            this.grpGeneralControls.Size = new System.Drawing.Size(342, 140);
            this.grpGeneralControls.TabIndex = 2;
            this.grpGeneralControls.TabStop = false;
            this.grpGeneralControls.Text = "General Controls";
            // 
            // chkWindowsAuthentication
            // 
            this.chkWindowsAuthentication.AutoSize = true;
            this.chkWindowsAuthentication.Location = new System.Drawing.Point(74, 132);
            this.chkWindowsAuthentication.Name = "chkWindowsAuthentication";
            this.chkWindowsAuthentication.Size = new System.Drawing.Size(163, 17);
            this.chkWindowsAuthentication.TabIndex = 9;
            this.chkWindowsAuthentication.Text = "Use Windows Authentication";
            this.chkWindowsAuthentication.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 155);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(330, 23);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "File Path";
            // 
            // txtSourceFilePath
            // 
            this.txtSourceFilePath.Location = new System.Drawing.Point(73, 26);
            this.txtSourceFilePath.Name = "txtSourceFilePath";
            this.txtSourceFilePath.Size = new System.Drawing.Size(257, 20);
            this.txtSourceFilePath.TabIndex = 1;
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(336, 24);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFile.TabIndex = 2;
            this.btnSearchFile.Text = "Search...";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            // 
            // chkSimpleInsert
            // 
            this.chkSimpleInsert.AutoSize = true;
            this.chkSimpleInsert.Location = new System.Drawing.Point(73, 55);
            this.chkSimpleInsert.Name = "chkSimpleInsert";
            this.chkSimpleInsert.Size = new System.Drawing.Size(108, 17);
            this.chkSimpleInsert.TabIndex = 3;
            this.chkSimpleInsert.Text = "Use Simple Insert";
            this.chkSimpleInsert.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Format";
            // 
            // txtInsertFormat
            // 
            this.txtInsertFormat.Location = new System.Drawing.Point(73, 80);
            this.txtInsertFormat.Multiline = true;
            this.txtInsertFormat.Name = "txtInsertFormat";
            this.txtInsertFormat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInsertFormat.Size = new System.Drawing.Size(257, 69);
            this.txtInsertFormat.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Table";
            // 
            // cboDestinationTable
            // 
            this.cboDestinationTable.FormattingEnabled = true;
            this.cboDestinationTable.Location = new System.Drawing.Point(73, 182);
            this.cboDestinationTable.Name = "cboDestinationTable";
            this.cboDestinationTable.Size = new System.Drawing.Size(257, 21);
            this.cboDestinationTable.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(6, 215);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(405, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Server Name";
            // 
            // txtNewServerName
            // 
            this.txtNewServerName.Location = new System.Drawing.Point(81, 28);
            this.txtNewServerName.Name = "txtNewServerName";
            this.txtNewServerName.Size = new System.Drawing.Size(255, 20);
            this.txtNewServerName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Database";
            // 
            // txtNewDatabaseName
            // 
            this.txtNewDatabaseName.Location = new System.Drawing.Point(81, 54);
            this.txtNewDatabaseName.Name = "txtNewDatabaseName";
            this.txtNewDatabaseName.Size = new System.Drawing.Size(255, 20);
            this.txtNewDatabaseName.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Alias";
            // 
            // txtNewServerAlias
            // 
            this.txtNewServerAlias.Location = new System.Drawing.Point(81, 80);
            this.txtNewServerAlias.Name = "txtNewServerAlias";
            this.txtNewServerAlias.Size = new System.Drawing.Size(255, 20);
            this.txtNewServerAlias.TabIndex = 5;
            // 
            // btnSaveNewServer
            // 
            this.btnSaveNewServer.Location = new System.Drawing.Point(6, 108);
            this.btnSaveNewServer.Name = "btnSaveNewServer";
            this.btnSaveNewServer.Size = new System.Drawing.Size(330, 23);
            this.btnSaveNewServer.TabIndex = 6;
            this.btnSaveNewServer.Text = "Save";
            this.btnSaveNewServer.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Database";
            // 
            // cboDestinationDatabase
            // 
            this.cboDestinationDatabase.FormattingEnabled = true;
            this.cboDestinationDatabase.Location = new System.Drawing.Point(73, 155);
            this.cboDestinationDatabase.Name = "cboDestinationDatabase";
            this.cboDestinationDatabase.Size = new System.Drawing.Size(257, 21);
            this.cboDestinationDatabase.TabIndex = 10;
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(6, 244);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.Size = new System.Drawing.Size(405, 81);
            this.rtbMessages.TabIndex = 11;
            this.rtbMessages.Text = "";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 356);
            this.Controls.Add(this.grpGeneralControls);
            this.Controls.Add(this.grpFileAndOutputSettings);
            this.Controls.Add(this.grbConnectionSettings);
            this.Name = "frmMain";
            this.Text = "Inserter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbConnectionSettings.ResumeLayout(false);
            this.grbConnectionSettings.PerformLayout();
            this.grpFileAndOutputSettings.ResumeLayout(false);
            this.grpFileAndOutputSettings.PerformLayout();
            this.grpGeneralControls.ResumeLayout(false);
            this.grpGeneralControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConnectionSettings;
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
    }
}

