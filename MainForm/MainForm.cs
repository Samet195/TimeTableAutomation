using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using TimeTableAutomation.Properties;

/* TODO: TO BE IMPLEMENT
 * Confliction checker must be implemented.
 * Add lock/unlock ablility for entries
 */

namespace TimeTableAutomation {
    public partial class MainForm : Form {
        private Database db = null;

        public MainForm() {
            InitializeComponent();
        }

        private void CloseDatabase() {
            tslbl_status.Text = "Hoşgeldiniz";
            db.Dispose();
            db = null;

            CloseTab(TabsToClose.All);
            trvw_sidepanel.Nodes.Clear();
            tsmi_file_closedb.Visible = false;

            tabs.Controls.Add(welcome_tab);
        }

        private void ExitApplication() {
            if (db != null)
                CloseDatabase();

            Application.Exit();
        }
    }
}

