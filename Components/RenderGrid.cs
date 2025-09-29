using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableAutomation {
    internal class RenderGrid : DataGridView {
        public RenderGrid(DataTable dt) {
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            Dock = DockStyle.Fill;
            DataSource = FormatDt(dt);
        }

        private DataTable FormatDt(DataTable dt) {
            try {
                dt.Columns.Remove("id");
                dt.Columns.Remove("is_deleted");
            } catch { }

            if (dt.Columns.Contains("is_locked")) {
                //Columns.Remove("is_locked");
                RenderCheckBoxColumn("is_locked");
            }

            dt = PrettyHeaderNames(dt);
            return dt;
        }

        private DataTable PrettyHeaderNames(DataTable dt) {
            foreach (DataColumn column in dt.Columns) {
                column.ColumnName = RenderGridHelpers.TryTraslateColumnName(column.ColumnName);
            }

            return dt;
        }

        private void RenderCheckBoxColumn(string column_name) {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn {
                Name = RenderGridHelpers.TryTraslateColumnName(column_name),
                TrueValue = 1,
                FalseValue = 0
            };

            Columns.Add(checkBoxColumn);
        }
    }
}
