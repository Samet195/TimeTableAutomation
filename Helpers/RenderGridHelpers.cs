using System.Collections.Generic;

namespace TimeTableAutomation {
    internal static class RenderGridHelpers {
        private static Dictionary<string, string> column_names = new Dictionary<string, string> {
            { "name", "Ad" },
            { "surname", "Soyad" },
            { "code", "Kod" },
            { "grade", "Yıl" },
            { "branch", "Şube" },
            { "program", "Program" },
            { "lesson", "Ders"},
            { "classroom", "Derslik"},
            { "lecturer", "Öğretim Görevlisi"},
            { "class", "Sınıf"},
            { "is_locked", "Kilitli mi?"},
        };

        public static string TryTraslateColumnName(string column_name) {
            if (column_names.ContainsKey(column_name))
                return column_names[column_name];
            else
                return column_name;
        }
    }
}