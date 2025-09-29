using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableAutomation {

    partial class MainForm {
        private void EventOpenDB(string path, bool is_new) {
            if (db != null)
                CloseDatabase();

            db = new Database(path, is_new);

            tslbl_status.Text = path;
            tsmi_file_closedb.Visible = true;
            RenderSideMenuEntries();
            spcn_main_view.Panel1Collapsed = false;
            tabs.Controls.RemoveByKey("welcome_tab");
        }

        private void ParseNodeClickedEvent(TreeNodeMouseClickEventArgs e) {
            var node = e.Node;
            var parent_node = node.Parent;

            if (parent_node == null)
                return;

            DataTable dt;
            string group_title, title;

            switch (parent_node.Tag) {
                case GroupTags.Classes:
                    dt = db.GetClassView((int)node.Tag);
                    group_title = parent_node.Parent.Text;
                    title = group_title + " - " + node.Text;

                    NewRenderTab(title, dt);
                    break;

                case GroupTags.Classrooms:
                    dt = db.GetClassroomView((int)node.Tag);
                    group_title = parent_node.Parent.Text;
                    title = group_title + " - " + node.Text;

                    NewRenderTab(title, dt);
                    break;

                case GroupTags.Lecturers:
                    dt = db.GetLecturerView((int)node.Tag);
                    group_title = "Hoca";
                    title = group_title + ": " + node.Text;

                    NewRenderTab(title, dt);
                    break;

                default:
                    break;
            }
        }

        private void NewRenderTab(string title, DataTable dt) {
var existing_tab = tabs.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Text == title);

if (existing_tab == null) {
    var newtab = new RenderTab(title, dt);
    tabs.Controls.Add(newtab);
    tabs.SelectedTab = newtab;
} else {
    tabs.SelectedTab = existing_tab;
}
        }

        private void CloseTab(TabsToClose tab_to_close) {
            // TODO: Prevent to close unsaved tabs
            var current_tab = tabs.SelectedTab;

            switch (tab_to_close) {
                case TabsToClose.Current:
                    if (current_tab != null)
                        tabs.TabPages.Remove(current_tab);
                    break;

                case TabsToClose.Others:
                    if (current_tab != null)
                        foreach (TabPage tab in tabs.TabPages) {
                            if (tab != current_tab)
                                tabs.TabPages.Remove(tab);
                        }
                    break;

                case TabsToClose.OnLeft:
                    if (current_tab != null) {
                        int index = tabs.TabPages.IndexOf(current_tab);
                        for (int i = index - 1; i >= 0; i--) {
                            tabs.TabPages.RemoveAt(i);
                        }
                    }
                    break;

                case TabsToClose.OnRight:
                    if (current_tab != null) {
                        int index = tabs.TabPages.IndexOf(current_tab);
                        for (int i = tabs.TabPages.Count - 1; i > index; i--) {
                            tabs.TabPages.RemoveAt(i);
                        }
                    }
                    break;

                case TabsToClose.All:
                    tabs.TabPages.Clear();
                    break;
            }
        }
    }
}
