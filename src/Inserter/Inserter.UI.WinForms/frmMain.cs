using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Inserter.Logic;
using Inserter.Logic.Database;
using Inserter.Logic.Files;

namespace Inserter.UI.WinForms
{
    public partial class frmMain : Form
    {
        private DatabaseObjectExplorer dbObjectExplorer;
        private ConfigFileHandler configFile;

        public frmMain()
        {
            InitializeComponent();
            string exePath = Application.ExecutablePath;
            string appPath = exePath.Substring(0, exePath.LastIndexOf(@"\") + 1);
            configFile = new ConfigFileHandler(appPath + Constants.CONNECTION_CONFIGURATION_FILE_NAME);            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetInitialControlStatus();
            LoadData();
        }

        private void SetInitialControlStatus()
        {
            grpFileAndOutputSettings.Enabled = false;
            grpGeneralControls.Enabled = false;
        }

        private void LoadData()
        {
            var serverList = configFile.GetAllServers();

            if (serverList.Count > 0)
            {
                cboServer.DataSource = serverList;
                cboServer.SelectedIndex = 0;

                string server = (string)cboServer.SelectedItem;
                string alias = server.Substring(0, server.IndexOf(' '));
                string name = server.Substring(server.IndexOf('-') + 2);

                var databaseList = configFile.GetAllDatabasesInServer(alias, name);

                cboDatabase.DataSource = databaseList;
                cboDatabase.SelectedIndex = 0;
            }
            else 
            {
                grpConnectionSettings.Enabled = false;
                grpGeneralControls.Enabled = true;
                txtNewServerName.Focus();
            }
        }

        private void CleanupGroupbox(GroupBox container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is TextBox)
                {
                    var control = c as TextBox;
                    control.Text = string.Empty;
                }
                else if (c is ComboBox)
                {
                    var control = c as ComboBox;
                    control.SelectedIndex = -1;
                }
                else if (c is CheckBox)
                {
                    var control = c as CheckBox;
                    control.Checked = false;
                }
            }
        }

        private void btnNewServer_Click(object sender, EventArgs e)
        {
            grpGeneralControls.Enabled = true;
            grpConnectionSettings.Enabled = false;
            CleanupGroupbox(grpConnectionSettings);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (chkWindowsAuthentication.Checked)
            {

            }
            else
            { 

            }

            grpFileAndOutputSettings.Enabled = false;
            grpConnectionSettings.Enabled = false;
            CleanupGroupbox(grpConnectionSettings);
        }

        private void btnSaveNewServer_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchFile_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }
    }
}
