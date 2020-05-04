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
            var configurations = configFile.GetAllConfigurations();

            if (configurations.Length == 0)
            {
                grpConnectionSettings.Enabled = false;
                grpGeneralControls.Enabled = true;
                txtNewServerName.Focus();
            }
            else
            {
                var serverList = new List<string>();
                var databaseList = new List<string>();

                foreach (string config in configurations)
                {
                    var elements = config.Split(',');
                }
            }
        }
    }
}
