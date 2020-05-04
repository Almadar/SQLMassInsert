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

            cboServer.DataSource = serverList;
            cboServer.SelectedIndex = 0;

            string server = (string)cboServer.SelectedItem;
            string alias = server.Substring(0, server.IndexOf(' '));
            string name = server.Substring(server.IndexOf('-') + 2);

            var databaseList = configFile.GetAllDatabasesInServer(alias, name);

            cboDatabase.DataSource = databaseList;
            cboDatabase.SelectedIndex = 0;
        }
    }
}
