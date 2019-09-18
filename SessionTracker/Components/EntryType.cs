using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SessionTracker.Components
{
    public partial class EntryType : Form
    {
        private String _type = "Pause";
        public String Type { get { return _type; } } 
        public EntryType()
        {
            InitializeComponent();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            _type = "Pause";
            Close();
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            _type = "Meeting";
            Close();
        }
    }
}
