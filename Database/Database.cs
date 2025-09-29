using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using TimeTableAutomation.Properties;

namespace TimeTableAutomation {
    public partial class Database : IDisposable {
        private readonly SQLiteConnection connection;

        public Database(string db_path, bool is_new = false) {
            try {
                connection = new SQLiteConnection($"Data Source={db_path};Version=3;");
                connection.Open();

                if (is_new)
                    ExecuteNonQuery(Resources.ResourceManager.GetString("schema"));

            } catch (Exception e) {
                MainForm.RaiseExceptionAndExit(e);
            }
        }

        private void ExecuteNonQuery(string query, params SQLiteParameter[] parameters) {
            using (var command = new SQLiteCommand(query, connection)) {
                command.Parameters.AddRange(parameters);
                command.ExecuteNonQuery();
            }
        }

        private DataTable ExecuteQuery(string table, string cols = "*", string where = null) {
            string query = $"SELECT {cols} FROM {table}";
            if (where != null)
                query += " WHERE " + where;
            query += ";";

            return ExecuteRawQuery(query);
        }

        private DataTable ExecuteRawQuery(string query) {
            using (var adapter = new SQLiteDataAdapter(query, connection)) {
                var dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        public void Dispose() {
            connection?.Close();
            connection?.Dispose();
        }
    }
}