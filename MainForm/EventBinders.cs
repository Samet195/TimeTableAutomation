using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimeTableAutomation {
    partial class MainForm {
        private void tsmi_file_new_n_open_Click(object sender, EventArgs e) {
            bool is_new = ((ToolStripMenuItem)sender).Name == "tsmi_file_new";

            FileDialog file_dialog = FileDialogs.GetDialog(is_new);

            if (file_dialog.ShowDialog() == DialogResult.OK)
                EventOpenDB(file_dialog.FileName, is_new);
        }

        private void welcome_tab_Resize(object sender, EventArgs e) {
            pnl_welcome.Location = new Point(
                (welcome_tab.Width - pnl_welcome.Width) / 2,
                (welcome_tab.Height - pnl_welcome.Height) / 2
            );
        }

        private void welcome_tab_btn_Click(object sender, EventArgs e) {
            bool is_new = ((Button)sender).Name == "btn_new";

            FileDialog file_dialog = FileDialogs.GetDialog(is_new);

            if (file_dialog.ShowDialog() == DialogResult.OK)
                EventOpenDB(file_dialog.FileName, is_new);
        }

        private void tsb_toggle_panel_Click(object sender, EventArgs e) {
            spcn_main_view.Panel1Collapsed = !spcn_main_view.Panel1Collapsed;
        }

        private void tsmi_file_closedb_Click(object sender, EventArgs e) {
            CloseDatabase();
        }

        private void tsmi_file_quit_Click(object sender, EventArgs e) {
            ExitApplication();
        }

        private void trvw_sidepanel_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e) {
            ParseNodeClickedEvent(e);
        }

        private void tsddi_close_current_Click(object sender, EventArgs e) {
            CloseTab(TabsToClose.Current);
        }

        private void tsddi_close_on_left_Click(object sender, EventArgs e) {
            CloseTab(TabsToClose.OnLeft);
        }

        private void tsddi_close_on_right_Click(object sender, EventArgs e) {
            CloseTab(TabsToClose.OnRight);
        }

        private void tsddi_close_others_Click(object sender, EventArgs e) {
            CloseTab(TabsToClose.Others);
        }

        private void tsddi_close_all_Click(object sender, EventArgs e) {
            CloseTab(TabsToClose.All);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            ExitApplication();
        }
    }
}
