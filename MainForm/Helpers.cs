using System;
using System.Data;
using System.Windows.Forms;

namespace TimeTableAutomation {
    public partial class MainForm {
        private int get_id(DataRow row) {
            return int.Parse(get_field(row, "id"));
        }

        private string get_field(DataRow row, string field = "name") {
            return row[field].ToString();
        }

        private bool is_lecturer_male(DataRow row) {
            return get_field(row, "is_male") == "True";
        }

        public static void RaiseExceptionAndExit(Exception e) {
            MessageBox.Show(
                "Details:\n" + e.Message + "\n\n" + e.StackTrace,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
            Application.Exit();
        }
    }
}