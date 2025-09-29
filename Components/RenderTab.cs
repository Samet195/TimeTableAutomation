using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableAutomation {
    internal class RenderTab : TabPage {
        public RenderTab(string title, DataTable dt) {
            Text = title;
            Controls.Add(new RenderGrid(dt));
        }
    }
}
