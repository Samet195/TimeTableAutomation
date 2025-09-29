using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableAutomation.Properties;

namespace TimeTableAutomation
{
    class FileDialogs
    {
        static readonly string FILE_FILTER = Resources.ResourceManager.GetString("db_file_filter");

        public static FileDialog GetDialog(bool is_new )
        {
            return is_new ? NewDialog() : OpenDialog();
        }

        private static FileDialog OpenDialog()
        {
            return new OpenFileDialog
            {
                Title = "Bir Veritanı Aç",
                FilterIndex = 0,
                RestoreDirectory = true,
                Filter = FILE_FILTER
            };
        }

        public static FileDialog NewDialog()
        {
            return new SaveFileDialog
            {
                Title= "Yeni Veritanı Oluştur",
                DefaultExt = "ttdb",
                FileName = "ders_prgramları",
                FilterIndex = 0,
                RestoreDirectory = true,
                Filter = FILE_FILTER
            };
        }
    }
}
